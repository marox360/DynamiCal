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

        public Evento(string nome, string descrizione, string luogo, DateTime data, long durata, Periodicita periodicita, ModelloEvento modello)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or whitespace");
            Debug.Assert(data != null, "Data is null");
            Debug.Assert(durata < 0, "Durata is negative");
            Debug.Assert(modello != null, "Modello is null");
            #endregion

            _nome = nome;
            _descrizione = descrizione;
            _luogo = luogo;
            _data = data;
            _durata = durata;
            _periodicita = periodicita;
            _modello = modello;
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
                Debug.Assert(value < 0, "Durata is negative");
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
    }
}
