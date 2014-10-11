using DynamiCal.Model;
using System;
using System.Collections.Generic;
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
        private readonly IFiltro _filtro;

        protected Filtro(IFiltro filtro)
        {
            _filtro = filtro;
        }

        public IFiltro Component
        {
            get
            {
                return _filtro;
            }
        }

        public abstract IEnumerable<Evento> FiltraEventi();
    }
}
