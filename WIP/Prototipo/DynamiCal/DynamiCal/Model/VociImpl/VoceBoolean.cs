using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    class VoceBoolean : Voce
    {
        private bool _valore;

        public VoceBoolean(string nome, TipoVoce tipo) : base(nome, tipo)
        {
            _valore = false;
        }

        public bool Valore
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
