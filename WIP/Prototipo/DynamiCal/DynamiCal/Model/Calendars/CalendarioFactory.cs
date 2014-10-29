using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model.Calendars
{
    public class CalendarioFactory
    {
        public static Calendario CreaCalendario(string nome, IEnumerable<Amico> amici)
        {
            if (amici == null || !amici.Any())
            {
                return new CalendarioLocale(nome);
            }
            else
            {
                return new CalendarioCondiviso(nome, amici);
            }
        }
    }
}
