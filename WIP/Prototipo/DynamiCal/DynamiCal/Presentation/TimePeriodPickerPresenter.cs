using DynamiCal.Filters;
using DynamiCal.View;
using DynamiCal.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Presentation
{
    public class TimePeriodPickerPresenter : FiltroPresenter<TimePeriodPickerControl>
    {
        public TimePeriodPickerPresenter(TimePeriodPickerControl timePeriodPickerControl) : base(timePeriodPickerControl)
        {
            this.Control.StartDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            this.Control.EndDateTimePicker.ValueChanged += endDateTimePicker_ValueChanged;
        }
        protected override void InitializeControl()
        {
            base.InitializeControl();

            this.Control.DateComboBox.SelectedIndex = 0;
        }

        public override IFiltro Filter(IFiltro filtro)
        {
            switch (this.Control.DateComboBox.SelectedIndex)
            {
                case 1:
                    return FiltroFactory.FiltraPerData(filtro, this.Control.StartDateTimePicker.Value);

                case 2:
                    return FiltroFactory.FiltraPerPeriodo(filtro, this.Control.StartDateTimePicker.Value, this.Control.EndDateTimePicker.Value.EndOfTheDay());

                default:
                    return filtro;
            }
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.OnFilterChanged();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.Control.EndDateTimePicker.Enabled)
            {
                this.OnFilterChanged();
            }
        }
    }
}
