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
using DynamiCal.Model.Calendars;

namespace DynamiCal.Forms
{
    public partial class ManageEventForm : Form
    {
        private Evento _evento = null;

        public ManageEventForm()
        {
            InitializeComponent();
        }

        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            if (this.durationComboBox.SelectedItem == null)
            {
                this.durationComboBox.SelectedIndex = 1;
            }

            foreach (Periodicita.Frequenza frequenza in Enum.GetValues(typeof(Periodicita.Frequenza)).Cast<Periodicita.Frequenza>().Where(f => f != Periodicita.Frequenza.Mai))
            {
                 this.frequenzaBindingSource.Add(new BindingContainer<Periodicita.Frequenza>(frequenza));
            }

            this.eventModelSelectorComboBox.BeginUpdate();
            if (_evento != null)
            {
                BindingContainer<ModelloEvento> modelloContainer = new BindingContainer<ModelloEvento>(_evento.Modello.Nome, _evento.Modello);
                this.modelloEventoContainerBindingSource.Add(modelloContainer);
                this.eventModelSelectorComboBox.SelectedItem = modelloContainer;
            }
            else
            {
                this.modelloEventoContainerBindingSource.Add(new BindingContainer<ModelloEvento>("Nuovo Modello...", null));
                foreach (ModelloEvento modello in Agenda.Instance.ModelliEvento)
                {
                    BindingContainer<ModelloEvento> modelloContainer = new BindingContainer<ModelloEvento>(modello.Nome, modello);
                    this.modelloEventoContainerBindingSource.Add(modelloContainer);

                    if (!modelloContainer.Value.Voci.Any())
                    {
                        this.eventModelSelectorComboBox.SelectedItem = modelloContainer;
                    }
                }
            }
            this.eventModelSelectorComboBox.EndUpdate();

            this.calendarSelectorComboBox.BeginUpdate();
            if (_evento != null)
            {
                this.calendarioBindingSource.Add(new BindingContainer<Calendario>(Agenda.Instance.Calendari.First(c => c.Eventi.Contains(_evento))));
            }
            else
            {
                this.calendarioBindingSource.Add(new BindingContainer<Calendario>("Nuovo Calendario...", null));
                foreach (Calendario calendario in Agenda.Instance.Calendari)
                {
                    this.calendarioBindingSource.Add(new BindingContainer<Calendario>(calendario.Nome, calendario));
                }
            }
            this.calendarSelectorComboBox.SelectedItem = this.calendarioBindingSource.Cast<BindingContainer<Calendario>>().FirstOrDefault(b => b.Value != null);
            this.calendarSelectorComboBox.EndUpdate();

