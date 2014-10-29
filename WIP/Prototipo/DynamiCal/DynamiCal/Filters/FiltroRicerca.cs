using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    public class FiltroRicerca : Filtro
    {
        private readonly string _text;

        public FiltroRicerca(IFiltro filtro, string text) : base(filtro)
        {
            #region Precondizioni
            Debug.Assert(text != null, "Text cannot be null or empty");
            #endregion

            _text = text;
        }

        public override IEnumerable<Evento> FiltraEventi()
        {
            return Component.FiltraEventi().Where(evento =>
                evento.Nome.IndexOf(_text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                evento.Descrizione.IndexOf(_text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                evento.Luogo.IndexOf(_text, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
