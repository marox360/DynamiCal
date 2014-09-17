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
        public enum TipoVoce {Stringa, Double, Boolean, Data};

        private string _nome;
        private TipoVoce _tipo;
        public Voce(String nome, TipoVoce tipo) 
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Event Name is null");
            #endregion

            _nome = nome;
            _tipo = tipo;
        }

        public string nome
        {
            get
            {
                return _nome;
            }
        }
    }
}
