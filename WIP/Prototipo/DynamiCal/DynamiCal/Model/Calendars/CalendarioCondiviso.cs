using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model.Calendars
{
    public class CalendarioCondiviso : Calendario
    {
        private List<Amico> _amici;
    
        public CalendarioCondiviso(string nome, IEnumerable<Amico> amici) : base(nome)
        {
            #region Precondizioni
            Debug.Assert(amici != null && amici.Any(), "Amici cannot be null or empty");
            #endregion

            _amici = new List<Amico>(amici);
        }

        public IList<Amico> Amici
        {
            get
            {
                return _amici.AsReadOnly();
            }
        }
    }
}
