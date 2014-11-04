using DynamiCal.Filters;
using DynamiCal.Model;
using DynamiCal.Model.Calendars;
using DynamiCal.View.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation
{
    public class CalendarTreeViewPresenter : FiltroPresenter<CalendarTreeView>
    {

        public CalendarTreeViewPresenter(CalendarTreeView calendarTreeView) : base(calendarTreeView)
        {
            calendarTreeView.AfterCheck += TreeView_AfterCheck;
            Agenda.Instance.CalendarsChanged += CalendarsChanged;
        }

        protected override void InitializeControl()
        {
            base.InitializeControl();

            this.Control.BeginUpdate();
            foreach (Calendario calendario in Agenda.Instance.Calendari)
            {
                CalendarTreeNode treeNode = new CalendarTreeNode(calendario);
                if (calendario is CalendarioLocale)
                {
                    this.Control.LocalCalendarsNode.Nodes.Add(treeNode);
                }
                else if (calendario is CalendarioCondiviso)
                {
                    this.Control.SharedCalendarsNode.Nodes.Add(treeNode);
                }
            }
            this.Control.EndUpdate();
            this.Control.ExpandAll();
        }

        public override IFiltro Filter(IFiltro filtro)
        {
            return FiltroFactory.FiltraPerCalendari(filtro, this.CheckedCalendars());
        }

        private IEnumerable<Calendario> CheckedCalendars()
        {
            return this.Control.Nodes.Cast<TreeNode>()
                .SelectMany(node => node.Nodes.Cast<TreeNode>())
                .Where(node => node.Checked && node is CalendarTreeNode)
                .Select(node => (node as CalendarTreeNode).Calendario);
        }

        private void CalendarsChanged(object sender, AgendaCollectionEventArgs e)
        {
            TreeNode treeNode = null;
            if (e.Item is CalendarioLocale)
            {
                treeNode = this.Control.LocalCalendarsNode;
            }
            else if (e.Item is CalendarioCondiviso)
            {
                treeNode = this.Control.SharedCalendarsNode;
            }

            if (treeNode == null)
            {
                return;
            }

            switch (e.Action)
            {
                case AgendaCollectionEventArgs.EditAction.AddItem:
                    treeNode.Nodes.Add(new CalendarTreeNode(e.Item as Calendario));
                    treeNode.Expand();
                    break;

                case AgendaCollectionEventArgs.EditAction.RemoveItem:
                    treeNode.Nodes.RemoveByKey((e.Item as Calendario).Nome);
                    break;
            }

            this.Control.Sort();
            this.OnFilterChanged();
        }

        private void TreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            this.OnFilterChanged();
        }

    }
}
