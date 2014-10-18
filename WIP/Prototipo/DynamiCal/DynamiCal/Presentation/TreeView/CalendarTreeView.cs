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
    }
}
