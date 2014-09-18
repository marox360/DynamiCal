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
            Debug.Assert(durata > 0, "Durata is zero or negative");
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
    }
}
