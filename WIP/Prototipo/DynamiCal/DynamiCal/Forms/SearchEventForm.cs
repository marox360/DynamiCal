using DynamiCal.Filters;
using DynamiCal.Model;
using DynamiCal.Time;
using DynamiCal.Presentation.TreeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Forms
{
    public partial class SearchEventForm : Form
    {
        internal Evento SelectedEvent
        {
            get
            {
                if (this.eventListBox.SelectedValue != null && this.eventListBox.SelectedValue is Evento)
                {
                    return this.eventListBox.SelectedValue as Evento;
                }
                else
                {
                    return null;
                }
            }
        }

        private IFiltro CurrentFilter
        {
            get
            {
                CriterioDiFiltraggio criterioFiltraggio = new CriterioDiFiltraggio(Agenda.Instance.Calendari);

                IList<ModelloEvento> modelliEvento = new List<ModelloEvento>();
                foreach (ModelloEvento modelloEvento in this.eventModelListBox.CheckedItems)
                {
                    modelliEvento.Add(modelloEvento);
                }

                IFiltro filtroCalendari = FiltroFactory.FiltraPerCalendari(criterioFiltraggio, this.calendarTreeView.CheckedCalendars);
                IFiltro filtroModelli = FiltroFactory.FiltraPerModelli(filtroCalendari, modelliEvento);
                IFiltro filtroTesto = FiltroFactory.FiltraPerTesto(filtroModelli, this.searchBoxPanel.SearchText);

                IFiltro filtroData = null;
                switch (this.dateComboBox.SelectedIndex)
                {
                    case 1:
                        filtroData = FiltroFactory.FiltraPerData(filtroTesto, this.startDateTimePicker.Value);
                        break;

                    case 2:
                        filtroData = FiltroFactory.FiltraPerPeriodo(filtroTesto, this.startDateTimePicker.Value, this.endDateTimePicker.Value.EndOfTheDay());
                        break;

                    default:
                        return filtroTesto;
                }

                return filtroData;
            }
        }

        public SearchEventForm()
        {
            InitializeComponent();
        }

        private void SearchEventForm_Load(object sender, EventArgs e)
        {
            this.eventListBox.EventPanel = this.eventPanel;

            this.dateComboBox.SelectedIndex = 0;

            this.calendarTreeView.BeginUpdate();
            foreach (Calendario calendario in Agenda.Instance.Calendari)
            {
                CalendarTreeNode treeNode = new CalendarTreeNode(calendario);
                if (calendario is CalendarioLocale)
                {
                    this.calendarTreeView.LocalCalendarsNode.Nodes.Add(treeNode);
                }
                else if (calendario is CalendarioCondiviso)
                {
                    this.calendarTreeView.SharedCalendarsNode.Nodes.Add(treeNode);
                }
            }
            this.calendarTreeView.EndUpdate();
            this.calendarTreeView.ExpandAll();

            this.eventModelListBox.BeginUpdate();
            foreach (ModelloEvento modelloEvento in Agenda.Instance.ModelliEvento)
            {
                this.eventModelListBox.Items.Add(modelloEvento);
                this.eventModelListBox.SetItemChecked(this.eventModelListBox.Items.IndexOf(modelloEvento), true);
            }
            this.eventModelListBox.EndUpdate();
        }

        private void UpdateFilter(object sender, EventArgs e)
        {
            this.eventListBox.EventFilter = this.CurrentFilter;
        }
        private void UpdateFilter(object sender, TreeViewEventArgs e)
        {
            this.UpdateFilter(sender, (EventArgs)e);
        }

        private void eventModelListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => this.UpdateFilter(sender, e)));
        }

        private void showInCalendarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void eventListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.showInCalendarButton.Enabled = this.eventListBox.SelectedValue != null;
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.dateComboBox.SelectedIndex)
            {
                case 0:
                    this.startDateTimePicker.Enabled = false;
                    this.endDateTimePicker.Enabled = false;
                    break;

                case 1:
                    this.startDateTimePicker.Enabled = true;
                    this.endDateTimePicker.Enabled = false;
                    break;

                case 2:
                    this.endDateTimePicker.MinDate = this.startDateTimePicker.Value;
                    this.startDateTimePicker.Enabled = true;
                    this.endDateTimePicker.Enabled = true;
                    break;
            }
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!this.endDateTimePicker.Enabled)
            {
                this.endDateTimePicker.Value = this.startDateTimePicker.Value;
            }
            else if (this.endDateTimePicker.Value < this.startDateTimePicker.Value)
            {
                this.endDateTimePicker.Value = this.startDateTimePicker.Value.AddDays(1);
            }

            this.endDateTimePicker.MinDate = this.startDateTimePicker.Value;

            this.UpdateFilter(sender, e);
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.endDateTimePicker.Enabled)
            {
                this.UpdateFilter(sender, e);
            }
        }
    }
}
