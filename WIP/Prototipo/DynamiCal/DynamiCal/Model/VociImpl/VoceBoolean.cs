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
        private string _nome;
        private TipoVoce _tipo;
        private bool _valore;

        public VoceBoolean(string nome, TipoVoce tipo) : base(nome, tipo)
        {
            _valore = false;
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
