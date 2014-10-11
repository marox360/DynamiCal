using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    class Evento
    {
        private string _nome;
        private string _descrizione;
        private string _luogo;
        private DateTime _data;
        private long _durata;
        private Periodicita _periodicita;
        private ModelloEvento _modello;
        private List<IVoce> _voci;

        public Evento(string nome, DateTime data, long durata, ModelloEvento modello, IEnumerable<IVoce> voci = null, string descrizione = null, string luogo = null, Periodicita? periodicita = null)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or whitespace");
            Debug.Assert(data != null, "Data is null");
            Debug.Assert(durata >= 0, "Durata is negative"); // Una durata = 0 indica che l'evento dura tutto il giorno
            Debug.Assert(modello != null, "Modello is null");
            #endregion

            _nome = nome.Trim();
            _descrizione = descrizione.Trim();
            _luogo = luogo.Trim();
            _data = data;
            _durata = durata;
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

        public DateTime Data
        {
            set
            {
                #region Precondizioni
                Debug.Assert(value != null, "Data is null");
                #endregion

                _data = value;
            }
            get
            {
                return _data;
            }
        }

        public long Durata
        {
            set
            {
                #region Precondizioni
                Debug.Assert(value >= 0, "Durata is negative");
                #endregion

                _durata = value;
            }
            get
            {
                return _durata;
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
    }
}
