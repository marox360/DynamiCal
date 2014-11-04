using DynamiCal.View.DataGridView.BindingSources;
using DynamiCal.Model;
using DynamiCal.Time;
using DynamiCal.View.TreeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DynamiCal.Filters;
using DynamiCal.Model.Calendars;
using DynamiCal.Presentation;
using DynamiCal.View;

namespace DynamiCal.Forms
{
    public partial class MainForm : Form
    {
        private IFiltroPresenter _calendarTreeViewPresenter;
        private IFiltroPresenter _searchBoxPresenter;
        private CalendarDataGridViewPresenter _calendarGridViewPresenter;
        private IFiltraggio _filtraggio;
        private IFiltraggio _filtraggioCalendarGrid;

        public MainForm()
        {
            InitializeComponent();

            Agenda.Instance.AggiungiModelloEvento(new ModelloEvento("Base"));

            Calendario testCalendar = new CalendarioLocale("Test Calendar");
            testCalendar.AggiungiEvento(new Evento("Test", new PeriodoTempo(DateTime.Now, TimeSpan.FromMinutes(60)), Agenda.Instance.ModelliEvento[0], null, "Questo è un evento generato automaticamente nella giornata di oggi", "Ovunque :D"));
            Agenda.Instance.AggiungiCalendario(testCalendar);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _filtraggio = new RisultatoFiltraggio(null);
            EventPickerControl eventPicker = new EventPickerControl(this.eventPanel, this.eventsListBox);
            new EventPickerPresenter(eventPicker, _filtraggio);

            _calendarTreeViewPresenter = new CalendarTreeViewPresenter(this.calendarTreeView);
            _calendarTreeViewPresenter.FilterChanged += UpdateFilter;

            _searchBoxPresenter = new SearchBoxPanelPresenter(this.searchBoxPanel);
            _searchBoxPresenter.FilterChanged += UpdateTextFilter;

            _filtraggioCalendarGrid = new RisultatoFiltraggio(null);
            _calendarGridViewPresenter = new CalendarDataGridViewPresenter(this.calendarGridView, _filtraggioCalendarGrid);
            _calendarGridViewPresenter.LastDateChanged += LastDateChanged;
            _calendarGridViewPresenter.FilterChanged += UpdateTextFilter;
            _filtraggioCalendarGrid.Filtro = this.CurrentFilter;
        }

        private IFiltro CurrentFilter
        {
            get
            {
                CriterioFiltraggio criterioFiltraggio = new CriterioFiltraggio(Agenda.Instance.Calendari);

                IFiltro filtroCalendari = _calendarTreeViewPresenter.Filter(criterioFiltraggio);

                return filtroCalendari;
            }
        }

        private void UpdateTextFilter(object sender, EventArgs e)
        {
            _filtraggio.Filtro = _searchBoxPresenter.Filter(FiltroFactory.FiltraPerData(this.CurrentFilter, _calendarGridViewPresenter.LastDate));
        }

        private void UpdateFilter(object sender, EventArgs e)
        {
            _filtraggioCalendarGrid.Filtro = this.CurrentFilter;
        }

        private void LastDateChanged(object sender, CalendarDataGridViewEventArgs e)
        {
            this.monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(e.Date.Month);
            this.yearLabel.Text = e.Date.Year.ToString();
            this.topRightPanel.Visible = e.NumberOfEvents > 0;
            
            if (e.NumberOfEvents > 0)
            {
                this.eventPanel.OverrideDate = e.Date;
            }
        }

        #region DatePicker
        private void datePicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            _calendarGridViewPresenter.ShowMonthOfDay(e.Start);
        }
        #endregion

        #region ToolStipMenuItems
        private void createCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ManageCalendarForm createCalendarDialog = new ManageCalendarForm())
            {
                createCalendarDialog.ShowDialog(this);
            }
        }

        private void creaModelloEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateEventModelForm createEventModelDialog = new CreateEventModelForm())
            {
                createEventModelDialog.ShowDialog(this);
            }
        }
        
        private void creaEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ManageEventForm createEventDialog = new ManageEventForm())
            {
                createEventDialog.eventDateTimePicker.Value = _calendarGridViewPresenter.LastDate.Date + (DateTime.Now - DateTime.Today);

                if (createEventDialog.ShowDialog(this) == DialogResult.OK)
                {
                    _calendarGridViewPresenter.RefreshControl();
                }
            }
        }

        private void cercaEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SearchEventForm searchEventDialog = new SearchEventForm())
            {
                if (searchEventDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Evento evento = searchEventDialog.SelectedEvent;
                    if (evento != null)
                    {
                        _calendarGridViewPresenter.ShowMonthOfDay(evento.Periodo.DataInizio);
                        this.eventsListBox.SelectedItem = evento;
                    }
                }
            }
        }   
        private void eliminaModelloEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DeleteEventModelForm deleteEventModelDialog = new DeleteEventModelForm())
            {
                deleteEventModelDialog.ShowDialog(this);
            }
        }

        private void toolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;

            if (item.HasDropDownItems)
            {
                item.ShowDropDown();
            }
        }
        #endregion

        #region CalendarTreeView
        private void calendarTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is CalendarTreeNode && e.Button == MouseButtons.Right)
            {
                this.calendarTreeView.SelectedNode = e.Node;
                this.treeNodeMenuStrip.Show(this.calendarTreeView, e.Location);
            }
        }
        #endregion

        #region TreeNodeMenuStrip
        private void treeNodeMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Calendario calendario = null;
            Evento evento = null;
            if (this.treeNodeMenuStrip.SourceControl is System.Windows.Forms.TreeView)
            {
                CalendarTreeNode calendarNode = (this.treeNodeMenuStrip.SourceControl as System.Windows.Forms.TreeView).SelectedNode as CalendarTreeNode;
                calendario = calendarNode.Calendario;
            }
            else if (this.treeNodeMenuStrip.SourceControl is ListBox) {
                evento = (this.treeNodeMenuStrip.SourceControl as ListBox).SelectedItem as Evento;
            }
            
            switch (e.ClickedItem.Text)
            {
                case "Elimina":
                    if (calendario != null)
                    {
                        Agenda.Instance.RimuoviCalendario(calendario);
                    }
                    if (evento != null)
                    {
                        foreach (Calendario calendar in Agenda.Instance.Calendari)
                        {
                            calendar.RimuoviEvento(evento);
                        }

                        _calendarGridViewPresenter.RefreshControl();
                    }
                    break;

                case "Modifica":
                    if (calendario != null)
                    {
                        using (ManageCalendarForm editCalendarDialog = new ManageCalendarForm())
                        {
                            editCalendarDialog.LoadCalendario(calendario);
                            editCalendarDialog.ShowDialog(this);
                        }
                    }
                    if (evento != null)
                    {
                        using (ManageEventForm editEventDialog = new ManageEventForm())
                        {
                            editEventDialog.LoadEvento(evento);
                            editEventDialog.ShowDialog(this);
                        }

                        _calendarGridViewPresenter.RefreshControl();
                    }
                    break;
                
                default: break;
            }
        }
        #endregion

        #region EventsListBox
        private void eventsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            int index = this.eventsListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches && e.Button == MouseButtons.Right)
            {
                this.eventsListBox.SelectedIndex = index;
                this.treeNodeMenuStrip.Show(this.eventsListBox, e.Location);
            }
        }
        #endregion

    }
}