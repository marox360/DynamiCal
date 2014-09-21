using DynamiCal.DataGridBindingSources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            calendarGridView.RowTemplate.Height = (calendarGridView.Height - calendarGridView.ColumnHeadersHeight) / 6;
            SetCurrentMonth(DateTime.Today);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calendarGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calendarGridView_Resize(object sender, EventArgs e)
        {
            calendarGridView.RowTemplate.Height = (calendarGridView.Height - calendarGridView.ColumnHeadersHeight) / 6;
            foreach (DataGridViewRow row in calendarGridView.Rows)
            {
                row.Height = calendarGridView.RowTemplate.Height;
            }
        }

        private void datePicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            SetCurrentMonth(e.Start);
        }

        private void SetCurrentMonth(DateTime date)
        {
            DateTimeFormatInfo dateTimeFormatInfo = CultureInfo.CurrentCulture.DateTimeFormat;
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            displayedMonth.Text = textInfo.ToTitleCase(dateTimeFormatInfo.GetMonthName(date.Month)) + " " + date.Year;

            MonthlySource.FillSource(weekBindingSource, date);
        }

        private void SelectDay(DateTime date)
        {

        }
    }
}
