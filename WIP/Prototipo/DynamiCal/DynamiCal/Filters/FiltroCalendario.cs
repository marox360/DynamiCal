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
    public class FiltroCalendario : Filtro
    {
        private readonly IEnumerable<Calendario> _calendari;

        public FiltroCalendario(IFiltro filtro, Calendario calendario) : this(filtro, new[] { calendario }) { }

        public FiltroCalendario(IFiltro filtro, IEnumerable<Calendario> calendari) : base(filtro)
        {
            #region Precondizioni
            Debug.Assert(calendari != null, "Calendari is null");
            #endregion

            _calendari = calendari;
        }

        public override IEnumerable<Evento> FiltraEventi()
        {
            return Component.FiltraEventi().Where(evento => _calendari.Where(calendario => calendario.Eventi.Contains(evento)).Count() != 0);
        }
    }
}
