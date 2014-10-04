using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace DynamiCal.Model
{
    class TipoVoce
    {
        public enum Tipo
        {
            [Description("Testo")]
            Stringa,
            [Description("Numero")]
            Double,
            [Description("Sì/No")]
            Boolean,
            [Description("Data")]
            Data
        };

        private Tipo _tipoDiVoce;

        public TipoVoce(Tipo tipoDiVoce)
        {
            _tipoDiVoce = tipoDiVoce;
        }

        public Tipo TipoDiVoce
        {
            get
            {
                return _tipoDiVoce;
            }
        }

        public string Descrizione
        {
            get
            {
                return this.GetEnumDescription((Tipo)_tipoDiVoce);
            }
        }

        public override string ToString()
        {
            return this.Descrizione;
        }

        public static List<TipoVoce> GetAllTypes()
        {
            List<TipoVoce> allTypes = new List<TipoVoce>();
            foreach (Tipo tipo in Enum.GetValues(typeof(Tipo)).Cast<Tipo>())
            {
                allTypes.Add(new TipoVoce(tipo));
            }

            return allTypes;
        }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
