using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    class VoceData : Voce
    {
        private string _nome;
        private TipoVoce _tipo;
        private DateTime _valore;

        public VoceData(string nome, TipoVoce tipo) : base(nome, tipo)
        {
            _valore = DateTime.Today;
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

        public DateTime Valore
        {
            get
            {
                return _valore;
            }
            set
            {
                this._valore = value;
            }
        }
    }
}
