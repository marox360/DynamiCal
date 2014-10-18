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
using DynamiCal.Time;

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

            this.dateLabel.Text = String.Format("{0:dddd dd MMMM yyyy}", evento.Periodo.StartDate);

            if (evento.Periodo.AllDayLong)
            {
                this.timeLabel.Text = "tutto il giorno";
            }
            else
            {
                this.timeLabel.Text = String.Format("dalle {0:HH:mm}", evento.Periodo.StartDate);
                if (evento.Periodo.StartDate.IsSameDayOf(evento.Periodo.EndDate))
                {
                    this.timeLabel.Text += String.Format(" alle {0:HH:mm}", evento.Periodo.EndDate);
                }
                else
                {
                    this.timeLabel.Text += String.Format(" alle {0:HH:mm} del {0:dd MMMM yyyy}", evento.Periodo.EndDate);
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
