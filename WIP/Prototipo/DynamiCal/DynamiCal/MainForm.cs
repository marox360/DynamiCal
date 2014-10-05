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

            calendarTreeView.ExpandAll();

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

        private void CalendarsChanged(object sender, EventArgs e)
        {
            foreach (Calendario calendario in Agenda.Instance.Calendari)
            {
                CalendarTreeNode node = new CalendarTreeNode(calendario);
                node.Checked = true;

                if (calendario is CalendarioLocale)
                {
                    if (!calendarTreeView.Nodes["LocalCalendars"].Nodes.ContainsKey(calendario.Nome))
                    {
                        calendarTreeView.Nodes["LocalCalendars"].Nodes.Add(node);
                    }
                }
                else if (calendario is CalendarioCondiviso)
                {
                    if (!calendarTreeView.Nodes["SharedCalendars"].Nodes.ContainsKey(calendario.Nome))
                    {
                        calendarTreeView.Nodes["SharedCalendars"].Nodes.Add(node);
                    }
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
            calendarTreeView.SelectedNode = null;
        }

        private void calendarTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.Node.BackColor = Color.White;
            e.Node.ForeColor = Color.Black;

            if (e.Node is CalendarTreeNode)
            {
                CalendarTreeNode calendarNode = e.Node as CalendarTreeNode;

                Rectangle bounds = calendarNode.Bounds;
                bounds.X = 0;
                bounds.Width += 20;
                int textOffset = 14;

                using (SolidBrush brush = new SolidBrush(calendarNode.BackColor))
                {
                    e.Graphics.FillRectangle(brush, bounds);
                }

                using (SolidBrush brush = new SolidBrush(calendarNode.CalendarColor))
                {
                    int circleRadius = 6;
                    Rectangle circleBounds = new Rectangle(bounds.X + textOffset - circleRadius, bounds.Y + bounds.Height / 2 - circleRadius, circleRadius * 2, circleRadius * 2);
                    SmoothingMode smoothingMode = e.Graphics.SmoothingMode;
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(brush, circleBounds);
                    e.Graphics.SmoothingMode = smoothingMode;

                    if (calendarNode.Checked)
                    {
                        circleBounds.Offset(1, 0);
                        TextRenderer.DrawText(e.Graphics, "✔", new Font(calendarTreeView.Font.FontFamily, circleRadius), circleBounds, Color.White, Color.Transparent);
                    }
                }

                bounds.Offset(textOffset, 0);
                TextFormatFlags flags = TextFormatFlags.Default | TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(e.Graphics, calendarNode.Text, calendarTreeView.Font, bounds, calendarNode.ForeColor, calendarNode.BackColor, flags);

                e.DrawDefault = false;
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

                e.DrawDefault = false;
            }
        }

        private void calendarTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!calendarTreeView.Nodes.Contains(e.Node) && e.Button == MouseButtons.Left)
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
    }
}
