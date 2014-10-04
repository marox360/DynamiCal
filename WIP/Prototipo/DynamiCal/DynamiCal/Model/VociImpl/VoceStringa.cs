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
        private string _nome;
        private TipoVoce _tipo;
        private string _valore;

        public VoceStringa(string nome, TipoVoce tipo) : base(nome, tipo)
        {
            _valore = "";
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

        public string Valore
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
