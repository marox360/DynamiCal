using DynamiCal.View.ListBox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.View
{
    public class EventPickerControl : Control
    {
        private readonly IShowEvento _eventPanel;
        private readonly IBindingSource _eventList;

        public EventPickerControl(IShowEvento eventPanel, IBindingSource eventList) : base()
        {
            #region Precondizioni
            Debug.Assert(eventPanel != null, "EventPanel is null");
            Debug.Assert(eventList != null, "EventList is null");
            #endregion

            _eventList = eventList;
            _eventPanel = eventPanel;
        }

        public IShowEvento EventPanel
        {
            get
            {
                return _eventPanel;
            }
        }

        public IBindingSource EventList
        {
            get
            {
                return _eventList;
            }
        }
    }
}
