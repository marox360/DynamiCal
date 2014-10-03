using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.DataGridView.BindingSources
{
    class CalendarDay
    {
        private DateTime _day;
        private Boolean _todayWeek;

        public CalendarDay(DateTime day) : this(day, false) { }
        public CalendarDay(DateTime day, Boolean todayWeek)
        {
            #region Precondizioni
            Debug.Assert(day != null, "Day is null");
            #endregion

            _todayWeek = todayWeek;
            _day = day;
        }

        public DateTime Date
        {
            get
            {
                return _day;
            }
        }

        public string Description
        {
            get
            {
                if (_todayWeek && _day.Day == 1)
                {
                    return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(_day.DayOfWeek) + " " + _day.Day.ToString() + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(_day.Month);
                }
                else if (_todayWeek)
                {
                    return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(_day.DayOfWeek) + " " + _day.Day.ToString();
                }
                else if (_day.Day == 1)
                {
                    return _day.Day.ToString() + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_day.Month);
                } 
                else
                {
                    return _day.Day.ToString();
                }
            }
        }

        public Boolean IsSameDayOf(DateTime day)
        {
            return day != null && DateTime.Equals(_day.Date, day.Date);
        }

        public Boolean IsWeekendDay()
        {
            return _day.DayOfWeek == DayOfWeek.Saturday || _day.DayOfWeek == DayOfWeek.Sunday;
        }

        public Boolean IsTodayWeek()
        {
            return _todayWeek;
        }
    }

    class CalendarWeek
    {
        private CalendarDay[] _days;

        public CalendarWeek(Calendar calendar, DateTime day)
        {
            #region Precondizioni
            Debug.Assert(day != null, "Day is null");
            Debug.Assert(calendar != null, "Calendar is null");
            #endregion

            int dayOfWeek = (int)(day.DayOfWeek + 6) % 7;
            day = calendar.AddDays(day, -1 * dayOfWeek);
            Boolean isTodayWeek = calendar.GetWeekOfYear(day, CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek) == calendar.GetWeekOfYear(DateTime.Today, CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);

            _days = new CalendarDay[7];
            for (int i = 0; i < _days.Length; i++)
            {
                _days[i] = new CalendarDay(day, isTodayWeek);
                day = calendar.AddDays(day, 1);
            }
        }

        public CalendarDay Lunedì
        {
            get
            {
                return _days[0];
            }
        }
        public CalendarDay Martedì
        {
            get
            {
                return _days[1];
            }
        }
        public CalendarDay Mercoledì
        {
            get
            {
                return _days[2];
            }
        }
        public CalendarDay Giovedì
        {
            get
            {
                return _days[3];
            }
        }
        public CalendarDay Venerdì
        {
            get
            {
                return _days[4];
            }
        }
        public CalendarDay Sabato
        {
            get
            {
                return _days[5];
            }
        }
        public CalendarDay Domenica
        {
            get
            {
                return _days[6];
            }
        }
    }

    class MonthlySource
    {
        public static void FillSource(BindingSource source, DateTime date) {
            MonthlySource.FillSource(source, date.Month, date.Year);
        }

        public static void FillSource(BindingSource source, int month, int year)
        {
            Calendar calendar = new GregorianCalendar();
            DateTime firstDay = calendar.ToDateTime(year, month, 1, 0, 0, 0, 0);
            if (firstDay.DayOfWeek == DayOfWeek.Monday)
            {
                firstDay = calendar.AddWeeks(firstDay, -1);
            }

            source.Clear();
            source.Add(new CalendarWeek(calendar, firstDay));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 1)));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 2)));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 3)));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 4)));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 5)));
        }
    }
}
