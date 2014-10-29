using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    public struct PeriodoTempo
    {
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;
        private readonly TimeSpan _duration;

        public PeriodoTempo(TimeSpan duration, DateTime endDate) : this(endDate - duration, endDate, duration) { }
        public PeriodoTempo(DateTime startDate, TimeSpan duration) : this(startDate, startDate + duration, duration) { }
        public PeriodoTempo(DateTime startDate, DateTime endDate) : this(startDate, endDate, endDate - startDate) { }

        private PeriodoTempo(DateTime startDate, DateTime endDate, TimeSpan duration)
        {
            #region Precondizioni
            Debug.Assert(endDate > startDate, "EndDate must be > of startDate");
            #endregion

            _startDate = startDate;
            _endDate = endDate;
            _duration = duration;
        }

        public DateTime DataInizio
        {
            get
            {
                return _startDate;
            }
        }

        public DateTime DataFine
        {
            get
            {
                return _endDate;
            }
        }

        public TimeSpan Durata
        {
            get
            {
                return _duration;
            }
        }

        public bool GiornoIntero
        {
            get
            {
                return _startDate == _startDate.Date && _startDate.AddDays(1) == _endDate;
            }
        }

        public bool Interseca(PeriodoTempo other)
        {
            return (other.DataInizio <= this.DataInizio && this.DataInizio < other.DataFine) ||
                   (other.DataInizio < this.DataFine && this.DataFine <= other.DataFine) ||
                   (this.DataInizio < other.DataInizio && other.DataFine < this.DataFine);
        }

        public bool Prima(PeriodoTempo other)
        {
            return this.DataFine < other.DataInizio;
        }

        public bool Dopo(PeriodoTempo other)
        {
            return this.DataInizio > other.DataFine;
        }

        public static bool operator <(PeriodoTempo first, PeriodoTempo second)
        {
            return first.Prima(second);
        }

        public static bool operator >(PeriodoTempo first, PeriodoTempo second)
        {
            return first.Dopo(second);
        }

        public static System.Collections.Generic.IEnumerable<DateTime> DaysSequence(PeriodoTempo timePeriod)
        {
            for (DateTime day = timePeriod.DataInizio.Date; day < timePeriod.DataFine; day = day.AddDays(1))
            {
                yield return day;
            }
        }

    }
}
