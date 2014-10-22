using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model.Calendars
{
    abstract class Calendario : IEquatable<Calendario>
    {
        private string _nome;
        private List<Evento> _eventi;

        public Calendario(string nome)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            _nome = nome.Trim();
            _eventi = new List<Evento>();
        }

        public string Nome
        {
            set
            {
                #region Precondizioni
                Debug.Assert(!String.IsNullOrWhiteSpace(value), "Nome is null or white space");
                #endregion

                _nome = value;
            }
            get
            {
                return _nome;
            }
        }

        public IList<Evento> Eventi
        {
            get
            {
                return _eventi.AsReadOnly();
            }
        }

        public void AggiungiEvento(Evento evento)
        {
            #region Precondizioni
            Debug.Assert(evento != null, "Evento cannot be null");
            #endregion

            _eventi.Add(evento);
        }

        public void AggiungiEventi(IEnumerable<Evento> eventi)
        {
            #region Precondizioni
            Debug.Assert(eventi != null, "Eventi cannot be null");
            #endregion

            _eventi.AddRange(eventi);
        }

        public void RimuoviEvento(Evento evento)
        {
            #region Precondizioni
            Debug.Assert(evento != null, "Evento cannot be null");
            #endregion

            _eventi.Remove(evento);
        }

        public bool Equals(Calendario other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return string.Equals(this.Nome, other.Nome);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Calendario)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.Nome != null ? this.Nome.GetHashCode() : 0) * 397);
            }
        }
    }
}
