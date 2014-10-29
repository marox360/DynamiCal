using DynamiCal.Model.Calendars;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.View.TreeView
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

    }
}
