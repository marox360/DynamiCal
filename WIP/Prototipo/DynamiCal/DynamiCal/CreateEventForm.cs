using DynamiCal.Common;
using DynamiCal.DataGridView;
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

        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            this.durationComboBox.SelectedIndex = 0;

            foreach (Periodicita.Frequenza frequenza in Enum.GetValues(typeof(Periodicita.Frequenza)).Cast<Periodicita.Frequenza>())
            {
                if (frequenza != Periodicita.Frequenza.Mai)
                {
                    this.frequenzaBindingSource.Add(new BindingContainer<Periodicita.Frequenza>(frequenza.ToString(), frequenza));
                }
            }

            this.eventModelSelectorComboBox.BeginUpdate();
            this.modelloEventoContainerBindingSource.Add(new BindingContainer<ModelloEvento>("Nuovo Modello...", null));
            foreach (ModelloEvento modello in Agenda.Instance.ModelliEvento)
            {
                BindingContainer<ModelloEvento> eventModelContainer = new BindingContainer<ModelloEvento>(modello.Nome, modello);
                this.modelloEventoContainerBindingSource.Add(eventModelContainer);

                if (modello.Voci.Count == 0)
                {
                    this.eventModelSelectorComboBox.SelectedItem = eventModelContainer;
                }
            }
            this.eventModelSelectorComboBox.EndUpdate();

            this.calendarSelectorComboBox.BeginUpdate();
            foreach (Calendario calendario in Agenda.Instance.Calendari)
            {
                this.calendarioBindingSource.Add(calendario);

                if (this.calendarSelectorComboBox.SelectedItem == null)
                {
                    this.calendarSelectorComboBox.SelectedItem = calendario;
                }
            }
            this.calendarSelectorComboBox.EndUpdate();

            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>("Mai", Periodicita.Mai));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>("Ogni giorno", Periodicita.Giornaliera));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>("Ogni settimana", Periodicita.Settimanale));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>("Ogni 2 settimane", Periodicita.Settimanale * 2));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>("Ogni mese", Periodicita.Mensile));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>("Ogni anno", Periodicita.Annuale));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>("Personalizzata", Periodicita.Mai));
            this.calendarSelectorComboBox.SelectedItem = this.periodicitaBindingSource[0];

            Agenda.Instance.EventModelsChanged += EventModelsChanged;
            Agenda.Instance.CalendarsChanged += CalendarsChanged;
        }
        
        private void CreateEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Agenda.Instance.EventModelsChanged -= EventModelsChanged;
            Agenda.Instance.CalendarsChanged -= CalendarsChanged;
        }

        private void EventModelsChanged(object sender, AgendaCollectionEventArgs e)
        {
            ModelloEvento eventModel = e.Item as ModelloEvento;
            BindingContainer<ModelloEvento> eventModelContainer = new BindingContainer<ModelloEvento>(eventModel.Nome, eventModel);

            switch (e.Action)
            {
                case AgendaCollectionEventArgs.EditAction.AddItem:
                    this.modelloEventoContainerBindingSource.Add(eventModelContainer);
                    this.eventModelSelectorComboBox.SelectedItem = eventModelContainer;
                    break;

                case AgendaCollectionEventArgs.EditAction.RemoveItem:
                    this.modelloEventoContainerBindingSource.Remove(eventModelContainer);
                    break;
            }
        }

        private void CalendarsChanged(object sender, AgendaCollectionEventArgs e)
        {
            switch (e.Action)
            {
                case AgendaCollectionEventArgs.EditAction.AddItem:
                    this.calendarioBindingSource.Add(e.Item);
                    break;

                case AgendaCollectionEventArgs.EditAction.RemoveItem:
                    this.calendarioBindingSource.Remove(e.Item);
                    break;
            }
        }

        private void allDayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.durationComboBox.Enabled = !this.allDayCheckBox.Checked;
            this.durationUpDown.Enabled = this.durationComboBox.Enabled;
        }

        private void validateForm(object sender, EventArgs e)
        {
            this.createButton.Enabled = !String.IsNullOrWhiteSpace(this.eventNameTextBox.Text) && this.calendarSelectorComboBox.SelectedValue != null && this.eventModelSelectorComboBox.SelectedValue != null;
        }

        private void eventModelSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.eventModelSelectorComboBox.SelectedItem != null)
            {
                ModelloEvento modelloEvento = (this.eventModelSelectorComboBox.SelectedItem as BindingContainer<ModelloEvento>).Value;
                if (modelloEvento == null)
                {
                    this.Visible = false;

                    CreateEventModelForm createEventModelDialog = new CreateEventModelForm();
                    createEventModelDialog.ShowDialog(this);
                    createEventModelDialog.Dispose();

                    this.Visible = true;
                }
                else
                {
                    List<IVoce> voceDataSource = new List<IVoce>();
                    foreach (Voce voce in modelloEvento.Voci)
                    {
                        voceDataSource.Add(VoceFactory.GetImplementedVoce(voce));
                    }
                    this.entriesDataGridView.DataSource = voceDataSource;

                    for (int i = 0; i < voceDataSource.Count; i++)
                    {
                        IVoce voce = voceDataSource[i];

                        if (voce is Voce<bool>)
                        {
                            this.entriesDataGridView[1, i] = new DataGridViewCheckBoxCell();
                        }
                        else if (voce is Voce<DateTime>)
                        {
                            this.entriesDataGridView[1, i] = new DataGridViewCalendarCell();
                        }
                        else
                        {
                            this.entriesDataGridView[1, i] = new DataGridViewTextBoxCell();
                        }
                    }

                    this.entriesDataGridView.Refresh();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            (this.calendarSelectorComboBox.SelectedValue as Calendario).AggiungiEvento(this.GetEvento());

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void entriesDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 && (this.entriesDataGridView.DataSource as IList<IVoce>)[e.RowIndex] is Voce<double>)
            {
                Voce<double> voce = (this.entriesDataGridView.DataSource as IList<IVoce>)[e.RowIndex] as Voce<double>;
                try
                {
                    voce.Valore = Double.Parse(e.FormattedValue as string);
                }
                catch{ }
            }
        }

        private void durationUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.durationUpDown.Text))
            {
                this.durationUpDown.Text = this.durationUpDown.Value.ToString();
            }
        }

        private void frequencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.frequencyTypeComboBox.Enabled = this.frequencyComboBox.SelectedIndex >= 0 && (this.periodicitaBindingSource[this.frequencyComboBox.SelectedIndex] as IBindingContainer).DisplayText.Equals("Personalizzata");
            this.frequencyNumericUpDown.Enabled = this.frequencyTypeComboBox.Enabled;
        }

        private void SetCustomFrequency(object sender, EventArgs e)
        {
            BindingContainer<Periodicita> custom = this.frequencyComboBox.SelectedItem as BindingContainer<Periodicita>;
            if (custom != null)
            {
                custom.Value = new Periodicita((Periodicita.Frequenza)this.frequencyTypeComboBox.SelectedValue, (int)this.frequencyNumericUpDown.Value);
            }
        }

        private Evento GetEvento()
        {
            int duration = this.allDayCheckBox.Checked ? 0 : (int)this.durationUpDown.Value;
            switch (this.durationComboBox.SelectedValue as string)
            {
                case "Ore":
                    duration *= 60;
                    break;

                case "Giorni":
                    duration *= 60 * 24;
                    break;

                default:
                    break;
            }

            return new Evento(
                this.eventNameTextBox.Text,
                this.eventDateTimePicker.Value,
                duration,
                this.eventModelSelectorComboBox.SelectedValue as ModelloEvento,
                this.entriesDataGridView.DataSource as IEnumerable<IVoce>,
                this.eventDescriptionTextBox.Text,
                this.eventLocationTextBox.Text,
                (Periodicita)this.frequencyComboBox.SelectedValue);
        }
    }
}
