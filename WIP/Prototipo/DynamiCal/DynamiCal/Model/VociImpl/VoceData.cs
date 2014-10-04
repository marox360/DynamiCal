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
        private DateTime _valore;

        public VoceData(string nome, TipoVoce tipo) : base(nome, tipo)
        {
            _valore = DateTime.Today;
        }

        public DateTime Valore
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
