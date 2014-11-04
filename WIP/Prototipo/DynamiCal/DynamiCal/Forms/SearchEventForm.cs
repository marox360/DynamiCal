using DynamiCal.Filters;
using DynamiCal.Model;
using DynamiCal.Time;
using DynamiCal.View.TreeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamiCal.Model.Calendars;
using DynamiCal.Presentation;
using DynamiCal.View;

namespace DynamiCal.Forms
{
    public partial class SearchEventForm : Form
    {
        private IFiltroPresenter _calendarTreeViewPresenter;
        private IFiltroPresenter _eventModelListBoxPresenter;
        private IFiltroPresenter _searchBoxPresenter;
        private IFiltroPresenter _timePeriodPickerPresenter;
        private IFiltraggio _filtraggio;

        internal Evento SelectedEvent
        {
            get
            {
                if (this.eventListBox.SelectedValue != null && this.eventListBox.SelectedValue is Evento)
                {
                    return this.eventListBox.SelectedValue as Evento;
                }
                else
                {
                    return null;
                }
            }
        }

        private IFiltro CurrentFilter
        {
            get
            {
                CriterioDiFiltraggio criterioFiltraggio = new CriterioDiFiltraggio(Agenda.Instance.Calendari);

                IFiltro filtroCalendari = _calendarTreeViewPresenter.Filter(criterioFiltraggio);
                IFiltro filtroModelli = _eventModelListBoxPresenter.Filter(filtroCalendari);
                IFiltro filtroTesto = _searchBoxPresenter.Filter(filtroModelli);
                IFiltro filtroData = _timePeriodPickerPresenter.Filter(filtroTesto);

                return filtroData;
            }
        }

        public SearchEventForm()
        {
            InitializeComponent();
        }

        private void SearchEventForm_Load(object sender, EventArgs e)
        {
            TimePeriodPickerControl timePeriodPicker = new TimePeriodPickerControl(this.startDateTimePicker, this.endDateTimePicker, this.dateComboBox);
            _timePeriodPickerPresenter = new TimePeriodPickerPresenter(timePeriodPicker);
            _timePeriodPickerPresenter.FilterChanged += UpdateFilter;

            _calendarTreeViewPresenter = new CalendarTreeViewPresenter(this.calendarTreeView);
            _calendarTreeViewPresenter.FilterChanged += UpdateFilter;

            _eventModelListBoxPresenter = new EventModelCheckedListBoxPresenter(this.eventModelListBox);
            _eventModelListBoxPresenter.FilterChanged += UpdateFilter;

            _searchBoxPresenter = new SearchBoxPanelPresenter(this.searchBoxPanel);
            _searchBoxPresenter.FilterChanged += UpdateFilter;

            _filtraggio = new Filtraggio(this.CurrentFilter);
            EventPickerControl eventPicker = new EventPickerControl(this.eventPanel, this.eventListBox);
            new EventPickerPresenter(eventPicker, _filtraggio);

            //this.UpdateFilter(this, EventArgs.Empty);
        }

        private void UpdateFilter(object sender, EventArgs e)
        {
            _filtraggio.Filtro = this.CurrentFilter;
        }

        private void showInCalendarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void eventListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.showInCalendarButton.Enabled = this.eventListBox.SelectedValue != null;
        }
    }
}
