using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    class FiltroCalendario : Filtro
    {
        private readonly IList<Calendario> _calendari;

        public FiltroCalendario(IFiltro filtro, Calendario calendario) : this(filtro, new[] { calendario }) { }

        public FiltroCalendario(IFiltro filtro, IList<Calendario> calendari) : base(filtro)
        {
            #region Precondizioni
            Debug.Assert(calendari != null, "Calendari is null");
            #endregion

            _calendari = calendari;
        }

        public override IEnumerable<Evento> FiltraEventi()
        {
            return null;
        }
    }
}
