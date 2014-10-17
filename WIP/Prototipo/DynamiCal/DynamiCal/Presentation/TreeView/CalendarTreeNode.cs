using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation.TreeView
{
    class CalendarTreeNode : TreeNode
    {
        private readonly Color _calendarColor;
        private readonly Calendario _calendario;

        public CalendarTreeNode(Calendario calendario) : base(calendario.Nome)
        {
            _calendario = calendario;
            _calendarColor = Color.FromArgb(192, 85, 87);
            this.Name = calendario.Nome;
            this.Checked = true;
        }

        public Color CalendarColor
        {
            get
            {
                return _calendarColor;
            }
        }

        public Calendario Calendario
        {
            get
            {
                return _calendario;
            }
        }

        public void DrawNode(Graphics graphics, Font font, int textOffset, int checkboxRadius)
        {
            Rectangle bounds = this.Bounds;
            bounds.Width += 20;

            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                graphics.FillRectangle(brush, bounds);
            }

            using (SolidBrush brush = new SolidBrush(this.CalendarColor))
            {
                Rectangle circleBounds = new Rectangle(bounds.X + textOffset - checkboxRadius, bounds.Y + bounds.Height / 2 - checkboxRadius, checkboxRadius * 2, checkboxRadius * 2);
                SmoothingMode smoothingMode = graphics.SmoothingMode;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.FillEllipse(brush, circleBounds);
                graphics.SmoothingMode = smoothingMode;

                if (this.Checked)
                {
                    circleBounds.Offset(textOffset / 2 - checkboxRadius, 0);
                    TextRenderer.DrawText(graphics, "✔", new Font(font.FontFamily, checkboxRadius), circleBounds, Color.White, Color.Transparent);
                }
            }

            bounds.Offset(textOffset, 0);
            TextFormatFlags flags = TextFormatFlags.Default | TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(graphics, this.Text, font, bounds, this.ForeColor, this.BackColor, flags);
        }

    }
}
