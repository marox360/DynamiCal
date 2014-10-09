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

            foreach (TipoVoceContainer tipo in TipoVoceContainer.GetAllTypes())
            {
                this.tipoVoceContainerBindingSource.Add(tipo);
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

    internal class TipoVoceContainer : IEquatable<TipoVoceContainer>
    {
        public TipoVoceContainer(Voce.Tipo tipo)
        {
            this.Value = tipo;
        }

        public Voce.Tipo Value { get; private set; }

        public string Descrizione
        {
            get
            {
                return this.GetEnumDescription(this.Value);
            }
        }

        public static List<TipoVoceContainer> GetAllTypes()
        {
            List<TipoVoceContainer> allTypes = new List<TipoVoceContainer>();
            foreach (Voce.Tipo tipo in Enum.GetValues(typeof(Voce.Tipo)).Cast<Voce.Tipo>())
            {
                allTypes.Add(new TipoVoceContainer(tipo));
            }

            return allTypes;
        }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }

        public bool Equals(TipoVoceContainer other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return this.Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((TipoVoceContainer)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (this.Value.GetHashCode() * 397);
            }
        }
    }
}
