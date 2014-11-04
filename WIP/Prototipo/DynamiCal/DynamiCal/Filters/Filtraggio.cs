using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Filters
{
    public interface IFiltraggio
    {
        IFiltro Filtro { get; set; }

        IEnumerable<Evento> Eventi();

        event EventHandler FilterChanged;
    }

    public class Filtraggio : IFiltraggio
    {
        private IFiltro _filtro;
        private IEnumerable<Evento> _eventi;
        public event EventHandler FilterChanged;

        public Filtraggio(IFiltro filtro = null)
        {
            _filtro = filtro;
        }

        public IFiltro Filtro
        {
            get
            {
                return _filtro;
            }
            set
            {
                if (_filtro != value)
                {
                    _filtro = value;

                    this.Reset();
                }
            }
        }

        public IEnumerable<Evento> Eventi()
        {
            if (_eventi == null && _filtro != null)
            {
                _eventi = _filtro.FiltraEventi();
            }

            return _eventi ?? new List<Evento>();
        }

        public void Reset()
        {
            _eventi = null;
            this.OnFilterChanged();
        }

        private void OnFilterChanged()
        {
            if (this.FilterChanged != null)
            {
                this.FilterChanged(this, EventArgs.Empty);
            }
        }

    }
}
