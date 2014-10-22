using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Reflection;

namespace DynamiCal.Model
{
    static class TipoVoceExtension
    {
        public static string GetDescription(this Voce.Tipo value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }

    class Voce
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

        private readonly string _nome;
        private readonly Tipo _tipo;

        public Voce(string nome, Tipo tipo) 
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            _nome = nome.Trim();
            _tipo = tipo;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public Tipo TipoVoce
        {
            get
            {
                return _tipo;
            }
        }
    }

    interface IVoce : IEquatable<IVoce>
    {
        string Nome { get; }

        object Valore { get; set; }

        IVoce Copy();
    }

    class Voce<T> : IVoce, IEquatable<Voce<T>>
    {
        private readonly string _nome;
        private T _valore;

        public Voce(string nome, T valore = default(T))
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            _valore = valore;
            _nome = nome;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public T Valore
        {
            get
            {
                return _valore;
            }
            set
            {
                _valore = value;
            }
        }

        object IVoce.Valore
        {
            get
            {
                return this.Valore;
            }
            set
            {
                if (value is T)
                {
                    this.Valore = (T)value;
                }
            }
        }

        public IVoce Copy()
        {
            return new Voce<T>(_nome, _valore);
        }

        public bool Equals(IVoce other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return string.Equals(this.Nome, other.Nome) && this.Valore.Equals(other.Valore);
        }

        public bool Equals(Voce<T> other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return string.Equals(this.Nome, other.Nome) && EqualityComparer<T>.Default.Equals(this.Valore, other.Valore);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Voce<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (this.Nome.GetHashCode() * 397) + (this.Valore != null ? this.Valore.GetHashCode() : 0);
            }
        }
    }
}
