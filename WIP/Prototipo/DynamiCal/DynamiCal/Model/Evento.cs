using DynamiCal.Time;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    class Evento : IEquatable<Evento>
    {
        private string _nome;
        private string _descrizione;
        private string _luogo;
        private TimePeriod _periodo;
        private Periodicita _periodicita;
        private ModelloEvento _modello;
        private List<IVoce> _voci;

        public Evento(string nome, TimePeriod periodo, ModelloEvento modello, IEnumerable<IVoce> voci = null, string descrizione = "", string luogo = "", Periodicita? periodicita = null)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or whitespace");
            Debug.Assert(periodo.Duration.TotalMinutes > 0, "Durata is negative or zero");
            Debug.Assert(modello != null, "Modello is null");
            #endregion

            _nome = nome.Trim();
            _descrizione = descrizione.Trim();
            _luogo = luogo.Trim();
            _periodo = periodo;
            _periodicita = periodicita.HasValue ? periodicita.Value : Periodicita.Mai;
            _modello = modello;
            _voci = voci == null ? new List<IVoce>() : new List<IVoce>(voci);
        }

        public string Nome
        {
            set
            {
                #region Precondizioni
                Debug.Assert(!String.IsNullOrWhiteSpace(value), "Nome is null or whitespace");
                #endregion

                _nome = value;
            }
            get
            {
                return _nome;
            }
        }

        public string Descrizione
        {
            set
            {
                _descrizione = value;
            }
            get
            {
                return _descrizione;
            }
        }

        public string Luogo
        {
            set
            {
                _luogo = value;
            }
            get
            {
                return _luogo;
            }
        }

        public TimePeriod Periodo
        {
            set
            {
                #region Precondizioni
                Debug.Assert(value.Duration.TotalMinutes > 0, "Durata is negative or zero");
                #endregion

                _periodo = value;
            }
            get
            {
                return _periodo;
            }
        }

        public Periodicita Periodicita
        {
            set
            {
                _periodicita = value;
            }
            get
            {
                return _periodicita;
            }
        }

        public ModelloEvento Modello
        {
            get
            {
                return _modello;
            }
        }

        public IList<IVoce> Voci
        {
            get
            {
                return _voci.AsReadOnly();
            }
        }

        public bool Equals(Evento other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return string.Equals(this.Nome, other.Nome) && this.Periodo.Equals(other.Periodo) && this.Periodicita.Equals(other.Periodicita);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Evento)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (this.Nome.GetHashCode() * 397) + this.Periodo.GetHashCode() + this.Periodicita.GetHashCode();
            }
        }
    }
}
