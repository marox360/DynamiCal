using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Extension
{
    public static class DateTimeExtension
    {
        public static bool IsWeekendDay(this DateTime date)
        {
            return date != null && (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }

        public static bool IsSameDayOf(this DateTime thisDate, DateTime date)
        {
            return date != null && DateTime.Equals(thisDate.Date, date.Date);
        }
    }
}
