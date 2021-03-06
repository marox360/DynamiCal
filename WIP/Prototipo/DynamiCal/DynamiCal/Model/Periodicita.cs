﻿using DynamiCal.Time;
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

        public bool TestaPeriodo(PeriodoTempo eventPeriod, PeriodoTempo otherPeriod)
        {
            Periodicita thisPeriodicita = this;
            return PeriodoTempo.DaysSequence(otherPeriod)
                .DefaultIfEmpty(default(DateTime))
                .FirstOrDefault(date => thisPeriodicita.TestaData(eventPeriod, date)) != default(DateTime);
        }

        public bool TestaData(PeriodoTempo eventPeriod, DateTime testDate)
        {
            return Periodicita.TestDaySequence(eventPeriod, new PeriodoTempo(testDate.Date, TimeSpan.FromDays(1)), _valore, _frequenza);
        }

        public int NumberOfRepetitions(PeriodoTempo eventPeriod, DateTime testDate)
        {
            if (!this.TestaData(eventPeriod, testDate))
            {
                return -1;
            }

            return Periodicita.CountRepetitions(eventPeriod, new PeriodoTempo(testDate.Date, TimeSpan.FromDays(1)), _valore, _frequenza);
        }

        private static int CountRepetitions(PeriodoTempo timePeriod, PeriodoTempo testPeriod, int valore, Frequenza frequenza)
        {
            Func<DateTime, DateTime, TimeSpan, int, bool> testFunction = frequenza.TestRepetitionFunction();
            Func<DateTime, DateTime, TimeSpan, int, int> repetitionFunction = frequenza.NumberOfRepetitionsFunction();
            if (testFunction == null || repetitionFunction == null)
            {
                return 0;
            }

            foreach (DateTime day in PeriodoTempo.DaysSequence(timePeriod).Where(day => (testPeriod.DataInizio - day).TotalDays >= 0))
            {
                TimeSpan timeSpan = testPeriod.DataInizio - day;
                if (testFunction(day, testPeriod.DataInizio, timeSpan, valore))
                {
                    return repetitionFunction(day, testPeriod.DataInizio, timeSpan, valore);
                }
            }

            return -1;
        }

        private static bool TestDaySequence(PeriodoTempo timePeriod, PeriodoTempo testPeriod, int valore, Frequenza frequenza)
        {
            Func<DateTime, DateTime, TimeSpan, int, bool> testFunction = frequenza.TestRepetitionFunction();
            if (testFunction == null)
            {
                return timePeriod.Interseca(testPeriod);
            }

            return PeriodoTempo.DaysSequence(timePeriod)
                .DefaultIfEmpty(default(DateTime))
                .Where(day => (testPeriod.DataInizio - day).TotalDays >= 0)
                .FirstOrDefault(day => testFunction(day, testPeriod.DataInizio, (testPeriod.DataInizio - day), valore)) != default(DateTime);
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

    internal static class FrequenzaExtensions
    {
        internal static Func<DateTime, DateTime, TimeSpan, int, bool> TestRepetitionFunction(this Periodicita.Frequenza frequenza)
        {
            switch (frequenza)
            {
                case Periodicita.Frequenza.Giornaliera:
                    return (_, __, timeSpan, value) =>
                                (timeSpan.Days % value) == 0;

                case Periodicita.Frequenza.Settimanale:
                    return (_, __, timeSpan, value) =>
                                (timeSpan.Days % 7) == 0 && (timeSpan.Days / 7) % value == 0;

                case Periodicita.Frequenza.Mensile:
                    return (day, testDay, _, value) =>
                                 testDay.Day == day.Day &&
                                (testDay.Month + (testDay.Year != day.Year ? 12 : 0) - day.Month) % value == 0;

                case Periodicita.Frequenza.Annuale:
                    return (day, testDay, _, value) =>
                                 testDay.Day == day.Day &&
                                 testDay.Month == day.Month &&
                                (testDay.Year - day.Year) % value == 0;

                default:
                    return null;
            }
        }

        internal static Func<DateTime, DateTime, TimeSpan, int, int> NumberOfRepetitionsFunction(this Periodicita.Frequenza frequenza)
        {
            switch (frequenza)
            {
                case Periodicita.Frequenza.Giornaliera:
                    return (_, __, timeSpan, value) =>
                                timeSpan.Days / value;

                case Periodicita.Frequenza.Settimanale:
                    return (_, __, timeSpan, value) =>
                                timeSpan.Days / (7 * value);

                case Periodicita.Frequenza.Mensile:
                    return (day, testDay, _, value) =>
                                (testDay.Month + (testDay.Year - day.Year) * 12 - day.Month) / value;

                case Periodicita.Frequenza.Annuale:
                    return (day, testDay, _, value) =>
                                (testDay.Year - day.Year) / value;

                default:
                    return null;
            }
        }
    }
}