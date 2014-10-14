using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    class FiltroFactory
    {
        public static Filtro FiltraPerCalendario(IFiltro filtro, Calendario calendario)
        {
            return new FiltroCalendario(filtro, calendario);
        }

        public static Filtro FiltraPerCalendari(IFiltro filtro, IEnumerable<Calendario> calendari)
        {
            return new FiltroCalendario(filtro, calendari);
        }
        public static Filtro FiltraPerModello(IFiltro filtro, ModelloEvento modello)
        {
            return new FiltroModello(filtro, modello);
        }

        public static Filtro FiltraPerModelli(IFiltro filtro, IEnumerable<ModelloEvento> modelli)
        {
            return new FiltroModello(filtro, modelli);
        }

        public static Filtro FiltraPerData(IFiltro filtro, DateTime data)
        {
            return new FiltroTemporale(filtro, data);
        }

        public static Filtro FiltraPerPeriodo(IFiltro filtro, DateTime dataIniziale, DateTime dataFinale)
        {
            return new FiltroTemporale(filtro, dataIniziale, dataFinale);
        }

        public static Filtro FiltraPerTesto(IFiltro filtro, string testo)
        {
            return new FiltroRicerca(filtro, testo);
        }
    }
}
