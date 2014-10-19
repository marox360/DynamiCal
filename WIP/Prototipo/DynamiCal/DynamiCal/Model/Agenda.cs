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
        public event AgendaCollectionEventHandler CalendarsChanged;
        public event AgendaCollectionEventHandler EventModelsChanged; 

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

        public IList<Calendario> Calendari
        {
            get
            {
                return _calendari.AsReadOnly();
            }
        }

        public IList<ModelloEvento> ModelliEvento
        {
            get
            {
                return _modelliEvento.AsReadOnly();
            }
        }

        public void AggiungiCalendario(Calendario calendario)
        {
            #region Precondizioni
            Debug.Assert(calendario != null, "Calendario cannot be null");
            Debug.Assert(!_calendari.Contains(calendario), "Agenda already contains a calendar with identifier " + calendario.Nome);
            #endregion

            _calendari.Add(calendario);

            this.OnCalendarsChanged(new AgendaCollectionEventArgs(calendario, AgendaCollectionEventArgs.EditAction.AddItem));
        }

        public void RimuoviCalendario(Calendario calendario)
        {
            #region Precondizioni
            Debug.Assert(calendario != null, "Calendario cannot be null");
            #endregion

            if (_calendari.Remove(calendario))
            {
                this.OnCalendarsChanged(new AgendaCollectionEventArgs(calendario, AgendaCollectionEventArgs.EditAction.RemoveItem));
            }
        }

        public void AggiungiModelloEvento(ModelloEvento modelloEvento)
        {
            #region Precondizioni
            Debug.Assert(modelloEvento != null, "ModelloEvento cannot be null");
            Debug.Assert(!_modelliEvento.Contains(modelloEvento), "Agenda already contains a event model with identifier " + modelloEvento.Nome);
            #endregion

            _modelliEvento.Add(modelloEvento);

            this.OnEventModelsChanged(new AgendaCollectionEventArgs(modelloEvento, AgendaCollectionEventArgs.EditAction.AddItem));
        }

        public void RimuoviModelloEvento(ModelloEvento modelloEvento)
        {
            #region Precondizioni
            Debug.Assert(modelloEvento != null, "ModelloEvento cannot be null");
            #endregion

            if (_modelliEvento.Remove(modelloEvento))
            {
                this.OnEventModelsChanged(new AgendaCollectionEventArgs(modelloEvento, AgendaCollectionEventArgs.EditAction.RemoveItem));
            }
        }

        protected virtual void OnCalendarsChanged(AgendaCollectionEventArgs e)
        {
            if (this.CalendarsChanged != null)
            {
                this.CalendarsChanged(this, e);
            }
        }

        protected virtual void OnEventModelsChanged(AgendaCollectionEventArgs e)
        {
            if (this.EventModelsChanged != null)
            {
                this.EventModelsChanged(this, e);
            }
        }
    }

    public class AgendaCollectionEventArgs : EventArgs
    {
        public enum EditAction { AddItem, RemoveItem }

        public AgendaCollectionEventArgs(object item, EditAction action)
        {
            this.Item = item;
            this.Action = action;
        }

        public object Item { get; private set; }

        public EditAction Action { get; private set; }
    }

    public delegate void AgendaCollectionEventHandler(object source, AgendaCollectionEventArgs e);
}
