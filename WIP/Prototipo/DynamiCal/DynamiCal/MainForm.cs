using DynamiCal.DataGridView.BindingSources;
using DynamiCal.Model;
using DynamiCal.Extension;
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

namespace DynamiCal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            calendarTreeView.ExpandAll();

            Agenda.Instance.CalendarsChanged += CalendarsChanged;
            Agenda.Instance.AggiungiCalendario(new CalendarioLocale("Test Calendar"));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            calendarGridView.RowTemplate.Height = (calendarGridView.Height - calendarGridView.ColumnHeadersHeight) / 6;
            ShowMonthOfDay(DateTime.Today);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Agenda.Instance.CalendarsChanged -= CalendarsChanged;
        }

        private void ShowMonthOfDay(DateTime date)
        {
            monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month);
            yearLabel.Text = date.Year.ToString();

            MonthlySource.FillSource(weekBindingSource, date);
            SelectDay(date);
        }

        private void SelectDay(DateTime date)
        {
            foreach (DataGridViewRow row in calendarGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is CalendarDay && (cell.Value as CalendarDay).Date.IsSameDayOf(date))
                    {
                        calendarGridView.CurrentCell = cell;
                        return;
                    }
                }
            }
        }

        private void CalendarsChanged(object sender, EventArgs e)
        {
            calendarTreeView.Nodes["LocalCalendars"].Nodes.Clear();
            calendarTreeView.Nodes["SharedCalendars"].Nodes.Clear();

            foreach (Calendario calendario in Agenda.Instance.Calendari)
            {
                TreeNode node = new TreeNode(calendario.Nome);
                if (calendario is CalendarioLocale)
                {
                    calendarTreeView.Nodes["LocalCalendars"].Nodes.Add(node);
                }
                else if (calendario is CalendarioCondiviso)
                {
                    calendarTreeView.Nodes["SharedCalendars"].Nodes.Add(node);
                }
            }

            calendarTreeView.Sort();
        }

        private void calendarGridView_Resize(object sender, EventArgs e)
        {
            calendarGridView.RowTemplate.Height = (calendarGridView.Height - calendarGridView.ColumnHeadersHeight) / 6;
            foreach (DataGridViewRow row in calendarGridView.Rows)
            {
                row.Height = calendarGridView.RowTemplate.Height;
            }
        }

        private void datePicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            ShowMonthOfDay(e.Start);
        }

        private void calendarGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Il click su una delle celle dell'header causa RowIndex == -1
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewCell selectedCell = calendarGridView[e.ColumnIndex, e.RowIndex];
            if (selectedCell.Value is CalendarDay)
            {
                CalendarDay calendarDay = selectedCell.Value as CalendarDay;
                if (e.RowIndex == 0 && calendarDay.Date.Day > 7)
                {
                    ShowMonthOfDay(calendarDay.Date);
                }
                else if (e.RowIndex >= 4 && calendarDay.Date.Day < 15)
                {
                    ShowMonthOfDay(calendarDay.Date);
                }
            }
        }

        private void calendarGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                return;
            }

            e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            e.Paint(e.ClipBounds, (DataGridViewPaintParts.All & ~DataGridViewPaintParts.Background));
            e.Handled = true;
        }

        private void createCalendarMenuItem_Click(object sender, EventArgs e)
        {
            CreateCalendarForm createCalendarDialog = new CreateCalendarForm();

            if (createCalendarDialog.ShowDialog(this) == DialogResult.OK)
            {
                Agenda.Instance.AggiungiCalendario(createCalendarDialog.GetCalendario());
            }

            createCalendarDialog.Dispose();
        }

        private void creaModelloEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEventModelForm createEventModelDialog = new CreateEventModelForm();

            if (createEventModelDialog.ShowDialog(this) == DialogResult.OK)
            {
                Agenda.Instance.AggiungiModelloEvento(createEventModelDialog.GetModelloEvento());
            }

            createEventModelDialog.Dispose();
        }

        private void calendarTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (calendarTreeView.Nodes.Contains(calendarTreeView.SelectedNode))
            {
                calendarTreeView.SelectedNode = null;
            }
        }

    }
}
