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
            this.frequencyComboBox.SelectedIndex = 0;

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

            this.durationUpDown.Value = 1;
            this.durationUpDown.Text = this.durationUpDown.Value.ToString();
            this.durationComboBox.SelectedItem = "Giorni";
        }

        private void validateForm(object sender, EventArgs e)
        {
            this.createButton.Enabled = !String.IsNullOrWhiteSpace(this.eventNameTextBox.Text);
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
            this.frequencyTypeComboBox.Enabled = this.frequencyComboBox.SelectedItem.Equals("Personalizzata");
            this.frequencyNumericUpDown.Enabled = this.frequencyTypeComboBox.Enabled;
        }
    }

    /*internal class ModelloEventoContainer : IEquatable<ModelloEventoContainer>, IComparable<ModelloEventoContainer>
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
    }*/
}
