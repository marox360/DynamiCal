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
        private string _nome;
        private TipoVoce _tipo;

        public Voce(string nome, TipoVoce tipo) 
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            Debug.Assert(tipo != null, "Tipo is null");
            #endregion

            _nome = nome;
            _tipo = tipo;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public TipoVoce Tipo
        {
            get
            {
                return _tipo;
            }
        }
    }
}
