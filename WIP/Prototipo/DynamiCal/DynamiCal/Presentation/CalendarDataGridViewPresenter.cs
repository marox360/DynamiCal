using DynamiCal.Time;
using DynamiCal.Filters;
using DynamiCal.View.DataGridView;
using DynamiCal.View.DataGridView.BindingSources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation
{
    public class CalendarDataGridViewPresenter : FiltroPresenter<CalendarDataGridView> 
    {
        private readonly IFiltraggio _filtraggio;
        private DateTime _lastDate = DateTime.Today;
        public event CalendarDataGridViewEventHandler LastDateChanged;

        public CalendarDataGridViewPresenter(CalendarDataGridView calendarGridView, IFiltraggio filtraggio) : base(calendarGridView)
        {
            _filtraggio = filtraggio;
            _filtraggio.FilterChanged += filtraggio_FilterChanged;

            calendarGridView.CellClick += calendarGridView_CellClick;
            calendarGridView.CurrentCellChanged += calendarGridView_CurrentCellChanged;

            this.RefreshControl();
        }

        protected override void InitializeControl()
        {
            base.InitializeControl();

            this.Control.RowTemplate.Height = (this.Control.Height - this.Control.ColumnHeadersHeight) / 6;
        }

        public void RefreshControl()
        {
            this.ShowMonthOfDay(this.LastDate);
        }

        public IFiltraggio Filtraggio
        {
            get
            {
                return _filtraggio;
            }
        }

        public DateTime LastDate
        {
            private set
            {
                if (_lastDate != value)
                {
                    _lastDate = value;

                    this.OnLastDateChanged(new CalendarDataGridViewEventArgs(_lastDate, this.NumberOfEvents(_lastDate)));
                    this.OnFilterChanged();
                }
            }
            get
            {
                return _lastDate;
            }
        }

        public override IFiltro Filter(IFiltro filtro)
        {
            return FiltroFactory.FiltraPerPeriodo(filtro,
                    new DateTime(_lastDate.Year, _lastDate.Month, 1).AddDays(-14),
                    new DateTime(_lastDate.Year + Math.Max(_lastDate.Month, 0), _lastDate.Month + 1 > 12 ? 1 : _lastDate.Month + 1, 14).EndOfTheDay());
        }

        private void filtraggio_FilterChanged(object sender, EventArgs e)
        {
            this.RefreshControl();
        }

        private void calendarGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Il click su una delle celle dell'header causa RowIndex == -1
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewCell selectedCell = this.Control[e.ColumnIndex, e.RowIndex];
            if (selectedCell.Value is CalendarDay)
            {
                CalendarDay calendarDay = selectedCell.Value as CalendarDay;
                this.LastDate = calendarDay.Date;

                if (e.RowIndex == 0 && calendarDay.Date.Day > 7)
                {
                    this.ShowMonthOfDay(calendarDay.Date);
                }
                else if (e.RowIndex >= 4 && calendarDay.Date.Day < 15)
                {
                    this.ShowMonthOfDay(calendarDay.Date);
                }
            }
        }

        private void calendarGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = this.Control.CurrentCell;
            if (currentCell != null && currentCell.Value != null && currentCell.Value is CalendarDay)
            {
                this.LastDate = (currentCell.Value as CalendarDay).Date;
            }
        }

        protected void OnLastDateChanged(CalendarDataGridViewEventArgs e)
        {
            if (this.LastDateChanged != null)
            {
                this.LastDateChanged(this, e);
            }
        }
        
        public void ShowMonthOfDay(DateTime date)
        {
            this.LastDate = date;

            MonthlySource.FillSource(this.Control.DataSource as BindingSource, date, this.Filtraggio.Filtro != null ? this.Filter(this.Filtraggio.Filtro) : null);

            this.SelectDay(date);
        }

        private void SelectDay(DateTime date)
        {
            this.Control.CurrentCell = this.Control.Rows.Cast<DataGridViewRow>()
                .SelectMany(row => row.Cells.Cast<DataGridViewCell>())
                .FirstOrDefault(cell => cell.Value is CalendarDay && (cell.Value as CalendarDay).Date.IsSameDayOf(date));
        }

        private int NumberOfEvents(DateTime date)
        {
            return this.Control.Rows.Cast<DataGridViewRow>()
                .SelectMany(row => row.Cells.Cast<DataGridViewCell>())
                .Where(cell => cell.Value is CalendarDay && (cell.Value as CalendarDay).Date.IsSameDayOf(date))
                .Select(cell => (cell.Value as CalendarDay).NumberOfEvents)
                .DefaultIfEmpty(0).FirstOrDefault();
        }
    }

    public class CalendarDataGridViewEventArgs : EventArgs
    {
        public CalendarDataGridViewEventArgs(DateTime date, int numberOfEvents)
        {
            this.Date = date;
            this.NumberOfEvents = numberOfEvents;
        }

        public DateTime Date { get; private set; }

        public int NumberOfEvents { get; private set; }
    }

    public delegate void CalendarDataGridViewEventHandler(object source, CalendarDataGridViewEventArgs e);
}
