using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    class Voce
    {
        private string _nome;

        public Voce() : this(null) {}
        public Voce(String nome) {
            _nome = nome;
        }

        public string nome
        {
            set
            {
                _nome = value;
            }
            get
            {
                return _nome;
            }
        }
    }
}
