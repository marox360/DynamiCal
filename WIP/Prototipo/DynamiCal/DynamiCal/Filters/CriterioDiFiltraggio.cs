using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    class CriterioDiFiltraggio : IFiltro
    {
        public CriterioDiFiltraggio(IList<Calendario> calendari)
        {
            #region Precondizioni
            Debug.Assert(calendari != null, "Calendari is null");
            #endregion

        }

        public IEnumerable<Evento> FiltraEventi()
        {
            return null;
        }
    }
}
