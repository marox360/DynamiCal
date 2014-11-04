using DynamiCal.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation
{
    public class FiltraggioPresenter<T> where T : Control
    {
        private readonly T _control;
        private readonly IFiltraggio _filtraggio;

        public FiltraggioPresenter(T control, IFiltraggio filtraggio)
        {
            #region Precondizioni
            Debug.Assert(control != null, "Control is null");
            Debug.Assert(filtraggio != null, "Filtraggio is null");
            #endregion

            _control = control;
            _filtraggio = filtraggio;

            _filtraggio.FilterChanged += FilterChanged;

            this.InitializeControl();
        }

        public T Control
        {
            get
            {
                return _control;
            }
        }

        public IFiltraggio Filtraggio
        {
            get
            {
                return _filtraggio;
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            this.RefreshControl();
        }

        protected virtual void InitializeControl() { }

        protected virtual void RefreshControl() { }

    }
}
