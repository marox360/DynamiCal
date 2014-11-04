using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.View
{
    public class TimePeriodPickerControl : Control
    {
        private DateTimePicker _startDateTimePicker;
        private DateTimePicker _endDateTimePicker;
        private ComboBox _dateComboBox;

        public TimePeriodPickerControl(DateTimePicker startDateTimePicker, DateTimePicker endDateTimePicker, ComboBox dateComboBox) : base()
        {
            _startDateTimePicker = startDateTimePicker;
            _endDateTimePicker = endDateTimePicker;
            _dateComboBox = dateComboBox;

            _dateComboBox.SelectedIndexChanged += dateComboBox_SelectedIndexChanged;
            _startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
        }

        public DateTimePicker StartDateTimePicker
        {
            get
            {
                return _startDateTimePicker;
            }
        }

        public DateTimePicker EndDateTimePicker
        {
            get
            {
                return _endDateTimePicker;
            }
        }

        public ComboBox DateComboBox
        {
            get
            {
                return _dateComboBox;
            }
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.DateComboBox.SelectedIndex)
            {
                case 0:
                    this.StartDateTimePicker.Enabled = false;
                    this.EndDateTimePicker.Enabled = false;
                    break;

                case 1:
                    this.StartDateTimePicker.Enabled = true;
                    this.EndDateTimePicker.Enabled = false;
                    break;

                case 2:
                    this.EndDateTimePicker.MinDate = this.StartDateTimePicker.Value;
                    this.StartDateTimePicker.Enabled = true;
                    this.EndDateTimePicker.Enabled = true;
                    break;
            }
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!this.EndDateTimePicker.Enabled)
            {
                this.EndDateTimePicker.MinDate = this.StartDateTimePicker.Value;
                this.EndDateTimePicker.Value = this.StartDateTimePicker.Value;
            }
            else if (this.EndDateTimePicker.Value < this.StartDateTimePicker.Value)
            {
                this.EndDateTimePicker.Value = this.StartDateTimePicker.Value.AddDays(1);
            }

            this.EndDateTimePicker.MinDate = this.StartDateTimePicker.Value;
        }
    }
}
