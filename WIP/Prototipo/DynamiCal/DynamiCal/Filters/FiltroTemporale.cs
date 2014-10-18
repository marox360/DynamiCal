using DynamiCal.Model;
using DynamiCal.Time;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    class FiltroTemporale : Filtro
    {
        private readonly TimePeriod _timePeriod;

        public FiltroTemporale(IFiltro filtro, DateTime date) : this(filtro, date.Date, date.EndOfTheDay()) { }

        public FiltroTemporale(IFiltro filtro, DateTime startDate, DateTime endDate) : base(filtro)
        {
            #region Precondizioni
            Debug.Assert(startDate != null, "StartDate is null");
            Debug.Assert(endDate != null, "EndDate is null");
            #endregion

            if (startDate < endDate)
            {
                _timePeriod = new TimePeriod(startDate, endDate);
            }
            else
            {
                _timePeriod = new TimePeriod(endDate, startDate);
            }
        }

        public override IEnumerable<Evento> FiltraEventi()
        {
            return Component.FiltraEventi().Where(evento =>
                evento.Periodo.IntersectWith(_timePeriod)||
                evento.Periodicita.TestaPeriodo(evento.Periodo, _timePeriod));
        }
    }
}
