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
        private double _valore;

        public VoceDouble(string nome, TipoVoce tipo) : base(nome, tipo)
        {
            _valore = 0;
        }

        public double Valore
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
    }
}
