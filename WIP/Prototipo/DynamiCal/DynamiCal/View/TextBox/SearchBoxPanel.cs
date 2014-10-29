using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.View.TextBox
{
    public partial class SearchBoxPanel : UserControl
    {
        public event EventHandler SearchTextChanged;

        public SearchBoxPanel()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        public string SearchText
        {
            get
            {
                return this.searchBox.Text.Replace(this.searchBox.PlaceholderText, "");
            }
        }

        private void searchBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.pictureBox.Focus();
            }
        }

        protected virtual void OnSearchTextChanged(EventArgs e)
        {
            if (this.SearchTextChanged != null)
            {
                this.SearchTextChanged(this, e);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.OnSearchTextChanged(e);
        }
    }
}
