using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation.TreeView
{
    class CalendarTreeView : System.Windows.Forms.TreeView
    {
        public IEnumerable<Calendario> CheckedCalendars
        {
            get
            {
                return this.Nodes.Cast<TreeNode>()
                    .SelectMany(node => node.Nodes.Cast<TreeNode>())
                    .Where(node => node.Checked && node is CalendarTreeNode)
                    .Select(node => (node as CalendarTreeNode).Calendario);
            }
        }

        protected override void OnDrawNode(System.Windows.Forms.DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = false;
            e.Node.BackColor = Color.White;
            e.Node.ForeColor = Color.Black;

            if (e.Node is CalendarTreeNode)
            {
                (e.Node as CalendarTreeNode).DrawNode(e.Graphics, this.Font, 14, 6);
            }
            else
            {
                Rectangle bounds = e.Node.Bounds;
                bounds.X = 20;
                bounds.Width += 10;

                using (SolidBrush brush = new SolidBrush(e.Node.BackColor))
                {
                    e.Graphics.FillRectangle(brush, bounds);
                }

                TextRenderer.DrawText(e.Graphics, e.Node.Text, new Font(this.Font, FontStyle.Bold), bounds, e.Node.ForeColor, e.Node.BackColor);
            }
            
            base.OnDrawNode(e);
        }

        protected override void OnNodeMouseDoubleClick(TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is CalendarTreeNode && e.Button == MouseButtons.Left)
            {
                e.Node.Checked = !e.Node.Checked;
            }

            base.OnNodeMouseDoubleClick(e);
        }

        public CalendarTreeView() : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Calendari");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Calendari Condivisi");
            this.SuspendLayout();
            // 
            // CalendarTreeView
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.FullRowSelect = true;
            treeNode1.BackColor = System.Drawing.Color.White;
            treeNode1.ForeColor = System.Drawing.Color.Black;
            treeNode1.Name = "LocalCalendars";
            treeNode1.Text = "Calendari";
            treeNode2.BackColor = System.Drawing.Color.White;
            treeNode2.ForeColor = System.Drawing.Color.Black;
            treeNode2.Name = "SharedCalendars";
            treeNode2.Text = "Calendari Condivisi";
            this.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.ShowLines = false;
            this.ShowPlusMinus = false;
            this.ResumeLayout(false);

        }
    }
}
