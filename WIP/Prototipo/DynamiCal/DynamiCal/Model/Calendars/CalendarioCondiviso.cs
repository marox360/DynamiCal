using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    class CalendarioCondiviso : Calendario
    {
        private List<Amico> _amici;
    
        public CalendarioCondiviso(string nome) : base(nome)
        {
            _amici = new List<Amico>();
        }

        public List<Amico> Amici
        {
            get
            {
                return _amici;
            }
        }
    }
}
