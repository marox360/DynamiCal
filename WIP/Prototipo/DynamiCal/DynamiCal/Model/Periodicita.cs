using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DynamiCal.Model
{
    public struct Periodicita
    {
        public enum Frequenza
        {
            Mai = 0, Giornaliera, Settimanale, Mensile, Annuale
        }

        private int _valore;
        private Frequenza _frequenza;

        public Periodicita(Frequenza frequenza, int valore = 1)
        {
            #region Precondizioni
            Debug.Assert(valore >= 1, "Valore can't be zero or negative");
            #endregion

            _valore = valore;
            _frequenza = frequenza;
        }

        public static Periodicita Mai
        {
            get
            {
                return new Periodicita(Frequenza.Mai);
            }
        }

        public static Periodicita Giornaliera
        {
            get
            {
                return new Periodicita(Frequenza.Giornaliera);
            }
        }

        public static Periodicita Settimanale
        {
            get
            {
                return new Periodicita(Frequenza.Settimanale);
            }
        }

        public static Periodicita Mensile
        {
            get
            {
                return new Periodicita(Frequenza.Mensile);
            }
        }

        public static Periodicita Annuale
        {
            get
            {
                return new Periodicita(Frequenza.Annuale);
            }
        }

        public int Valore
        {
            get
            {
                return _valore;
            }
            set
            {
                #region Precondizioni
                Debug.Assert(value >= 1, "Valore can't be zero or negative");
                #endregion

                _valore = value;
            }
        }

        public Frequenza Ripetizione
        {
            get
            {
                return _frequenza;
            }
            set
            {
                _frequenza = value;
            }
        }

        public bool TestaPeriodo(DateTime eventDate, DateTime startDate, DateTime endDate)
        {
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (this.TestaData(eventDate, date))
                {
                    return true;
                }
            }

            return false;
        }

        public bool TestaData(DateTime eventDate, DateTime testDate)
        {
            #warning L'implentazione attuale non tiene conto della durata dell'evento!! Meglio considerarla qui o in evento?!
            if (testDate < eventDate)
            {
                return false;
            }

            TimeSpan timeSpan = testDate - eventDate;

            switch (_frequenza)
            {
                case Frequenza.Mai:
                    return
                        timeSpan.Days == 0;

                case Frequenza.Giornaliera:
                    return
                        (timeSpan.Days % _valore) == 0;

                case Frequenza.Settimanale:
                    return
                        (timeSpan.Days % 7) == 0 && (timeSpan.Days / 7) % _valore == 0;

                case Frequenza.Mensile:
                    return
                        testDate.Day == eventDate.Day &&
                        (testDate.Month + (testDate.Year != eventDate.Year ? 12 : 0) - eventDate.Month) % _valore == 0;

                case Frequenza.Annuale:
                    return
                        testDate.Day == eventDate.Day &&
                        testDate.Month == eventDate.Month &&
                        (testDate.Year - eventDate.Year) % _valore == 0;
            }

            return false;
        }

        public static Periodicita operator *(Periodicita periodicita, int valore)
        {
            return new Periodicita(periodicita.Ripetizione, valore);
        }
    }
}