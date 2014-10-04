using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal
{
    public partial class CreateEventForm : Form
    {
        public CreateEventForm()
        {
            InitializeComponent();
        }

        private void allDayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allDayCheckBox.Checked == true)
            {
                durationComboBox.Enabled = false;
                durationUpDown.Enabled = false;
            }
            OKButtonEnableCheck();
        }

        private void eventNameTextBox_TextChanged(object sender, EventArgs e)
        {
            OKButtonEnableCheck();
        }

        private void OKButtonEnableCheck()
        {
            if (eventNameTextBox.Text != ""
                && ((durationUpDown.Value != null && durationComboBox.SelectedValue != null) || allDayCheckBox.Checked == true))
                //&& controllo valori delle singole voci inseriti e corretti)
            {
                okButton.Enabled = true;
            }
            else okButton.Enabled = false;
        }

        private void durationUpDown_ValueChanged(object sender, EventArgs e)
        {
            OKButtonEnableCheck();
        }

        private void durationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKButtonEnableCheck();
        }

        private void calendarSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKButtonEnableCheck();
        }

        private void eventModelSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKButtonEnableCheck();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void addModelEventButton_Click(object sender, EventArgs e)
        {
            CreateEventModelForm CreateEventModelDialog = new CreateEventModelForm();
            if (CreateEventModelDialog.ShowDialog(this).Equals(DialogResult.OK))
            {
                eventModelSelectorComboBox.Refresh();
            }
        }
    }
}
