using DynamiCal.Presentation.DataGridView.BindingSources;
using DynamiCal.Model;
using DynamiCal.Extension;
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

namespace DynamiCal
{
    public partial class MainForm : Form
    {
        private DateTime _lastDate = DateTime.Today;
        private IFiltro _eventFilter = null;

        public MainForm()
        {
            InitializeComponent();

            Agenda.Instance.AggiungiModelloEvento(new ModelloEvento("Base"));

            Agenda.Instance.CalendarsChanged += CalendarsChanged;

            Calendario testCalendar = new CalendarioLocale("Test Calendar");
            testCalendar.AggiungiEvento(new Evento("Test", DateTime.Today, 60, Agenda.Instance.ModelliEvento[0]));
            Agenda.Instance.AggiungiCalendario(testCalendar);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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

                return FiltroFactory.FiltraPerPeriodo(criterioFiltraggio,
                    new DateTime(_lastDate.Year, _lastDate.Month, 1).AddDays(-14),
                    new DateTime(_lastDate.Year, _lastDate.Month + 1 > 12 ? 1 : _lastDate.Month + 1, 14).EndOfTheDay());
            }
        }

        private IFiltro EventFilter
        {
            set
            {
                _eventFilter = value;

                if (_eventFilter != null)
                {
                    this.eventsListBox.BeginUpdate();
                    this.eventoBindingSource.Clear();
                    foreach (Evento evento in _eventFilter.FiltraEventi())
                    {
                        this.eventoBindingSource.Add(evento);
                    }
                    this.eventsListBox.EndUpdate();
                }
            }
            get
            {
                return _eventFilter;
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
            foreach (DataGridViewRow row in this.calendarGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is CalendarDay && (cell.Value as CalendarDay).Date.IsSameDayOf(date))
                    {
                        this.calendarGridView.CurrentCell = cell;
                        return;
                    }
                }
            }
        }

        private void CalendarsChanged(object sender, AgendaCollectionEventArgs e)
        {
            TreeNode treeNode = null;
            if (e.Item is CalendarioLocale)
            {
                treeNode = this.calendarTreeView.Nodes["LocalCalendars"];
            }
            else if (e.Item is CalendarioLocale)
            {
                treeNode = this.calendarTreeView.Nodes["SharedCalendars"];
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

        private void calendarGridView_Resize(object sender, EventArgs e)
        {
            this.calendarGridView.RowTemplate.Height = (this.calendarGridView.Height - this.calendarGridView.ColumnHeadersHeight) / 6;
            foreach (DataGridViewRow row in this.calendarGridView.Rows)
            {
                row.Height = this.calendarGridView.RowTemplate.Height;
            }
        }

        private void datePicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.ShowMonthOfDay(e.Start);
        }

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
                this.bottomRightPanel.Visible = this.topRightPanel.Visible;

                if (calendarDay.NumberOfEvents > 0)
                {
                    this.EventFilter = FiltroFactory.FiltraPerTesto(FiltroFactory.FiltraPerData(this.CurrentFilter, calendarDay.Date), this.searchBox.Text.Replace("Inserisci un testo da cercare", ""));
                }
                else
                {
                    this.eventoBindingSource.Clear();
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

            }

            createCalendarDialog.Dispose();
        }

        private void creaModelloEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEventModelForm createEventModelDialog = new CreateEventModelForm();
            createEventModelDialog.ShowDialog(this);
            createEventModelDialog.Dispose();
        }

        private void calendarTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = false;
            e.Node.BackColor = Color.White;
            e.Node.ForeColor = Color.Black;

            if (e.Node is CalendarTreeNode)
            {
                (e.Node as CalendarTreeNode).DrawNode(e.Graphics, this.calendarTreeView.Font, 14, 6);
            }
            else
            {
                Rectangle bounds = e.Node.Bounds;
                bounds.X = 20;
                bounds.Width += 10;

                using (SolidBrush brush = new SolidBrush(e.Node.BackColor))
                {
                    e.Graphics.FillRectangle(brush, bounds);
                }

                TextRenderer.DrawText(e.Graphics, e.Node.Text, new Font(this.calendarTreeView.Font, FontStyle.Bold), bounds, e.Node.ForeColor, e.Node.BackColor);
            }
        }

        private void calendarTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is CalendarTreeNode && e.Button == MouseButtons.Right)
            {
                this.calendarTreeView.SelectedNode = e.Node;
                this.treeNodeMenuStrip.Show(this.calendarTreeView, e.Location);
            }
        }

        private void calendarTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is CalendarTreeNode && e.Button == MouseButtons.Left)
            {
                e.Node.Checked = !e.Node.Checked;
            }
        }

        private void creaEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEventForm createEventDialog = new CreateEventForm();

            if (createEventDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.RefreshCurrentMonth();
            }

            createEventDialog.Dispose();
        }

        private void toolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;

            if (item.HasDropDownItems)
            {
                item.ShowDropDown();
            }
        }

        private void treeNodeMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Calendario calendar = null;
            if (this.treeNodeMenuStrip.SourceControl is System.Windows.Forms.TreeView)
            {
                CalendarTreeNode calendarNode = (this.treeNodeMenuStrip.SourceControl as System.Windows.Forms.TreeView).SelectedNode as CalendarTreeNode;
                if (calendarNode.Parent.Name == "LocalCalendars")
                {
                    calendar = new CalendarioLocale(calendarNode.Name);
                }
                else if (calendarNode.Parent.Name == "SharedCalendars")
                {
                    calendar = new CalendarioCondiviso(calendarNode.Name);
                }
            }

            if (calendar == null)
            {
                return;
            }
            
            switch (e.ClickedItem.Text)
            {
                case "Elimina":
                    Agenda.Instance.RimuoviCalendario(calendar);
                    break;
                
                default: break;
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (this.searchBox.Text == "Inserisci un testo da cercare")
            {
                this.searchBox.Text = "";
            }

            this.searchBox.ForeColor = Color.Black;
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (this.searchBox.Text == "")
            {
                this.searchBox.ForeColor = Color.DarkGray;
                this.searchBox.Text = "Inserisci un testo da cercare";
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.EventFilter = FiltroFactory.FiltraPerTesto((this.EventFilter as Filtro).Component, this.searchBox.Text.Replace("Inserisci un testo da cercare", ""));
        }

        private void searchBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.eventsListBox.Focus();
            }
        }

    }
}
