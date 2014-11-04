using DynamiCal.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.View.DataGridView.BindingSources
{
    internal class CalendarDay
    {
        private readonly DateTime _day;
        private readonly bool _todayWeek;
        private readonly int _weekIndex;
        private readonly int _numberOfEvents;

        public CalendarDay(DateTime day, bool todayWeek = false, int weekIndex = -1, int numberOfEvents = 0)
        {
            #region Precondizioni
            Debug.Assert(day != null, "Day is null");
            #endregion

            _weekIndex = weekIndex;
            _todayWeek = todayWeek;
            _day = day.Date;
            _numberOfEvents = numberOfEvents;
        }

        public DateTime Date
        {
            get
            {
                return _day;
            }
        }

        public bool IsTodayWeek()
        {
            return _todayWeek;
        }

        public int NumberOfEvents
        {
            get
            {
                return _numberOfEvents;
            }
        }

        public string Description
        {
            get
            {
                DateTimeFormatInfo dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
                string description = _day.Day.ToString();
                
                if (_todayWeek && _weekIndex != 0)
                {
                    description = dateTimeFormat.GetAbbreviatedDayName(_day.DayOfWeek) + " " + description;
                }

                if (_day.Day == 1)
                {
                    description += " " + (_todayWeek && _weekIndex != 0 ? dateTimeFormat.GetAbbreviatedMonthName(_day.Month) : dateTimeFormat.GetMonthName(_day.Month));
                }

                return description;
            }
        }
    }

    internal class CalendarWeek
    {
        private readonly CalendarDay[] _days;

        public CalendarWeek(Calendar calendar, DateTime day, int weekIndex, IFiltro filtro = null)
        {
            #region Precondizioni
            Debug.Assert(day != null, "Day is null");
            Debug.Assert(calendar != null, "Calendar is null");
            #endregion

            DateTimeFormatInfo dateFormatInfo = CultureInfo.CurrentCulture.DateTimeFormat;
            int dayOfWeek = (int)(day.DayOfWeek + 6) % 7;
            day = calendar.AddDays(day, -1 * dayOfWeek);
            bool isTodayWeek = calendar.GetWeekOfYear(day, dateFormatInfo.CalendarWeekRule, dateFormatInfo.FirstDayOfWeek) == calendar.GetWeekOfYear(DateTime.Today, dateFormatInfo.CalendarWeekRule, dateFormatInfo.FirstDayOfWeek) && day.Year == DateTime.Today.Year;

            _days = new CalendarDay[7];
            for (int i = 0; i < _days.Length; i++)
            {
                int numberOfEvents = 0;
                if (filtro != null)
                {
                    numberOfEvents = FiltroFactory.FiltraPerData(filtro, day).FiltraEventi().Count();
                }

                _days[i] = new CalendarDay(day, isTodayWeek, weekIndex, numberOfEvents);
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

    internal class MonthlySource
    {
        public static void FillSource(BindingSource source, DateTime date, IFiltro filtro = null) {
            MonthlySource.FillSource(source, date.Month, date.Year, filtro);
        }

        public static void FillSource(BindingSource source, int month, int year, IFiltro filtro = null)
        {
            Calendar calendar = new GregorianCalendar();
            DateTime firstDay = calendar.ToDateTime(year, month, 1, 0, 0, 0, 0);
            if (firstDay.DayOfWeek == DayOfWeek.Monday)
            {
                firstDay = calendar.AddWeeks(firstDay, -1);
            }

            source.SuspendBinding();
            source.Clear();
            source.Add(new CalendarWeek(calendar, firstDay, 0, filtro));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 1), 1, filtro));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 2), 2, filtro));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 3), 3, filtro));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 4), 4, filtro));
            source.Add(new CalendarWeek(calendar, calendar.AddWeeks(firstDay, 5), 5, filtro));
            source.ResumeBinding();
        }
    }
}
