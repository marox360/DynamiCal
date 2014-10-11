using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    class FiltroModello : Filtro
    {
        private readonly IList<ModelloEvento> _modelli;

        public FiltroModello(IFiltro filtro, ModelloEvento modello) : this(filtro, new[] { modello }) { }

        public FiltroModello(IFiltro filtro, IList<ModelloEvento> modelli) : base(filtro)
        {
            #region Precondizioni
            Debug.Assert(modelli != null, "Modelli is null");
            #endregion

            _modelli = modelli;
        }

        public override IEnumerable<Evento> FiltraEventi()
        {
            return null;
        }
    }
}
