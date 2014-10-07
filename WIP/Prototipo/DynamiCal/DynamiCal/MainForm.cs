using DynamiCal.DataGridView.BindingSources;
using DynamiCal.Model;
using DynamiCal.Extension;
using DynamiCal.TreeView;
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

namespace DynamiCal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Agenda.Instance.CalendarsChanged += CalendarsChanged;
            Agenda.Instance.AggiungiCalendario(new CalendarioLocale("Test Calendar"));

            Agenda.Instance.AggiungiModelloEvento(new ModelloEvento("Base"));
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

        private void CalendarsChanged(object sender, AgendaCollectionEventArgs e)
        {
            TreeNode treeNode = null;
            if (e.Item is CalendarioLocale)
            {
                treeNode = calendarTreeView.Nodes["LocalCalendars"];
            }
            else if (e.Item is CalendarioLocale)
            {
                treeNode = calendarTreeView.Nodes["SharedCalendars"];
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
                (e.Node as CalendarTreeNode).DrawNode(e.Graphics, calendarTreeView.Font, 14, 6);
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

                TextRenderer.DrawText(e.Graphics, e.Node.Text, new Font(calendarTreeView.Font, FontStyle.Bold), bounds, e.Node.ForeColor, e.Node.BackColor);
            }
        }

        private void calendarTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is CalendarTreeNode && e.Button == MouseButtons.Right)
            {
                calendarTreeView.SelectedNode = e.Node;
                treeNodeMenuStrip.Show(calendarTreeView, e.Location);
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
            if (treeNodeMenuStrip.SourceControl is System.Windows.Forms.TreeView)
            {
                CalendarTreeNode calendarNode = (treeNodeMenuStrip.SourceControl as System.Windows.Forms.TreeView).SelectedNode as CalendarTreeNode;
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

    }
}
