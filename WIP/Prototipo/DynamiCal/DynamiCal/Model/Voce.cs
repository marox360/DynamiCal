using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace DynamiCal.Model
{
    class Voce
    {
        public enum TipoVoce {
            [Description("Testo")]
            Stringa,
            [Description("Numero")]
            Double,
            [Description("Sì/No")]
            Boolean,
            [Description("Data")]
            Data};

        private string _nome;
        private TipoVoce _tipo;

        public Voce(string nome, TipoVoce tipo) 
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Event Name is null");
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
    }
}
