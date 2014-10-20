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
        private DateTime _overrideDate = default(DateTime);
        private bool _needRefresh = false;

        public EventPanel()
        {
            InitializeComponent();
        }

        public DateTime OverrideDate
        {
            get
            {
                return _overrideDate;
            }
            set
            {
                _overrideDate = value;
                _needRefresh = true;
            }
        }

        internal void RefreshEvent(Evento evento)
        {
            if (_needRefresh)
            {
                this.LoadEvent(evento);
            }
        }

        internal void LoadEvent(Evento evento)
        {
            if (evento == null)
            {
                return;
            }

            _needRefresh = false;

            this.nameLabel.Text = evento.Nome;
            this.toolTip.SetToolTip(this.nameLabel, this.nameLabel.Text);

            this.locationLabel.Text = evento.Luogo == null ? "" : evento.Luogo;
            this.toolTip.SetToolTip(this.locationLabel, this.locationLabel.Text);

            TimePeriod periodo;
            if (this.OverrideDate == default(DateTime))
            {
                periodo = evento.Periodo;
            }
            else
            {
                DateTime overrideDate = this.OverrideDate.DateWithTime(evento.Periodo.StartDate);
                int numberOfRepetitions = evento.Periodicita.NumberOfRepetitions(evento.Periodo, overrideDate);

                if (numberOfRepetitions != -1)
                {
                    switch (evento.Periodicita.Ripetizione)
                    {
                        case Periodicita.Frequenza.Giornaliera:
                            overrideDate = evento.Periodo.StartDate.AddDays(evento.Periodicita.Valore * numberOfRepetitions);
                            break;

                        case Periodicita.Frequenza.Settimanale:
                            overrideDate = evento.Periodo.StartDate.AddDays(7 * evento.Periodicita.Valore * numberOfRepetitions);
                            break;

                        case Periodicita.Frequenza.Mensile:
                            overrideDate = evento.Periodo.StartDate.AddMonths(evento.Periodicita.Valore * numberOfRepetitions);
                            break;

                        case Periodicita.Frequenza.Annuale:
                            overrideDate = evento.Periodo.StartDate.AddYears(evento.Periodicita.Valore * numberOfRepetitions);
                            break;
                    }
                }

                periodo = new TimePeriod(overrideDate, evento.Periodo.Duration);
            }

            this.dateLabel.Text = String.Format("{0:dddd dd MMMM yyyy}", periodo.StartDate);

            if (periodo.AllDayLong)
            {
                this.timeLabel.Text = "tutto il giorno";
            }
            else
            {
                this.timeLabel.Text = String.Format("dalle {0:HH:mm}", periodo.StartDate);
                if (periodo.StartDate.IsSameDayOf(periodo.EndDate))
                {
                    this.timeLabel.Text += String.Format(" alle {0:HH:mm}", periodo.EndDate);
                }
                else
                {
                    this.timeLabel.Text += String.Format(" alle {0:HH:mm} del {0:dd MMMM yyyy}", periodo.EndDate);
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
