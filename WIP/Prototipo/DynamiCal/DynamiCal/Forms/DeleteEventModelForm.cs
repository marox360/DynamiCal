using DynamiCal.Model;
using DynamiCal.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Forms
{
    public partial class DeleteEventModelForm : Form
    {
        private CriterioDiFiltraggio _criterioFiltraggio;

        public DeleteEventModelForm()
        {
            InitializeComponent();
        }

        private void DeleteEventModel_Load(object sender, EventArgs e)
        {
            _criterioFiltraggio = new CriterioDiFiltraggio(Agenda.Instance.Calendari);

            this.eventModelListBox.BeginUpdate();
            foreach (ModelloEvento modelloEvento in Agenda.Instance.ModelliEvento)
            {
                this.modelloEventoBindingSource.Add(modelloEvento);
            }
            this.eventModelListBox.SelectedItem = this.modelloEventoBindingSource.Cast<ModelloEvento>().FirstOrDefault();
            this.eventModelListBox.EndUpdate();

            Agenda.Instance.EventModelsChanged += EventModelsChanged;
        }

        private void DeleteEventModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Agenda.Instance.EventModelsChanged -= EventModelsChanged;
        }

        private void EventModelsChanged(object sender, AgendaCollectionEventArgs e)
        {
            switch (e.Action)
            {
                case AgendaCollectionEventArgs.EditAction.AddItem:
                    this.modelloEventoBindingSource.Add(e.Item);
                    this.eventModelListBox.SelectedItem = e.Item;
                    break;

                case AgendaCollectionEventArgs.EditAction.RemoveItem:
                    this.modelloEventoBindingSource.Remove(e.Item);
                    break;
            }
        }

        private void eventModelListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.voceBindingSource.Clear();

            if (this.eventModelListBox.SelectedValue != null)
            {
                ModelloEvento modelloEvento = this.eventModelListBox.SelectedValue as ModelloEvento;
                foreach (Voce voce in modelloEvento.Voci)
                {
                    this.voceBindingSource.Add(voce);
                }

                int countEvents = FiltroFactory.FiltraPerModello(_criterioFiltraggio, modelloEvento).FiltraEventi().Count();
                this.countEventLabel.Text = countEvents.ToString();
                this.deleteButton.Enabled = countEvents == 0;
                this.eventLabel.Visible = true;
                this.countEventLabel.Visible = true;
            }
            else
            {
                this.eventLabel.Visible = false;
                this.countEventLabel.Visible = false;
                this.deleteButton.Enabled = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Agenda.Instance.RimuoviModelloEvento(this.eventModelListBox.SelectedValue as ModelloEvento);
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            using (CreateEventModelForm createEventModelDialog = new CreateEventModelForm())
            {
                createEventModelDialog.ShowDialog(this);
            }

            this.Visible = true;
        }
    }
}
