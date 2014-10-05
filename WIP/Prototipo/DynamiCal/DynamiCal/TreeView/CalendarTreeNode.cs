using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.TreeView
{
    class CalendarTreeNode : TreeNode
    {
        private Color _calendarColor;

        public CalendarTreeNode(Calendario calendario) : base(calendario.Nome)
        {
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
    }
}
