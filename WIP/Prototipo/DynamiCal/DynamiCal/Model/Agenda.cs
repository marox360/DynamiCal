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
        private List<ModelloEvento> _modelliEvento;

        public Agenda()
        {
            _calendari = new List<Calendario>();
            _modelliEvento = new List<ModelloEvento>();
        }

        public List<Calendario> calendari
        {
            get
            {
                return _calendari;
            }
        }

        public List<ModelloEvento> modelliEvento
        {
            get
            {
                return _modelliEvento;
            }
        }
    }
}
