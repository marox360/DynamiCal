using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    interface IFiltro
    {
        IEnumerable<Evento> FiltraEventi();
    }

    abstract class Filtro : IFiltro
    {
        private readonly IFiltro _component;

        protected Filtro(IFiltro filtro)
        {
            #region Precondizioni
            Debug.Assert(filtro != null, "Filtro cannot be null");
            #endregion

            _component = filtro;
        }

        public IFiltro Component
        {
            get
            {
                return _component;
            }
        }

        public abstract IEnumerable<Evento> FiltraEventi();
    }
}
