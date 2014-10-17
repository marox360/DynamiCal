using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamiCal.Model;
using DynamiCal.Extension;

namespace DynamiCal.Presentation
{
    public partial class EventPanel : UserControl
    {
        public EventPanel()
        {
            InitializeComponent();
        }

        internal void LoadEvent(Evento evento)
        {
            if (evento == null)
            {
                return;
            }

            this.nameLabel.Text = evento.Nome;
            this.toolTip.SetToolTip(this.nameLabel, this.nameLabel.Text);

            this.locationLabel.Text = evento.Luogo == null ? "" : evento.Luogo;
            this.toolTip.SetToolTip(this.locationLabel, this.locationLabel.Text);

            this.dateLabel.Text = String.Format("{0:dddd dd MMMM yyyy}", evento.Data);

            if (evento.Data == evento.Data.Date && evento.Durata == 60 * 24)
            {
                this.timeLabel.Text = "tutto il giorno";
            }
            else
            {
                DateTime endDate = evento.Data.AddMinutes(evento.Durata);
                this.timeLabel.Text = String.Format("dalle {0:HH:mm}", evento.Data);
                if (endDate.IsSameDayOf(evento.Data))
                {
                    this.timeLabel.Text += String.Format(" alle {0:HH:mm}", endDate);
                }
                else
                {
                    this.timeLabel.Text += String.Format(" alle {0:HH:mm} del {0:dd MMMM yyyy}", endDate);
                }
            }

            this.repeatLabel.Text = "ripeti: " + evento.Periodicita.ToString().ToLower();

            this.descriptionTextBox.Text = evento.Descrizione == null ? "" : evento.Descrizione;
            this.descriptionTextBox.ScrollBars = this.descriptionTextBox.Text.Length > 0 ? ScrollBars.Vertical : ScrollBars.None;

            this.entriesdataGridView.DataSource = evento.Voci;
        }

        private void entriesdataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                return;
            }

            e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            e.Paint(e.ClipBounds, (DataGridViewPaintParts.All & ~DataGridViewPaintParts.Background));
            e.Handled = true;
        }
    }
}
