using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    class FiltroRicerca : Filtro
    {
        private readonly string _text;

        public FiltroRicerca(IFiltro filtro, string text) : base(filtro)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrEmpty(text), "Text cannot be null or empty");
            #endregion

            _text = text;
        }

        public override IEnumerable<Evento> FiltraEventi()
        {
            return null;
        }
    }
}
