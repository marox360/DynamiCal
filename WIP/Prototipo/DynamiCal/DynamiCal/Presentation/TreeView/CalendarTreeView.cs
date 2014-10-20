using DynamiCal.Model.Calendars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation.TreeView
{
    class CalendarTreeView : System.Windows.Forms.TreeView
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TreeNode LocalCalendarsNode
        {
            get
            {
                return this.Nodes["LocalCalendars"];
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TreeNode SharedCalendarsNode
        {
            get
            {
                return this.Nodes["SharedCalendars"];
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        // Questo corregge un bug con il designer di Visual Studio
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new TreeNodeCollection Nodes { get { return base.Nodes; } }

        protected override void OnDrawNode(System.Windows.Forms.DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = false;
            e.Node.BackColor = Color.White;
            e.Node.ForeColor = Color.Black;

            if (e.Node is CalendarTreeNode)
            {
                this.DrawCalendarNode(e.Graphics, e.Node, (e.Node as CalendarTreeNode).CalendarColor, 0, 6);
            }
            else
            {
                Rectangle bounds = e.Node.Bounds;
                bounds.X = 6;
                bounds.Width += 10;

                using (SolidBrush brush = new SolidBrush(e.Node.BackColor))
                {
                    e.Graphics.FillRectangle(brush, bounds);
                }

                TextRenderer.DrawText(e.Graphics, e.Node.Text, new Font(this.Font, FontStyle.Bold), bounds, e.Node.ForeColor, e.Node.BackColor);
            }
            
            base.OnDrawNode(e);
        }

        private void DrawCalendarNode(Graphics graphics, TreeNode node, Color circleColor, int textOffset, int checkboxRadius)
        {
            Rectangle bounds = node.Bounds;
            bounds.Width += 20;

            using (Brush brush = new SolidBrush(node.BackColor))
            {
                graphics.FillRectangle(brush, bounds);
            }

            using (Brush brush = new SolidBrush(circleColor))
            {
                Rectangle circleBounds = new Rectangle(bounds.X + textOffset - checkboxRadius, bounds.Y + bounds.Height / 2 - checkboxRadius, checkboxRadius * 2, checkboxRadius * 2);
                SmoothingMode smoothingMode = graphics.SmoothingMode;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.FillEllipse(brush, circleBounds);
                graphics.SmoothingMode = smoothingMode;

                if (node.Checked)
                {
                    circleBounds.Offset(textOffset + checkboxRadius / 4, 0);
                    TextRenderer.DrawText(graphics, "✔", new Font(this.Font.FontFamily, checkboxRadius), circleBounds, Color.White, Color.Transparent);
                }
            }

            bounds.Offset(textOffset, 0);
            TextFormatFlags flags = TextFormatFlags.Default | TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(graphics, node.Text, this.Font, bounds, node.ForeColor, node.BackColor, flags);
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
