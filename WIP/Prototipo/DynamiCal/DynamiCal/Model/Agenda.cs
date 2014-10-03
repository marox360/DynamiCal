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
        private static Agenda _instance = new Agenda();
        private List<Calendario> _calendari;
        private List<ModelloEvento> _modelliEvento;
        public event EventHandler CalendarsChanged;
        public event EventHandler EventModelsChanged; 

        private Agenda()
        {
            _calendari = new List<Calendario>();
            _modelliEvento = new List<ModelloEvento>();
        }

        public static Agenda Instance
        {
            get
            {
                return _instance;
            }
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
            Debug.Assert(calendario != null, "Calendario cannot be null");
            Debug.Assert(!_calendari.Contains(calendario), "Agenda already contains a calendar with identifier " + calendario.Nome);
            #endregion

            _calendari.Add(calendario);

            OnCalendarsChanged();
        }

        public void AggiungiModelloEvento(ModelloEvento modelloEvento)
        {
            #region Precondizioni
            Debug.Assert(modelloEvento != null, "ModelloEvento cannot be null");
            Debug.Assert(!_modelliEvento.Contains(modelloEvento), "Agenda already contains a event model with identifier " + modelloEvento.Nome);
            #endregion

            _modelliEvento.Add(modelloEvento);

            OnEventModelsChanged();
        }

        protected virtual void OnCalendarsChanged()
        {
            if (CalendarsChanged != null)
            {
                CalendarsChanged(this, EventArgs.Empty);
            }
        }

        protected virtual void OnEventModelsChanged()
        {
            if (EventModelsChanged != null)
            {
                EventModelsChanged(this, EventArgs.Empty);
            }
        }
    }
}
