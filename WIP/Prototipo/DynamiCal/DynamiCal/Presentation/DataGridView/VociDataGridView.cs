using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation.DataGridView
{
    class VociDataGridView : System.Windows.Forms.DataGridView
    {
        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);

            if (this.DataSource is IList<IVoce>)
            {
                IList<IVoce> vociDataSource = this.DataSource as IList<IVoce>;
                for (int i = 0; i < vociDataSource.Count; i++)
                {
                    IVoce voce = vociDataSource[i];

                    if (voce is Voce<bool>)
                    {
                        this[1, i] = new DataGridViewCheckBoxCell();
                    }
                    else if (voce is Voce<DateTime>)
                    {
                        this[1, i] = new DataGridViewCalendarCell();
                    }
                    else
                    {
                        this[1, i] = new DataGridViewTextBoxCell();
                    }
                }

                this.Refresh();
            }
        }
    }
}
