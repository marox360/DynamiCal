﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Week(Calendar calendar, DateTime day)
        {
            int dayOfWeek = (int)(day.DayOfWeek + 6) % 7;
            day = calendar.AddDays(day, -1 * dayOfWeek);

            _days = new String[7];
            for (int i = 0; i < _days.Length; i++)
            {
                _days[i] = day.Day.ToString();
                day = calendar.AddDays(day, 1);
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
            source.Add(new Week(calendar, firstDay));
            source.Add(new Week(calendar, calendar.AddWeeks(firstDay, 1)));
            source.Add(new Week(calendar, calendar.AddWeeks(firstDay, 2)));
            source.Add(new Week(calendar, calendar.AddWeeks(firstDay, 3)));
            source.Add(new Week(calendar, calendar.AddWeeks(firstDay, 4)));
            source.Add(new Week(calendar, calendar.AddWeeks(firstDay, 5)));
        }
    }
}
