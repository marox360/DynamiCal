using DynamiCal.Model;
using DynamiCal.Model.Calendars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Forms
{
    public partial class CreateCalendarForm : Form
    {
        public CreateCalendarForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Agenda.Instance.AggiungiCalendario(this.GetCalendario());

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text.Trim();
            this.createButton.Enabled = !Agenda.Instance.Calendari.Where(calendar => calendar.Nome == text).Any();
        }

        private Calendario GetCalendario()
        {
            return CalendarioFactory.CreaCalendario(this.nameTextBox.Text, this.friendsCheckedListBox.CheckedItems.Cast<Amico>());
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.addButton.Enabled = Regex.IsMatch(this.emailTextBox.Text, "^.+@.+\\..{2,}$");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Amico friend = new Amico(this.emailTextBox.Text);
            this.friendsCheckedListBox.Items.Add(friend);
            this.friendsCheckedListBox.SetItemChecked(this.friendsCheckedListBox.Items.IndexOf(friend), true);
            
            this.emailTextBox.Text = "";
        }
    }
}
