using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.View.DataGridView
{
    public class CalendarDataGridView : System.Windows.Forms.DataGridView
    {
        protected override void OnResize(EventArgs e)
        {
            this.RowTemplate.Height = (this.Height - this.ColumnHeadersHeight) / 6;
            foreach (DataGridViewRow row in this.Rows)
            {
                row.Height = this.RowTemplate.Height;
            }

            base.OnResize(e);
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
                e.Paint(e.ClipBounds, (DataGridViewPaintParts.All & ~DataGridViewPaintParts.Background));
                e.Handled = true;
            }

            base.OnCellPainting(e);
        }
    }
}
