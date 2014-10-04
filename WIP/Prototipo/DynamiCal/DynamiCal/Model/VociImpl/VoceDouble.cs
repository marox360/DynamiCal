using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    class VoceDouble : Voce
    {
        private string _nome;
        private TipoVoce _tipo;
        private double _valore;

        public VoceDouble(string nome, TipoVoce tipo) : base(nome, tipo)
        {
            _valore = 0;
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

        public double Valore
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
