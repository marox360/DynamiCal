using DynamiCal.DataGridView.BindingSources;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            if ((value as CalendarDay).IsWeekendDay())
            {
                cellStyle.BackColor = Color.FromArgb(242, 242, 242);
            }
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, (value as CalendarDay).Description, errorText, cellStyle, advancedBorderStyle, paintParts);
        }
    }
}
