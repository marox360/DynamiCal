using DynamiCal.Presentation.DataGridView.BindingSources;
using DynamiCal.Extension;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation.DataGridView
{
    public class DataGridViewDayCell : DataGridViewTextBoxCell
    {
        private static readonly Color TodayColor = Color.FromArgb(192, 85, 87);
        private static readonly Color ThisWeekColor = Color.FromArgb(244, 203, 204);
        private static readonly Color WeekSeparatorColor = Color.FromArgb(214, 211, 211);
        private const int cellMargin = 3;

        public DataGridViewDayCell() : base() { }

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            // Reset della cella perché andremo a rimpicciolire il cellBounds
            using (Brush brush = new SolidBrush(cellStyle.BackColor))
            {
                graphics.FillRectangle(brush, cellBounds);
            }

            CalendarDay dayValue = value as CalendarDay;
            if ((rowIndex == 0 && dayValue.Date.Day > 7) || (rowIndex >= 4 && dayValue.Date.Day < 15))
            {
                cellStyle.ForeColor = Color.Gray;
            }

            cellStyle.SelectionBackColor = ThisWeekColor;
            cellStyle.SelectionForeColor = TodayColor;

            bool leftMargin = dayValue.Date.DayOfWeek != DayOfWeek.Monday;
            bool rightMargin = dayValue.Date.DayOfWeek != DayOfWeek.Sunday;

            Rectangle borderCellBounds = DataGridViewDayCell.CellBorderBounds(cellBounds, cellMargin, leftMargin, rightMargin);

            if (cellState.HasFlag(DataGridViewElementStates.Selected) || dayValue.Date.IsToday())
            {
                cellStyle.Font = new Font(cellStyle.Font, FontStyle.Bold);
            }

            base.Paint(graphics, clipBounds, borderCellBounds, rowIndex, cellState, value, dayValue.Description, errorText, cellStyle, advancedBorderStyle, paintParts);

            if (dayValue.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                using (Brush brush = new SolidBrush(Color.White))
                {
                    graphics.FillRectangle(brush, new Rectangle(cellBounds.X, cellBounds.Y, cellMargin, cellBounds.Height));
                }
            }

            if (dayValue.IsTodayWeek())
            {
                using (Pen pen = new Pen(ThisWeekColor, 2))
                {
                    int y = cellBounds.Top + (int)pen.Width / 2;

                    graphics.DrawLine(pen, cellBounds.Left, y, cellBounds.Left + cellBounds.Width, y);
                }

                if (dayValue.Date.IsToday())
                {
                    using (Pen pen = new Pen(TodayColor, 2))
                    {
                        int y = borderCellBounds.Top + (int)pen.Width / 2;

                        graphics.DrawLine(pen, borderCellBounds.Left, y, borderCellBounds.Left + borderCellBounds.Width, y);
                    }
                }
            }
            else
            {
                using (Pen pen = new Pen(WeekSeparatorColor, 1))
                {
                    int x = borderCellBounds.Left;
                    int y = borderCellBounds.Top;
                    int width = borderCellBounds.Width - (int)pen.Width;

                    graphics.DrawLine(pen, x, y, x + width, y);
                }
            }

            if (dayValue.NumberOfEvents > 0)
            {
                using (SolidBrush brush = new SolidBrush(cellState.HasFlag(DataGridViewElementStates.Selected) ? cellStyle.SelectionForeColor : cellStyle.ForeColor))
                {
                    int circleRadius = 7;
                    Rectangle circleBounds = new Rectangle(borderCellBounds.X + borderCellBounds.Width / 2 - circleRadius, borderCellBounds.Y + borderCellBounds.Height - circleRadius * 3, circleRadius * 2, circleRadius * 2);
                    SmoothingMode smoothingMode = graphics.SmoothingMode;
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.FillEllipse(brush, circleBounds);
                    graphics.SmoothingMode = smoothingMode;
                }
            }
        }

        private static Rectangle CellBorderBounds(Rectangle cellBounds, int cellMargin)
        {
            return CellBorderBounds(cellBounds, cellMargin, true, true);
        }

        private static Rectangle CellBorderBounds(Rectangle cellBounds, int cellMargin, bool left, bool right)
        {
            return new Rectangle(cellBounds.X + (left ? cellMargin : 0), cellBounds.Y, cellBounds.Width - cellMargin * ((left ? 1 : 0) + (right ? 1 : 0)), cellBounds.Height);
        }
    }
}