using DynamiCal.Filters;
using DynamiCal.Model;
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

                List<ModelloEvento> modelliEvento = new List<ModelloEvento>();
                foreach (ModelloEvento modelloEvento in this.eventModelListBox.CheckedItems)
                {
                    modelliEvento.Add(modelloEvento);
                }

                Filtro filtroCalendari = FiltroFactory.FiltraPerCalendari(criterioFiltraggio, this.calendarTreeView.CheckedCalendars);
                Filtro filtroModelli = FiltroFactory.FiltraPerModelli(filtroCalendari, modelliEvento);
                Filtro filtroTesto = FiltroFactory.FiltraPerTesto(filtroModelli, this.searchBoxPanel.SearchText);

                return filtroTesto;
            }
        }

        public SearchEventForm()
        {
            InitializeComponent();
        }

        private void SearchEventForm_Load(object sender, EventArgs e)
        {
            this.eventListBox.EventPanel = this.eventPanel;

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

        private void cSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in this.calendarTreeView.Nodes.Cast<TreeNode>().SelectMany(node => node.Nodes.Cast<TreeNode>()))
            {
                node.Checked = true;
            }
        }

        private void cDeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in this.calendarTreeView.Nodes.Cast<TreeNode>().SelectMany(node => node.Nodes.Cast<TreeNode>()))
            {
                node.Checked = false;
            }
        }

        private void mSelectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.eventModelListBox.Items.Count; i++)
            {
                this.eventModelListBox.SetItemChecked(i, true);
            }
        }

        private void mDeselectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.eventModelListBox.Items.Count; i++)
            {
                this.eventModelListBox.SetItemChecked(i, false);
            }
        }

        private void showInCalendarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void eventListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.showInCalendarButton.Enabled = this.eventListBox.SelectedValue != null;
        }
    }
}
