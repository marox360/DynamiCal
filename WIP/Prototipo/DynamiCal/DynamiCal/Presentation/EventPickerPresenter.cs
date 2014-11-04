using DynamiCal.Filters;
using DynamiCal.Model;
using DynamiCal.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Presentation
{
    public class EventPickerPresenter : FiltraggioPresenter<EventPickerControl>
    {
        public EventPickerPresenter(EventPickerControl eventPicker, IFiltraggio filtraggio) : base(eventPicker, filtraggio)
        {
            eventPicker.EventList.SelectedValueChanged += eventList_SelectedValueChanged;
            eventPicker.EventList.BindingSource.ListChanged += bindingSource_ListChanged;
            filtraggio.FilterChanged += filtraggio_FilterChanged;
        }

        protected override void InitializeControl()
        {
            base.InitializeControl();

            foreach (Evento evento in this.Filtraggio.Eventi())
            {
                this.Control.EventList.BindingSource.Add(evento);
            }
            this.Control.EventPanel.LoadEvent((Evento)this.Control.EventList.SelectedValue);
        }

        protected override void RefreshControl()
        {
            base.RefreshControl();

            if (this.Control.EventList.SelectedValue != null && this.Control.EventList.SelectedValue is Evento)
            {
                this.Control.EventPanel.RefreshEvent(this.Control.EventList.SelectedValue as Evento);
            }
        }

        private void filtraggio_FilterChanged(object sender, EventArgs e)
        {
            IEnumerable<Evento> eventi = this.Filtraggio.Eventi();
            if (!this.Control.EventList.BindingSource.List.Cast<Evento>().SequenceEqual(eventi))
            {
                this.Control.EventList.BindingSource.Clear();
                foreach (Evento evento in eventi)
                {
                    this.Control.EventList.BindingSource.Add(evento);
                }
            }
            else
            {
                this.RefreshControl();
            }
        }

        private void eventList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.Control.EventList.SelectedValue != null && this.Control.EventList.SelectedValue is Evento)
            {
                this.Control.EventPanel.LoadEvent(this.Control.EventList.SelectedValue as Evento);
            }
        }

        private void bindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (this.Control.EventList.BindingSource.Cast<Evento>().Count() == 0)
            {
                this.Control.EventPanel.LoadEvent(null);
            }
        }
    }
}
