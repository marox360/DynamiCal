using DynamiCal.Presentation.DataGridView.BindingSources;
using DynamiCal.Model;
using DynamiCal.Time;
using DynamiCal.Presentation.TreeView;
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

namespace DynamiCal.Forms
{
    public partial class MainForm : Form
    {
        private DateTime _lastDate = DateTime.Today;

        public MainForm()
        {
            InitializeComponent();

            Agenda.Instance.AggiungiModelloEvento(new ModelloEvento("Base"));

            Agenda.Instance.CalendarsChanged += CalendarsChanged;

            Calendario testCalendar = new CalendarioLocale("Test Calendar");
            testCalendar.AggiungiEvento(new Evento("Test", new PeriodoTempo(DateTime.Now, TimeSpan.FromMinutes(60)), Agenda.Instance.ModelliEvento[0], null, "Questo è un evento generato automaticamente nella giornata di oggi", "Ovunque :D"));
            Agenda.Instance.AggiungiCalendario(testCalendar);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.eventsListBox.EventPanel = this.eventPanel;
            this.calendarGridView.RowTemplate.Height = (this.calendarGridView.Height - this.calendarGridView.ColumnHeadersHeight) / 6;
            this.ShowMonthOfDay(DateTime.Today);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Agenda.Instance.CalendarsChanged -= CalendarsChanged;
        }

        private IFiltro CurrentFilter
        {
            get
            {
                CriterioDiFiltraggio criterioFiltraggio = new CriterioDiFiltraggio(Agenda.Instance.Calendari);

                IFiltro filtroCalendari = FiltroFactory.FiltraPerCalendari(criterioFiltraggio, this.calendarTreeView.CheckedCalendars);

                return FiltroFactory.FiltraPerPeriodo(filtroCalendari,
                    new DateTime(_lastDate.Year, _lastDate.Month, 1).AddDays(-14),
                    new DateTime(_lastDate.Year, _lastDate.Month + 1 > 12 ? 1 : _lastDate.Month + 1, 14).EndOfTheDay());
            }
        }

        private void RefreshCurrentMonth()
        {
            this.ShowMonthOfDay(_lastDate);
        }

        private void ShowMonthOfDay(DateTime date)
        {
            _lastDate = date;
            this.monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month);
            this.yearLabel.Text = date.Year.ToString();

            MonthlySource.FillSource(this.weekBindingSource, date, this.CurrentFilter);
            this.SelectDay(date);
        }

        private void SelectDay(DateTime date)
        {
            this.calendarGridView.CurrentCell = this.calendarGridView.Rows.Cast<DataGridViewRow>()
                .SelectMany(row => row.Cells.Cast<DataGridViewCell>())
                .FirstOrDefault(cell => cell.Value is CalendarDay && (cell.Value as CalendarDay).Date.IsSameDayOf(date));
        }

        private void CalendarsChanged(object sender, AgendaCollectionEventArgs e)
        {
            TreeNode treeNode = null;
            if (e.Item is CalendarioLocale)
            {
                treeNode = this.calendarTreeView.LocalCalendarsNode;
            }
            else if (e.Item is CalendarioCondiviso)
            {
                treeNode = this.calendarTreeView.SharedCalendarsNode;
            }

            if (treeNode == null)
            {
                return;
            }

            switch (e.Action)
            {
                case AgendaCollectionEventArgs.EditAction.AddItem:
                    treeNode.Nodes.Add(new CalendarTreeNode(e.Item as Calendario));
                    treeNode.Expand();
                    break;

                case AgendaCollectionEventArgs.EditAction.RemoveItem:
                    treeNode.Nodes.RemoveByKey((e.Item as Calendario).Nome);
                    break;
            }

            this.calendarTreeView.Sort();
            this.RefreshCurrentMonth();
        }

        #region DatePicker
        private void datePicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.ShowMonthOfDay(e.Start);
        }
        #endregion

        #region CalendarGridView
        private void calendarGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Il click su una delle celle dell'header causa RowIndex == -1
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewCell selectedCell = this.calendarGridView[e.ColumnIndex, e.RowIndex];
            if (selectedCell.Value is CalendarDay)
            {
                CalendarDay calendarDay = selectedCell.Value as CalendarDay;
                if (e.RowIndex == 0 && calendarDay.Date.Day > 7)
                {
                    this.ShowMonthOfDay(calendarDay.Date);
                }
                else if (e.RowIndex >= 4 && calendarDay.Date.Day < 15)
                {
                    this.ShowMonthOfDay(calendarDay.Date);
                }
                else
                {
                    _lastDate = calendarDay.Date;
                }
            }
        }

        private void calendarGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = this.calendarGridView.CurrentCell;
            if (currentCell != null && currentCell.Value != null && currentCell.Value is CalendarDay)
            {
                CalendarDay calendarDay = currentCell.Value as CalendarDay;
                this.topRightPanel.Visible = calendarDay.NumberOfEvents > 0;
                this.eventPanel.Visible = this.topRightPanel.Visible;

                if (calendarDay.NumberOfEvents > 0)
                {
                    this.eventPanel.OverrideDate = calendarDay.Date;
                    this.eventsListBox.EventFilter = FiltroFactory.FiltraPerTesto(FiltroFactory.FiltraPerData(this.CurrentFilter, calendarDay.Date), this.searchBoxPanel.SearchText);
                }
                else
                {
                    this.eventsListBox.EventoBindingSource.Clear();
                }
            }
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
                createEventDialog.eventDateTimePicker.Value = _lastDate.Date + (DateTime.Now - DateTime.Today);

                if (createEventDialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.RefreshCurrentMonth();
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
                        this.ShowMonthOfDay(evento.Periodo.DataInizio);
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

        private void calendarTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            this.RefreshCurrentMonth();
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
                        this.RefreshCurrentMonth();
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

                        this.RefreshCurrentMonth();
                    }
                    break;
                
                default: break;
            }
        }
        #endregion

        #region SearchBox
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.eventsListBox.EventFilter = FiltroFactory.FiltraPerTesto((this.eventsListBox.EventFilter as Filtro).Component, this.searchBoxPanel.SearchText);
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