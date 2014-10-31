using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    public class FiltroModello : Filtro
    {
        private readonly IEnumerable<ModelloEvento> _modelli;

        public FiltroModello(IFiltro filtro, ModelloEvento modello) : this(filtro, new[] { modello }) { }

        public FiltroModello(IFiltro filtro, IEnumerable<ModelloEvento> modelli) : base(filtro)
        {
            #region Precondizioni
            Debug.Assert(modelli != null, "Modelli is null");
            #endregion

            _modelli = modelli;
        }

        protected override Func<Evento, bool> StrategiaFiltro()
        {
            return evento => _modelli.Contains(evento.Modello);
        }
    }
}
