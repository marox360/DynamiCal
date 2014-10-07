﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace DynamiCal.Model
{
    class TipoVoce : IEquatable<TipoVoce>
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

        public TipoVoce(Tipo tipoDiVoce)
        {
            this.TipoDiVoce = tipoDiVoce;
        }

        public static TipoVoce Stringa
        {
            get
            {
                return new TipoVoce(Tipo.Stringa);
            }
        }

        public static TipoVoce Double
        {
            get
            {
                return new TipoVoce(Tipo.Double);
            }
        }

        public static TipoVoce Boolean
        {
            get
            {
                return new TipoVoce(Tipo.Boolean);
            }
        }

        public static TipoVoce Data
        {
            get
            {
                return new TipoVoce(Tipo.Data);
            }
        }

        public Tipo TipoDiVoce { get; private set; }

        public string Descrizione
        {
            get
            {
                return this.GetEnumDescription(this.TipoDiVoce);
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

        public bool Equals(TipoVoce other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return this.TipoDiVoce == other.TipoDiVoce;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((TipoVoce)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (this.TipoDiVoce.GetHashCode() * 397);
            }
        }
    }
}
