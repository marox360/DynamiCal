using DynamiCal.Filters;
using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.Presentation.ListBox
{
    class EventListBox : System.Windows.Forms.ListBox
    {
        private BindingSource eventoBindingSource;
        private System.ComponentModel.IContainer components;
        private IFiltro _eventFilter = null;

        public IFiltro EventFilter
        {
            set
            {
                _eventFilter = value;

                if (_eventFilter != null)
                {
                    IList<Evento> eventi = new List<Evento>(_eventFilter.FiltraEventi());
                    if (!this.eventoBindingSource.List.Cast<Evento>().SequenceEqual(eventi))
                    {
                        this.BeginUpdate();

                        this.eventoBindingSource.Clear();
                        foreach (Evento evento in eventi)
                        {
                            this.eventoBindingSource.Add(evento);
                        }

                        this.EndUpdate();
                    }
                }
            }
            get
            {
                return _eventFilter;
            }
        }

        public EventPanel EventPanel { get; set; }

        public BindingSource EventoBindingSource
        {
            get
            {
                return this.eventoBindingSource;
            }
        }

        protected override void OnSelectedValueChanged(EventArgs e)
        {
            if (this.EventPanel != null && this.SelectedValue != null && this.SelectedValue is Evento)
            {
                this.EventPanel.LoadEvent(this.SelectedValue as Evento);
            }

             base.OnSelectedValueChanged(e);
        }

        private void eventoBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (this.EventPanel != null)
            {
                this.EventPanel.Visible = this.Items.Count > 0;
            }
        }

        public EventListBox() : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataSource = typeof(DynamiCal.Model.Evento);
            this.eventoBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.eventoBindingSource_ListChanged);
            // 
            // EventListBox
            // 
            this.DataSource = this.eventoBindingSource;
            this.DisplayMember = "Nome";
            this.Size = new System.Drawing.Size(120, 95);
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

    }
}
