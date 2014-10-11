using DynamiCal.Model;
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
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;

        public FiltroTemporale(IFiltro filtro, DateTime date) : this(filtro, date.Date, date.AddDays(1).Date) { }

        public FiltroTemporale(IFiltro filtro, DateTime startDate, DateTime endDate) : base(filtro)
        {
            #region Precondizioni
            Debug.Assert(startDate != null, "StartDate is null");
            Debug.Assert(endDate != null, "EndDate is null");
            #endregion

            if (startDate < endDate)
            {
                _startDate = startDate;
                _endDate = endDate;
            }
            else
            {
                _startDate = endDate;
                _endDate = startDate;
            }

        }

        public override IEnumerable<Evento> FiltraEventi()
        {
            return null;
        }
    }
}
