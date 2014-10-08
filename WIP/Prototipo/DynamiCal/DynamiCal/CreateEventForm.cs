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
            List<IVoce> voceContainerBindingSource = new List<IVoce>();
            voceContainerBindingSource.Add(VoceFactory.GetImplementedVoce(new Voce("stringa", TipoVoce.Stringa)));
            voceContainerBindingSource.Add(VoceFactory.GetImplementedVoce(new Voce("boolean", TipoVoce.Boolean)));
            voceContainerBindingSource.Add(VoceFactory.GetImplementedVoce(new Voce("numero", TipoVoce.Double)));
            voceContainerBindingSource.Add(VoceFactory.GetImplementedVoce(new Voce("data", TipoVoce.Data)));
            entriesDataGridView.DataSource = voceContainerBindingSource;

            for (int i = 0; i < voceContainerBindingSource.Count; i++)
            {
                IVoce voce = voceContainerBindingSource[i];

                if (voce is Voce<bool>)
                {
                    entriesDataGridView[1, i] = new DataGridViewCheckBoxCell();
                }
                else if (voce is Voce<DateTime>)
                {
                    entriesDataGridView[1, i] = new DataGridViewCalendarCell();
                }
                else
                {
                    entriesDataGridView[1, i] = new DataGridViewTextBoxCell();
                }
            }

            durationComboBox.SelectedIndex = 0;

            eventModelSelectorComboBox.BeginUpdate();
            modelloEventoContainerBindingSource.Add(new ModelloEventoContainer("Nuovo Modello..."));
            foreach (ModelloEvento modello in Agenda.Instance.ModelliEvento)
            {
                ModelloEventoContainer eventModelContainer = new ModelloEventoContainer(modello);
                modelloEventoContainerBindingSource.Add(new ModelloEventoContainer(modello));

                if (modello.Voci.Count == 0)
                {
                    eventModelSelectorComboBox.SelectedItem = eventModelContainer;
                }
            }
            eventModelSelectorComboBox.EndUpdate();

            calendarSelectorComboBox.BeginUpdate();
            foreach (Calendario calendario in Agenda.Instance.Calendari)
            {
                calendarioBindingSource.Add(calendario);

                if (calendarSelectorComboBox.SelectedItem == null)
                {
                    calendarSelectorComboBox.SelectedItem = calendario;
                }
            }
            calendarSelectorComboBox.EndUpdate();

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
            ModelloEventoContainer eventModelContainer = new ModelloEventoContainer(e.Item as ModelloEvento);

            switch (e.Action)
            {
                case AgendaCollectionEventArgs.EditAction.AddItem:
                    modelloEventoContainerBindingSource.Add(eventModelContainer);
                    eventModelSelectorComboBox.SelectedItem = eventModelContainer;
                    break;

                case AgendaCollectionEventArgs.EditAction.RemoveItem:
                    modelloEventoContainerBindingSource.Remove(eventModelContainer);
                    break;
            }
        }

        private void CalendarsChanged(object sender, AgendaCollectionEventArgs e)
        {
            switch (e.Action)
            {
                case AgendaCollectionEventArgs.EditAction.AddItem:
                    calendarioBindingSource.Add(e.Item);
                    break;

                case AgendaCollectionEventArgs.EditAction.RemoveItem:
                    calendarioBindingSource.Remove(e.Item);
                    break;
            }
        }

        private void allDayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            durationComboBox.Enabled = !allDayCheckBox.Checked;
            durationUpDown.Enabled = !allDayCheckBox.Checked;

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
            if (eventModelSelectorComboBox.SelectedItem != null)
            {
                ModelloEvento modelloEvento = (eventModelSelectorComboBox.SelectedItem as ModelloEventoContainer).EventModel;
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
                    /*voceBindingSource.Clear();
                    foreach (Voce voce in modelloEvento.Voci)
                    {
                        voceBindingSource.Add(VoceFactory.GetImplementedVoce(voce));
                    }*/
                    //entriesDataGridView.Columns.Add(Model.Agenda.Instance.ModelliEvento.Last().Voci);
                    //entriesDataGridView.Columns.Add(Model.Agenda.Instance.ModelliEvento.Where(modello => modello.Voci).First());
                }
            }

            validateForm();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void periodicityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            periodicityRadioButtonsPanel.Enabled = periodicityCheckBox.Checked;
        }
    }

    internal class ModelloEventoContainer : IEquatable<ModelloEventoContainer>, IComparable<ModelloEventoContainer>
    {
        private object _object;

        public ModelloEventoContainer(ModelloEvento modelloEvento)
        {
            _object = modelloEvento;
        }

        public ModelloEventoContainer(string text)
        {
            _object = text;
        }

        public string DisplayValue
        {
            get
            {
                if (_object is ModelloEvento)
                {
                    return (_object as ModelloEvento).Nome;
                }
                
                return (string)_object;
            }
        }

        public ModelloEvento EventModel
        {
            get
            {
                if (_object is ModelloEvento)
                {
                    return (ModelloEvento)_object;
                }

                return null;
            }
        }

        public bool Equals(ModelloEventoContainer other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (this._object.GetType() != other._object.GetType())
                return false;
            if (this._object is ModelloEvento)
                return ModelloEvento.Equals(this._object, other._object);
            return string.Equals(this._object, other._object);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((ModelloEventoContainer)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.DisplayValue != null ? this.DisplayValue.GetHashCode() : 0) * 397);
            }
        }

        public int CompareTo(ModelloEventoContainer other)
        {
            if (this._object.GetType() != other._object.GetType())
            {
                return this._object is ModelloEvento ? -1 : 1;
            }

            return this.DisplayValue.CompareTo(other.DisplayValue);
        }
    }
}
