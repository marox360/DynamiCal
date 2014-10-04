using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    class VoceStringa : Voce
    {
        private string _valore;

        public VoceStringa(string nome, TipoVoce tipo) : base(nome, tipo)
        {
            _valore = "";
        }

        public string Valore
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
