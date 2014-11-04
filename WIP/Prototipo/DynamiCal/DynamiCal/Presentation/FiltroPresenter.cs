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
    public interface IFiltroPresenter
    {
        event EventHandler FilterChanged;

        IFiltro Filter(IFiltro filtro);
    }

    public abstract class FiltroPresenter<T> : IFiltroPresenter where T : Control
    {
        private readonly T _control;
        public event EventHandler FilterChanged;

        public FiltroPresenter(T control)
        {
            #region Precondizioni
            Debug.Assert(control != null, "Control is null");
            #endregion

            _control = control;

            this.InitializeControl();
        }

        public T Control
        {
            get
            {
                return _control;
            }
        }

        public abstract IFiltro Filter(IFiltro filtro);

        protected virtual void InitializeControl() {}

        protected void OnFilterChanged()
        {
            if (this.FilterChanged != null)
            {
                this.FilterChanged(this, EventArgs.Empty);
            }
        }
    }
}
