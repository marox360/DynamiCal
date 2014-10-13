using DynamiCal.Presentation;
using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            foreach (Voce.Tipo tipo in Enum.GetValues(typeof(Voce.Tipo)).Cast<Voce.Tipo>())
            {
                this.tipoVoceContainerBindingSource.Add(new BindingContainer<Voce.Tipo>(tipo.GetDescription(), tipo));
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Agenda.Instance.AggiungiModelloEvento(this.GetModelloEvento());

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void entryNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.addEntryButton.Enabled = !String.IsNullOrWhiteSpace((sender as TextBox).Text);
        }

        private void modelNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.createButton.Enabled = !String.IsNullOrWhiteSpace((sender as TextBox).Text);
            if (this.createButton.Enabled)
            {
                ModelloEvento eventModel = new ModelloEvento((sender as TextBox).Text.Trim());
                this.createButton.Enabled = !Agenda.Instance.ModelliEvento.Contains(eventModel);
            }
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            this.voceBindingSource.Add(new Voce(this.entryNameTextBox.Text, (Voce.Tipo)this.entryTypeComboBox.SelectedValue));

            this.entryNameTextBox.Text = "";
        }

        private ModelloEvento GetModelloEvento()
        {
            IEnumerable<Voce> voci = this.voceBindingSource.Cast<Voce>();
            ModelloEvento modelloEvento = new ModelloEvento(this.modelNameTextBox.Text, voci);

            return modelloEvento;
        }
    }
}
