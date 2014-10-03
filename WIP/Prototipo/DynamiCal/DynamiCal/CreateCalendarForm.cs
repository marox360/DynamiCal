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
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.createButton.Enabled = !String.IsNullOrWhiteSpace((sender as TextBox).Text);
        }
    }
}
