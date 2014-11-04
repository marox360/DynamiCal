using DynamiCal.Model;
using DynamiCal.Model.Calendars;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    public class CriterioFiltraggio : IFiltro
    {
        private readonly IEnumerable<Calendario> _calendari;

        public CriterioFiltraggio(IEnumerable<Calendario> calendari)
        {
            #region Precondizioni
            Debug.Assert(calendari != null, "Calendari is null");
            #endregion

            _calendari = calendari;
        }

        public IEnumerable<Evento> FiltraEventi()
        {
            return _calendari.SelectMany(calendario => calendario.Eventi);
        }
    }
}
