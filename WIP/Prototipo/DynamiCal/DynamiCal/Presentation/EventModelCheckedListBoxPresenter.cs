using DynamiCal.Filters;
using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation
{
    public class EventModelCheckedListBoxPresenter : FiltroPresenter<CheckedListBox>
    {
        public EventModelCheckedListBoxPresenter(CheckedListBox checkedListBox) : base(checkedListBox)
        {
            checkedListBox.ItemCheck += CheckedListBox_ItemCheck;
        }

        protected override void InitializeControl()
        {
            base.InitializeControl();

            this.Control.BeginUpdate();
            foreach (ModelloEvento modelloEvento in Agenda.Instance.ModelliEvento)
            {
                this.Control.Items.Add(modelloEvento);
                this.Control.SetItemChecked(this.Control.Items.IndexOf(modelloEvento), true);
            }
            this.Control.EndUpdate();
        }

        public override IFiltro Filter(IFiltro filtro)
        {
            return FiltroFactory.FiltraPerModelli(filtro, this.Control.CheckedItems.Cast<ModelloEvento>());
        }

        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.Control.BeginInvoke((MethodInvoker)(() => this.OnFilterChanged()));
        }
    }
}
