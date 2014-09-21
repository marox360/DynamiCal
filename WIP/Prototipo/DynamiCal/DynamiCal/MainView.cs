using DynamiCal.DataGridBindingSources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            calendarGridView.RowTemplate.Height = (calendarGridView.Height - calendarGridView.ColumnHeadersHeight) / 5;
            weekBindingSource.Add(new Week(1, 2014));
            weekBindingSource.Add(new Week(2, 2014));
            weekBindingSource.Add(new Week(3, 2014));
            weekBindingSource.Add(new Week(4, 2014));
            weekBindingSource.Add(new Week(5, 2014));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calendarGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calendarGridView_Resize(object sender, EventArgs e)
        {
            calendarGridView.RowTemplate.Height = (calendarGridView.Height - calendarGridView.ColumnHeadersHeight) / 5;
            foreach (DataGridViewRow row in calendarGridView.Rows)
            {
                row.Height = calendarGridView.RowTemplate.Height;
            }
        }
    }
}
