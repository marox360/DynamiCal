using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    class Voce
    {
        public Voce(string nome, TipoVoce tipo) 
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            Debug.Assert(tipo != null, "Tipo is null");
            #endregion

            this.Nome = nome.Trim();
            this.Tipo = tipo;
        }

        public string Nome { get; private set; }

        public TipoVoce Tipo { get; private set; }
    }

    interface IVoce
    {
        string Nome { get; set; }

        object Valore { get; set; }
    }

    class Voce<T> : IVoce
    {
        public Voce(string nome) : this(nome, default(T)) { }

        public Voce(string nome, T valore)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            this.Valore = valore;
            this.Nome = nome;
        }

        public string Nome { get; set; }

        public T Valore { get; set; }

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
    }
}
