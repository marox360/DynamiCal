using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    class Calendario
    {
        private string _nome;

        public Calendario(string nome)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            _nome = nome;
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
