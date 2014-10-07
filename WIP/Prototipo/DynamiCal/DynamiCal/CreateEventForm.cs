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

            validateForm();
        }

        private void validateForm(object sender, EventArgs e)
        {
            validateForm();
        }

        private void validateForm()
        {
            createButton.Enabled = !String.IsNullOrWhiteSpace(eventNameTextBox.Text) && (durationComboBox.SelectedValue != null || allDayCheckBox.Checked == true);
        }

        private void eventModelSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventModelSelectorComboBox.SelectedItem.ToString().Equals("Nuovo Modello..."))
            {
                this.Visible = false;

                CreateEventModelForm createEventModelDialog = new CreateEventModelForm();
                if (createEventModelDialog.ShowDialog(this).Equals(DialogResult.OK))
                {
                    Agenda.Instance.AggiungiModelloEvento(createEventModelDialog.GetModelloEvento());
                    populateEventModelSelectorComboBox();
                }
                createEventModelDialog.Dispose();

                this.Visible = true;
            }
            else
            {
                entriesDataGridView.Enabled = true;
                //entriesDataGridView.Columns.Add(Model.Agenda.Instance.ModelliEvento.Last().Voci);
                //entriesDataGridView.Columns.Add(Model.Agenda.Instance.ModelliEvento.Where(modello => modello.Voci).First());
            }

            validateForm();
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
            periodicityRadioButtonsPanel.Enabled = periodicityCheckBox.Checked;
        }
    }
}
