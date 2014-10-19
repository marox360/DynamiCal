using DynamiCal.Presentation;
using DynamiCal.Presentation.DataGridView;
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
using DynamiCal.Time;

namespace DynamiCal.Forms
{
    public partial class CreateEventForm : Form
    {
        public CreateEventForm()
        {
            InitializeComponent();
        }

        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            this.durationComboBox.SelectedIndex = 1;

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

            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Mai));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Giornaliera));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Settimanale));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Settimanale * 2));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Mensile));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Annuale));
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

            if (this.allDayCheckBox.Checked)
            {
                this.durationUpDown.Value = 1;
                this.durationUpDown.Text = this.durationUpDown.Value.ToString();
                this.durationComboBox.SelectedItem = "Giorni";
                this.eventDateTimePicker.Value = this.eventDateTimePicker.Value.Date;
                this.eventDateTimePicker.CustomFormat = "dddd, dd MMMM yyyy";
            }
            else
            {
                this.eventDateTimePicker.CustomFormat = "dddd, dd MMMM yyyy alle HH:mm";
            }
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
            TimeSpan duration = TimeSpan.Zero;
            switch (this.durationComboBox.SelectedItem as string)
            {
                case "Minuti":
                    duration = TimeSpan.FromMinutes((double)this.durationUpDown.Value);
                    break;

                case "Ore":
                    duration = TimeSpan.FromHours((double)this.durationUpDown.Value);
                    break;

                case "Giorni":
                    duration = TimeSpan.FromDays((double)this.durationUpDown.Value);
                    break;

                default:
                    break;
            }

            return new Evento(
                this.eventNameTextBox.Text,
                new TimePeriod(this.eventDateTimePicker.Value, duration),
                this.eventModelSelectorComboBox.SelectedValue as ModelloEvento,
                this.entriesDataGridView.DataSource as IEnumerable<IVoce>,
                this.eventDescriptionTextBox.Text,
                this.eventLocationTextBox.Text,
                (Periodicita)this.frequencyComboBox.SelectedValue);
        }
    }
}
