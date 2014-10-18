using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Time
{
    struct TimePeriod
    {
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;
        private readonly TimeSpan _duration;

        public TimePeriod(TimeSpan duration, DateTime endDate) : this(endDate - duration, endDate, duration) { }
        public TimePeriod(DateTime startDate, TimeSpan duration) : this(startDate, startDate + duration, duration) { }
        public TimePeriod(DateTime startDate, DateTime endDate) : this(startDate, endDate, endDate - startDate) { }

        private TimePeriod(DateTime startDate, DateTime endDate, TimeSpan duration)
        {
            #region Precondizioni
            Debug.Assert(endDate > startDate, "EndDate must be > of startDate");
            #endregion

            _startDate = startDate;
            _endDate = endDate;
            _duration = duration;
        }

        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return _duration;
            }
        }

        public bool AllDayLong
        {
            get
            {
                return _startDate == _startDate.Date && _startDate.AddDays(1) == _endDate;
            }
        }

        public bool IntersectWith(TimePeriod other)
        {
            return (other.StartDate <= this.StartDate && this.StartDate < other.EndDate) ||
                   (other.StartDate < this.EndDate && this.EndDate <= other.EndDate) ||
                   (this.StartDate < other.StartDate && other.EndDate < this.EndDate);
        }

        public bool Before(TimePeriod other)
        {
            return this.EndDate < other.StartDate;
        }

        public bool After(TimePeriod other)
        {
            return this.StartDate > other.EndDate;
        }

        public static bool operator <(TimePeriod first, TimePeriod second)
        {
            return first.Before(second);
        }

        public static bool operator >(TimePeriod first, TimePeriod second)
        {
            return first.After(second);
        }

        public static System.Collections.Generic.IEnumerable<DateTime> DaysSequence(TimePeriod timePeriod)
        {
            for (DateTime day = timePeriod.StartDate.Date; day < timePeriod.EndDate; day = day.AddDays(1))
            {
                yield return day;
            }
        }

    }
}
