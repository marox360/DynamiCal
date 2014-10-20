using DynamiCal.Time;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DynamiCal.Model
{
    internal struct Periodicita
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

        public bool TestaPeriodo(TimePeriod eventPeriod, TimePeriod otherPeriod)
        {
            foreach (DateTime date in TimePeriod.DaysSequence(otherPeriod))
            {
                if (this.TestaData(eventPeriod, date))
                {
                    return true;
                }
            }

            return false;
        }

        public bool TestaData(TimePeriod eventPeriod, DateTime testDate)
        {
            TimePeriod testPeriod = new TimePeriod(testDate.Date, TimeSpan.FromDays(1));

            if (testPeriod < eventPeriod)
            {
                return false;
            }

            switch (_frequenza)
            {
                case Frequenza.Mai:
                    return eventPeriod.IntersectWith(testPeriod);

                case Frequenza.Giornaliera:
                    return Periodicita.TestDaySequence(eventPeriod, testPeriod, _valore, Frequenza.Giornaliera);

                case Frequenza.Settimanale:
                    return Periodicita.TestDaySequence(eventPeriod, testPeriod, _valore, Frequenza.Settimanale);

                case Frequenza.Mensile:
                    return Periodicita.TestDaySequence(eventPeriod, testPeriod, _valore, Frequenza.Mensile);

                case Frequenza.Annuale:
                    return Periodicita.TestDaySequence(eventPeriod, testPeriod, _valore, Frequenza.Annuale);
            }

            return false;
        }

        public int NumberOfRepetitions(TimePeriod eventPeriod, DateTime testDate)
        {
            if (!this.TestaData(eventPeriod, testDate))
            {
                return -1;
            }

            TimePeriod testPeriod = new TimePeriod(testDate.Date, TimeSpan.FromDays(1));

            switch (_frequenza)
            {
                case Frequenza.Mai:
                    return 0;

                case Frequenza.Giornaliera:
                    return Periodicita.CountRepetitions(eventPeriod, testPeriod, _valore, Frequenza.Giornaliera);

                case Frequenza.Settimanale:
                    return Periodicita.CountRepetitions(eventPeriod, testPeriod, _valore, Frequenza.Settimanale);

                case Frequenza.Mensile:
                    return Periodicita.CountRepetitions(eventPeriod, testPeriod, _valore, Frequenza.Mensile);

                case Frequenza.Annuale:
                    return Periodicita.CountRepetitions(eventPeriod, testPeriod, _valore, Frequenza.Annuale);
            }

            return -1;
        }

        private static int CountRepetitions(TimePeriod timePeriod, TimePeriod testPeriod, int valore, Frequenza frequenza)
        {
            Func<DateTime, DateTime, TimeSpan, int, bool> testFunction = Periodicita.TestRepetitionFunction(frequenza);
            Func<DateTime, DateTime, TimeSpan, int, int> repetitionFunction = Periodicita.NumberOfRepetitionsFunction(frequenza);
            if (testFunction == null || repetitionFunction == null)
            {
                return -1;
            }

            foreach (DateTime day in TimePeriod.DaysSequence(timePeriod))
            {
                TimeSpan timeSpan = testPeriod.StartDate - day;
                if (timeSpan.TotalDays < 0)
                {
                    return -1;
                }
                else if (testFunction(day, testPeriod.StartDate, timeSpan, valore))
                {
                    return repetitionFunction(day, testPeriod.StartDate, timeSpan, valore);
                }
            }

            return -1;
        }

        private static bool TestDaySequence(TimePeriod timePeriod, TimePeriod testPeriod, int valore, Frequenza frequenza)
        {
            Func<DateTime, DateTime, TimeSpan, int, bool> testFunction = Periodicita.TestRepetitionFunction(frequenza);
            if (testFunction == null)
            {
                return false;
            }

            foreach (DateTime day in TimePeriod.DaysSequence(timePeriod))
            {
                TimeSpan timeSpan = testPeriod.StartDate - day;
                if (timeSpan.TotalDays < 0)
                {
                    return false;
                }
                else if (testFunction(day, testPeriod.StartDate, timeSpan, valore))
                {
                    return true;
                }
            }

            return false;
        }

        private static Func<DateTime, DateTime, TimeSpan, int, bool> TestRepetitionFunction(Frequenza frequenza)
        {
            switch (frequenza)
            {
                case Frequenza.Giornaliera:
                    return (_, __, timeSpan, value) =>
                                (timeSpan.Days % value) == 0;

                case Frequenza.Settimanale:
                    return (_, __, timeSpan, value) =>
                                (timeSpan.Days % 7) == 0 && (timeSpan.Days / 7) % value == 0;

                case Frequenza.Mensile:
                    return (day, testDay, _, value) =>
                                 testDay.Day == day.Day &&
                                (testDay.Month + (testDay.Year != day.Year ? 12 : 0) - day.Month) % value == 0;

                case Frequenza.Annuale:
                    return (day, testDay, _, value) =>
                                 testDay.Day == day.Day &&
                                 testDay.Month == day.Month &&
                                (testDay.Year - day.Year) % value == 0;

                default:
                    return null;
            }
        }

        private static Func<DateTime, DateTime, TimeSpan, int, int> NumberOfRepetitionsFunction(Frequenza frequenza)
        {
            switch (frequenza)
            {
                case Frequenza.Giornaliera:
                    return (_, __, timeSpan, value) =>
                                timeSpan.Days / value;

                case Frequenza.Settimanale:
                    return (_, __, timeSpan, value) =>
                                timeSpan.Days / (7 * value);

                case Frequenza.Mensile:
                    return (day, testDay, _, value) =>
                                (testDay.Month + (testDay.Year - day.Year) * 12 - day.Month) / value;

                case Frequenza.Annuale:
                    return (day, testDay, _, value) =>
                                (testDay.Year - day.Year) / value;

                default:
                    return null;
            }
        }

        public static Periodicita operator *(Periodicita periodicita, int valore)
        {
            return new Periodicita(periodicita.Ripetizione, valore);
        }

        public override string ToString()
        {
            switch (_frequenza)
            {
                case Frequenza.Mai:
                    return "Mai";

                case Frequenza.Giornaliera:
                    return "Ogni " + (_valore == 1 ? "giorno" : _valore + " giorni");

                case Frequenza.Settimanale:
                    return "Ogni " + (_valore == 1 ? "settimana" : _valore + " settimane");

                case Frequenza.Mensile:
                    return "Ogni " + (_valore == 1 ? "mese" : _valore + " mesi");

                case Frequenza.Annuale:
                    return "Ogni " + (_valore == 1 ? "anno" : _valore + " anni");
            }

            return base.ToString();
        }
    }
}