            Periodicita selectedPeriodicita = _evento != null ? _evento.Periodicita : Periodicita.Mai;
            Periodicita customPeriodicita = _evento != null && !_evento.Periodicita.Equals(Periodicita.Mai) ? _evento.Periodicita : Periodicita.Giornaliera;
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Mai));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Giornaliera));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Settimanale));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Settimanale * 2));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Mensile));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>(Periodicita.Annuale));
            this.periodicitaBindingSource.Add(new BindingContainer<Periodicita>("Personalizzata", customPeriodicita));
            this.frequencyComboBox.SelectedValue = selectedPeriodicita;
            this.frequencyNumericUpDown.Value = customPeriodicita.Valore;
            this.frequencyTypeComboBox.SelectedValue = customPeriodicita.Ripetizione;

            //CreateEventForm_Load viene chiamato dopo LoadEvento e settare il DataSource in LoadEvento non fa creare le celle editabili
            if (_evento != null)
            {
                this.entriesDataGridView.DataSource = _evento.Voci.Select(voce => voce.Copy()).ToList();
            }

            Agenda.Instance.EventModelsChanged += EventModelsChanged;
            Agenda.Instance.CalendarsChanged += CalendarsChanged;
        }
        
        private void CreateEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Agenda.Instance.EventModelsChanged -= EventModelsChanged;
            Agenda.Instance.CalendarsChanged -= CalendarsChanged;
        }

        internal void LoadEvento(Evento evento)
        {
            _evento = evento;

            this.eventModelSelectorComboBox.Enabled = false;
            this.calendarSelectorComboBox.Enabled = false;
            this.createButton.Text = "Modifica";

            this.eventNameTextBox.Text = evento.Nome;
            this.eventLocationTextBox.Text = evento.Luogo;
            this.eventDescriptionTextBox.Text = evento.Descrizione;
            this.eventDateTimePicker.Value = evento.Periodo.DataInizio;

            int minutes = (int)evento.Periodo.Durata.TotalMinutes;
            if (evento.Periodo.DataInizio == evento.Periodo.DataInizio.Date && minutes == 60 * 24)
            {
                this.allDayCheckBox.Checked = true;
            }
            else if (minutes % (24 * 60) == 0)
            {
                this.durationUpDown.Value = minutes / (24 * 60);
                this.durationComboBox.SelectedItem = "Giorni";
            }
            else if (minutes % 60 == 0)
            {
                this.durationUpDown.Value = minutes / 60;
                this.durationComboBox.SelectedItem = "Ore";
            }
            else
            {
                this.durationUpDown.Value = minutes;
                this.durationComboBox.SelectedItem = "Minuti";
            }
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
            Calendario calendar = e.Item as Calendario;
            BindingContainer<Calendario> calendarContainer = new BindingContainer<Calendario>(calendar.Nome, calendar);

            switch (e.Action)
            {
                case AgendaCollectionEventArgs.EditAction.AddItem:
                    this.calendarioBindingSource.Add(calendarContainer);
                    this.calendarSelectorComboBox.SelectedItem = calendarContainer;
                    break;

                case AgendaCollectionEventArgs.EditAction.RemoveItem:
                    this.calendarioBindingSource.Remove(calendarContainer);
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
        
        private void validateForm(object sender, DataGridViewCellEventArgs e)
        {
            this.validateForm(sender, EventArgs.Empty);
        }

        private void validateForm(object sender, EventArgs e)
        {
            this.createButton.Enabled = !String.IsNullOrWhiteSpace(this.eventNameTextBox.Text) && this.calendarSelectorComboBox.SelectedValue != null && this.eventModelSelectorComboBox.SelectedValue != null;
            if (this.createButton.Enabled && _evento != null)
            {
                this.createButton.Enabled = !this.GetEvento().Equals(_evento);
            }
        }

        private void calendarSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.calendarSelectorComboBox.SelectedItem != null && this.calendarSelectorComboBox.SelectedValue == null)
            {
                this.Visible = false;

                using (ManageCalendarForm createCalendarDialog = new ManageCalendarForm())
                {
                    createCalendarDialog.ShowDialog(this);
                }

                this.Visible = true;
            }

            this.validateForm(sender, EventArgs.Empty);
        }

        private void eventModelSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.eventModelSelectorComboBox.SelectedItem != null)
            {
                if (this.eventModelSelectorComboBox.SelectedValue == null)
                {
                    this.Visible = false;

                    using (CreateEventModelForm createEventModelDialog = new CreateEventModelForm())
                    {
                        createEventModelDialog.ShowDialog(this);
                    }

                    this.Visible = true;
                }
                else
                {
                    ModelloEvento modelloEvento = this.eventModelSelectorComboBox.SelectedValue as ModelloEvento;
                    this.entriesDataGridView.DataSource = modelloEvento.Voci.Select(voce => VoceFactory.GetImplementedVoce(voce)).ToList();
                }
            }

            this.validateForm(sender, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Calendario calendario = this.calendarSelectorComboBox.SelectedValue as Calendario;
            Evento evento = this.GetEvento();

            if (_evento != null)
            {
                calendario.RimuoviEvento(_evento);
            }

            calendario.AggiungiEvento(evento);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void durationUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.durationUpDown.Text))
            {
                this.durationUpDown.Text = this.durationUpDown.Value.ToString();
            }

            this.validateForm(sender, EventArgs.Empty);
        }

        private void frequencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.frequencyTypeComboBox.Enabled = this.frequencyComboBox.SelectedIndex >= 0 && (this.periodicitaBindingSource[this.frequencyComboBox.SelectedIndex] as IBindingContainer).DisplayText.Equals("Personalizzata");
            this.frequencyNumericUpDown.Enabled = this.frequencyTypeComboBox.Enabled;

            this.validateForm(sender, EventArgs.Empty);
        }

        private void SetCustomFrequency(object sender, EventArgs e)
        {
            BindingContainer<Periodicita> custom = this.frequencyComboBox.SelectedItem as BindingContainer<Periodicita>;
            if (custom != null)
            {
                custom.Value = new Periodicita((Periodicita.Frequenza)this.frequencyTypeComboBox.SelectedValue, (int)this.frequencyNumericUpDown.Value);
            }

            this.validateForm(sender, EventArgs.Empty);
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
                new PeriodoTempo(this.eventDateTimePicker.Value, duration),
                this.eventModelSelectorComboBox.SelectedValue as ModelloEvento,
                this.entriesDataGridView.DataSource as IEnumerable<IVoce>,
                this.eventDescriptionTextBox.Text,
                this.eventLocationTextBox.Text,
                (Periodicita)this.frequencyComboBox.SelectedValue);
        }



    }
}
