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

    class Voce<T> : Voce
    {
        public Voce(string nome, TipoVoce tipo) : this(nome, tipo, default(T)) { }

        public Voce(string nome, TipoVoce tipo, T valore) : base(nome, tipo)
        {
            this.Valore = valore;
        }

        public T Valore { get; set; }
    }
}
