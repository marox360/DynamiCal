﻿using DynamiCal.DataGridView.BindingSources;
using DynamiCal.Model;
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
    public partial class MainForm : Form
    {
        private Agenda _agenda;
        public MainForm()
        {
            InitializeComponent();

            calendarTreeView.ExpandAll();

            _agenda = new Agenda();
            _agenda.CalendarsChanged += CalendarsChanged;
            _agenda.AggiungiCalendario(new CalendarioLocale("Test Calendar"));
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            calendarGridView.RowTemplate.Height = (calendarGridView.Height - calendarGridView.ColumnHeadersHeight) / 6;
            ShowMonthOfDay(DateTime.Today);
        }

        private void ShowMonthOfDay(DateTime date)
        {
            displayedMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month) + " " + date.Year;

            MonthlySource.FillSource(weekBindingSource, date);
            SelectDay(date);
        }

        private void SelectDay(DateTime date)
        {
            foreach (DataGridViewRow row in calendarGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is CalendarDay && (cell.Value as CalendarDay).IsSameDayOf(date))
                    {
                        calendarGridView.CurrentCell = cell;
                        return;
                    }
                }
            }
        }

        private void CalendarsChanged(object sender, EventArgs e)
        {
            calendarTreeView.Nodes["LocalCalendars"].Nodes.Clear();
            calendarTreeView.Nodes["SharedCalendars"].Nodes.Clear();

            foreach (Calendario calendario in _agenda.Calendari)
            {
                TreeNode node = new TreeNode(calendario.Nome);
                if (calendario is CalendarioLocale)
                {
                    calendarTreeView.Nodes["LocalCalendars"].Nodes.Add(node);
                }
                else if (calendario is CalendarioCondiviso)
                {
                    calendarTreeView.Nodes["SharedCalendars"].Nodes.Add(node);
                }
            }
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
            ShowMonthOfDay(e.Start);
        }

        private void createCalendarMenuItem_Click(object sender, EventArgs e)
        {
            CreateCalendarForm createCalendarDialog = new CreateCalendarForm();

            if (createCalendarDialog.ShowDialog(this) == DialogResult.OK)
            {

            }

            createCalendarDialog.Dispose();
        }

        private void calendarGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell selectedCell = calendarGridView[e.ColumnIndex, e.RowIndex];
            if (selectedCell.Value is CalendarDay)
            {
                CalendarDay calendarDay = selectedCell.Value as CalendarDay;
                if (e.RowIndex == 0 && calendarDay.Date.Day > 7)
                {
                    ShowMonthOfDay(calendarDay.Date);
                }
                else if (e.RowIndex == 5 && calendarDay.Date.Day < 8)
                {
                    ShowMonthOfDay(calendarDay.Date);
                }
            }
        }
    }
}
