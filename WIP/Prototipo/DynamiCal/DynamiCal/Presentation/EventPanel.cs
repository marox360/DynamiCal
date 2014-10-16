using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation
{
    public partial class EventPanel : UserControl
    {
        public EventPanel()
        {
            InitializeComponent();
        }

        private void entriesdataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                return;
            }

            e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            e.Paint(e.ClipBounds, (DataGridViewPaintParts.All & ~DataGridViewPaintParts.Background));
            e.Handled = true;
        }
    }
}
