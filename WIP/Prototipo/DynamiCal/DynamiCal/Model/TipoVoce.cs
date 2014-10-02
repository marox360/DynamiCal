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
        public enum Type
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

        private Type _tipo;

        public TipoVoce(Type tipo)
        {
            _tipo = tipo;
        }

        public Type Tipo
        {
            get
            {
                return _tipo;
            }
        }

        public string Descrizione
        {
            get
            {
                return this.GetEnumDescription((Type)_tipo);
            }
        }

        public override string ToString()
        {
            return this.Descrizione;
        }

        public static List<TipoVoce> GetAllTypes()
        {
            List<TipoVoce> allTypes = new List<TipoVoce>();
            foreach (Type tipo in Enum.GetValues(typeof(Type)).Cast<Type>())
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
