using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    class Evento
    {
        private string _nome, _descrizione, _luogo;
        private DateTime _data;
        private long _durata;
        private Periodicita _periodicita;
        private ModelloEvento _modello;

        public Evento(string nome, DateTime data, long durata, string descrizione, Periodicita periodicita, ModelloEvento modello, string luogo)
        {
 
        }
    }
}
