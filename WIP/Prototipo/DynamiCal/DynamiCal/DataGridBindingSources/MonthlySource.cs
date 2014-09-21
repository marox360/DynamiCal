using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.DataGridBindingSources
{
    class Day
    {
        private String _descrizione;

        public Day(int day, int month, int year)
        {
            _descrizione = day.ToString();
        }

        public String Descrizione
        {
            get
            {
                return _descrizione;
            }
        }
    }

    class Week
    {
        private String[] _days;

        public Week(int weekNumber, int year)
        {
            _days = new String[7];
            for (int i = 0; i < _days.Length; i++)
            {
                _days[i] = (i + 1).ToString();
            }
        }

        public String Lunedì
        {
            get
            {
                return _days[0];
            }
        }
        public String Martedì
        {
            get
            {
                return _days[1];
            }
        }
        public String Mercoledì
        {
            get
            {
                return _days[2];
            }
        }
        public String Giovedì
        {
            get
            {
                return _days[3];
            }
        }
        public String Venerdì
        {
            get
            {
                return _days[4];
            }
        }
        public String Sabato
        {
            get
            {
                return _days[5];
            }
        }
        public String Domenica
        {
            get
            {
                return _days[6];
            }
        }
    }
}
