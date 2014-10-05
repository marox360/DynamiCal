using DynamiCal.Model;
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
            else
            {
                durationComboBox.Enabled = true;
                durationUpDown.Enabled = true;
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
                && (durationComboBox.SelectedValue != null || allDayCheckBox.Checked == true))
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
            if (eventModelSelectorComboBox.SelectedItem.ToString().Equals("Nuovo Modello..."))
            {
                CreateEventModelForm createEventModelDialog = new CreateEventModelForm();
                this.Visible = false;
                if (createEventModelDialog.ShowDialog(this).Equals(DialogResult.OK))
                {
                    Agenda.Instance.AggiungiModelloEvento(createEventModelDialog.GetModelloEvento());
                    populateEventModelSelectorComboBox();
                }
                this.Visible = true;
            }
            else
            {
                entriesDataGridView.Enabled = true;
                //entriesDataGridView.Columns.Add(Model.Agenda.Instance.ModelliEvento.Last().Voci);
                //entriesDataGridView.Columns.Add(Model.Agenda.Instance.ModelliEvento.Where(modello => modello.Voci).First());
            }
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

        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            eventModelSelectorComboBox.Items.Add("Nuovo Modello...");
            populateEventModelSelectorComboBox();
        }

        private void populateEventModelSelectorComboBox()
        {
            foreach (ModelloEvento _modello in Agenda.Instance.ModelliEvento)
            {
                if (!eventModelSelectorComboBox.Items.Contains(_modello.Nome))
                {
                    eventModelSelectorComboBox.Items.Add(_modello.Nome);
                }
            }
        }

        private void periodicityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (periodicityCheckBox.Checked == true)
            {
                periodicityRadioButtonsPanel.Enabled = true;
            }
            else periodicityRadioButtonsPanel.Enabled = false;
        }
    }
}
