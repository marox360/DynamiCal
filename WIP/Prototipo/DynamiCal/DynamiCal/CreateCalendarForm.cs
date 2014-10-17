using DynamiCal.Model;
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

namespace DynamiCal
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
            this.createButton.Enabled = !String.IsNullOrWhiteSpace((sender as TextBox).Text);
            if (this.createButton.Enabled)
            {
                Calendario calendar = new CalendarioLocale((sender as TextBox).Text.Trim());
                this.createButton.Enabled = !Agenda.Instance.Calendari.Contains(calendar);
            }
        }

        private Calendario GetCalendario()
        {
            if (this.friendsCheckedListBox.CheckedItems.Count == 0)
            {
                return new CalendarioLocale(this.nameTextBox.Text);
            }
            else
            {
                List<Amico> friends = new List<Amico>();
                foreach (Amico friend in this.friendsCheckedListBox.CheckedItems)
                {
                    friends.Add(friend);
                }
                return new CalendarioCondiviso(this.nameTextBox.Text, friends);
            }
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
