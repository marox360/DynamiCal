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
    public partial class ManageCalendarForm : Form
    {
        private Calendario _calendario = null;

        public ManageCalendarForm()
        {
            InitializeComponent();
        }
        private Calendario GetCalendario()
        {
            return CalendarioFactory.CreaCalendario(this.nameTextBox.Text, this.friendsCheckedListBox.CheckedItems.Cast<Amico>());
        }

        internal void LoadCalendario(Calendario calendario)
        {
            _calendario = calendario;

            this.nameTextBox.Text = calendario.Nome;
            this.createButton.Text = "Modifica";

            if (calendario is CalendarioCondiviso)
            {
                foreach (Amico amico in (calendario as CalendarioCondiviso).Amici)
                {
                    this.friendsCheckedListBox.Items.Add(amico);
                    this.friendsCheckedListBox.SetItemChecked(this.friendsCheckedListBox.Items.IndexOf(amico), true);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Calendario calendario = this.GetCalendario();

            if (_calendario != null)
            {
                calendario.AggiungiEventi(_calendario.Eventi);
                Agenda.Instance.RimuoviCalendario(_calendario);
            }

            Agenda.Instance.AggiungiCalendario(calendario);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.nameTextBox.Text.Trim();
            this.createButton.Enabled = !Agenda.Instance.Calendari.Where(calendar => calendar.Nome == text).Any();
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

            this.friendsCheckedListBox_Click(this.friendsCheckedListBox, EventArgs.Empty);

            this.emailTextBox.Text = "";
        }

        private void friendsCheckedListBox_Click(object sender, EventArgs e)
        {
            if (_calendario != null)
            {
                IEnumerable<Amico> friends = (_calendario is CalendarioCondiviso) ? (_calendario as CalendarioCondiviso).Amici : new List<Amico>();
                if (!friends.SequenceEqual(this.friendsCheckedListBox.CheckedItems.Cast<Amico>()))
                {
                    this.createButton.Enabled = true;
                }
                else
                {
                    this.nameTextBox_TextChanged(this.nameTextBox, EventArgs.Empty);
                }
            }
        }

        private void friendsCheckedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.friendsCheckedListBox_Click(sender, EventArgs.Empty);
        }

    }
}
