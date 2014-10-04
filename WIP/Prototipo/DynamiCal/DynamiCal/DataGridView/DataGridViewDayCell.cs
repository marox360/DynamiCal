using DynamiCal.DataGridView.BindingSources;
using DynamiCal.Extension;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.DataGridView
{
    public class DataGridViewDayCell : DataGridViewTextBoxCell
    {
        public DataGridViewDayCell() : base() { }

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            // Reset della cella perché andremo a rimpicciolire il cellBounds
            using (Brush brush = new SolidBrush(Color.White))
            {
                graphics.FillRectangle(brush, cellBounds);
            }

            CalendarDay dayValue = value as CalendarDay;
            if ((rowIndex == 0 && dayValue.Date.Day > 7) || (rowIndex >= 4 && dayValue.Date.Day < 15))
            {
                cellStyle.ForeColor = Color.Gray;
            }
            else if (dayValue.Date.IsSameDayOf(DateTime.Today))
            {
                cellStyle.ForeColor = Color.FromArgb(192, 85, 87);
                cellStyle.BackColor = Color.FromArgb(244, 203, 204);
            }

            int offsetX = 5;
            Rectangle borderCellBounds = new Rectangle(cellBounds.X + offsetX, cellBounds.Y, cellBounds.Width - offsetX, cellBounds.Height);

            base.Paint(graphics, clipBounds, !dayValue.Date.IsWeekendDay() || (dayValue.Date.DayOfWeek == DateTime.Today.DayOfWeek && dayValue.Date.DayOfWeek == DayOfWeek.Saturday) ? borderCellBounds : cellBounds, rowIndex, cellState, value, dayValue.Description, errorText, cellStyle, advancedBorderStyle, paintParts);

            if (dayValue.IsTodayWeek())
            {
                using (Pen pen = new Pen(dayValue.Date.IsSameDayOf(DateTime.Today) ? Color.FromArgb(192, 85, 87) : Color.FromArgb(244, 203, 204), 2))
                {
                    Rectangle bounds = dayValue.Date.DayOfWeek == DayOfWeek.Monday || dayValue.Date.IsSameDayOf(DateTime.Today) ? borderCellBounds : cellBounds;

                    int y = bounds.Top + (int)pen.Width/2;

                    if (dayValue.Date.DayOfWeek != DayOfWeek.Monday && dayValue.Date.IsSameDayOf(DateTime.Today))
                    {
                        using (Pen backPen = new Pen(Color.FromArgb(244, 203, 204), pen.Width))
                        {
                            graphics.DrawLine(backPen, new Point(cellBounds.Left, y), new Point(cellBounds.Left + cellBounds.Width, y));
                        }

                    }

                    graphics.DrawLine(pen, new Point(bounds.Left, y), new Point(bounds.Left + bounds.Width, y));
                }
            }
            else
            {
                using (Pen pen = new Pen(Color.FromArgb(214, 211, 211), 1))
                {
                    int x = borderCellBounds.Left;
                    int y = borderCellBounds.Top;
                    int width = borderCellBounds.Width - (int)pen.Width;

                    graphics.DrawLine(pen, new Point(x, y), new Point(x + width, y));
                }
            }

        }
    }
}
