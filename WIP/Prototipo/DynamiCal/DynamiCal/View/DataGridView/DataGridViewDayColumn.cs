using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.View.DataGridView
{
    public class DataGridViewDayColumn : DataGridViewColumn
    {
        public DataGridViewDayColumn() : base(new DataGridViewDayCell()) { }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewDayCell)))
                {
                    throw new InvalidCastException("Must be a DataGridViewDayCell");
                }

                base.CellTemplate = value;
            }
        }
    }
}
