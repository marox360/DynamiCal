using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamiCal.Model
{
    class Periodicita
    {
        private int _ogniGiorno;
        private int _ogniSettimana;
        private int _ogniMese;
        private int _ogniAnno;

        public Periodicita(int ogniGiorno, int ogniSettimana, int ogniMese, int ogniAnno)
        {
            _ogniGiorno = ogniGiorno;
            _ogniSettimana = ogniSettimana;
            _ogniMese = ogniMese;
            _ogniAnno = ogniAnno;
        }

        public int OgniGiorno
        {
            set
            {
                _ogniGiorno = value;
            }
            get
            {
                return _ogniGiorno;
            }
        }

        public int OgniSettimana
        {
            set
            {
                _ogniSettimana = value;
            }
            get
            {
                return _ogniSettimana;
            }
        }

        public int OgniMese
        {
            set
            {
                _ogniMese = value;
            }
            get
            {
                return _ogniMese;
            }
        }

        public int OgniAnno
        {
            set
            {
                _ogniAnno = value;
            }
            get
            {
                return _ogniAnno;
            }
        }
    }
}
