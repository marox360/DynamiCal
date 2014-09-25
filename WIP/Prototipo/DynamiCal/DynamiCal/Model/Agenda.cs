using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    class Agenda
    {
        private List<Calendario> _calendari;
        private List<ModelloEvento> _modelliEvento;
        public event EventHandler CalendarsChanged; 

        public Agenda()
        {
            _calendari = new List<Calendario>();
            _modelliEvento = new List<ModelloEvento>();
        }

        public List<Calendario> Calendari
        {
            get
            {
                return _calendari;
            }
        }

        public List<ModelloEvento> ModelliEvento
        {
            get
            {
                return _modelliEvento;
            }
        }

        public void AggiungiCalendario(Calendario calendario)
        {
            #region Precondizioni
            Debug.Assert(!_calendari.Contains(calendario), "Agenda already contains a calendar with identifier " + calendario.Nome);
            #endregion

            _calendari.Add(calendario);

            OnCalendarsChanged();
        }

        protected virtual void OnCalendarsChanged()
        {
            if (CalendarsChanged != null)
            {
                CalendarsChanged(this, EventArgs.Empty);
            }
        }
    }
}
