using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.DataGridView
{
    public class DataGridViewVoceCell : DataGridViewTextBoxCell
    {
        public DataGridViewVoceCell() : base() { }

        private object GetValore(object value)
        {
            if (value != null && value is IVoce)
            {
                return (value as IVoce).Valore;
            }

            return value;
        }

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            object valore = GetValore(value);
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, (valore == null ? valore : valore.ToString()), errorText, cellStyle, advancedBorderStyle, paintParts);
        }
    }
}
