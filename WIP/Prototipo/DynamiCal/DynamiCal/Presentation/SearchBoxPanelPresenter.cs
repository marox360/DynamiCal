using DynamiCal.Filters;
using DynamiCal.View.TextBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Presentation
{
    public class SearchBoxPanelPresenter : FiltroPresenter<SearchBoxPanel>
    {
        public SearchBoxPanelPresenter(SearchBoxPanel searchBoxPanel) : base(searchBoxPanel)
        {
            searchBoxPanel.SearchTextChanged += SearchBox_SearchTextChanged;
        }

        public override IFiltro Filter(IFiltro filtro)
        {
            return FiltroFactory.FiltraPerTesto(filtro, this.Control.SearchText);
        }

        private void SearchBox_SearchTextChanged(object sender, EventArgs e)
        {
            this.OnFilterChanged();
        }
    }
}
