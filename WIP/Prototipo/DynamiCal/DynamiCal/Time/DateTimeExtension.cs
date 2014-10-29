using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Time
{
    internal static class DateTimeExtension
    {
        public static bool IsWeekendDay(this DateTime date)
        {
            return date != null && (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }

        public static bool IsSameDayOf(this DateTime thisDate, DateTime date)
        {
            return date != null && DateTime.Equals(thisDate.Date, date.Date);
        }

        public static bool IsToday(this DateTime date)
        {
            return date.IsSameDayOf(DateTime.Today);
        }

        public static DateTime EndOfTheDay(this DateTime date)
        {
            return date.Date.AddDays(+1).AddSeconds(-1);
        }

        public static DateTime DateWithTime(this DateTime date, DateTime otherDate)
        {
            return new DateTime(date.Year, date.Month, date.Day, otherDate.Hour, otherDate.Minute, otherDate.Second, otherDate.Kind);
        }
    }
}
