using DynamiCal.Model;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation.DataGridView
{
    class DataGridViewEntryTypeCell : DataGridViewTextBoxCell
    {
        public DataGridViewEntryTypeCell() : base() { }

        public override Type ValueType
        {
            get
            {
                return typeof(Voce.Tipo);
            }
        }

        public override System.Type FormattedValueType
        {
            get
            {
                return typeof(string);
            }
        }

        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, System.ComponentModel.TypeConverter valueTypeConverter, System.ComponentModel.TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            if (value is Voce.Tipo)
            {
                return ((Voce.Tipo)value).GetDescription();
            }

            return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
        }
    }
}
