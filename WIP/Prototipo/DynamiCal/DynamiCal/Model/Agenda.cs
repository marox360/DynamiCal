using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    class Agenda
    {
        private List<Calendario> _calendari;
        private List<Evento> _eventi;

        public Agenda()
        {
            _calendari = new List<Calendario>();
            _eventi = new List<Evento>();
        }

        public List<Calendario> calendari
        {
            get
            {
                return _calendari;
            }
        }

        public List<Evento> eventi
        {
            get
            {
                return _eventi;
            }
        }
    }
}
