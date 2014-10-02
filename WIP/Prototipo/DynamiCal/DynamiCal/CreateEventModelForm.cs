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
    public partial class CreateEventModelForm : Form
    {
        public CreateEventModelForm()
        {
            InitializeComponent();

            foreach (TipoVoce tipo in TipoVoce.GetAllTypes()) {
                this.tipoVoceBindingSource.Add(tipo);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void entryNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.addEntryButton.Enabled = !String.IsNullOrWhiteSpace((sender as TextBox).Text);
        }

        private void modelNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.createButton.Enabled = !String.IsNullOrWhiteSpace((sender as TextBox).Text);
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            this.voceBindingSource.Add(new Voce(this.entryNameTextBox.Text, (TipoVoce)this.entryTypeComboBox.SelectedValue));

            this.entryNameTextBox.Text = "";
        }

    }
}
