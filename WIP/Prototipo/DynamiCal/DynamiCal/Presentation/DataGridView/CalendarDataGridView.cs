using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation.DataGridView
{
    class CalendarDataGridView : System.Windows.Forms.DataGridView
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            this.RowTemplate.Height = (this.Height - this.ColumnHeadersHeight) / 6;
            foreach (DataGridViewRow row in this.Rows)
            {
                row.Height = this.RowTemplate.Height;
            }
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            base.OnCellPainting(e);

            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
                e.Paint(e.ClipBounds, (DataGridViewPaintParts.All & ~DataGridViewPaintParts.Background));
                e.Handled = true;
            }
        }
    }
}
