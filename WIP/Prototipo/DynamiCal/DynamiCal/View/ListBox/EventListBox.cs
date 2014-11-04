using DynamiCal.Filters;
using DynamiCal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.View.ListBox
{
    public interface IBindingSource
    {
        BindingSource BindingSource { get; }

        object SelectedValue { get; set; }

        event EventHandler SelectedValueChanged;
    }

    public class EventListBox : System.Windows.Forms.ListBox, IBindingSource
    {
        private BindingSource eventoBindingSource;
        private System.ComponentModel.IContainer components;

        public BindingSource BindingSource
        {
            get
            {
                return this.eventoBindingSource;
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index != -1 && e.Index < this.Items.Count)
            {
                using (Brush brush = new SolidBrush(e.BackColor))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
                TextFormatFlags flags = TextFormatFlags.Default | TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(e.Graphics, this.GetItemText(this.Items[e.Index]), e.Font, e.Bounds, e.ForeColor, e.BackColor, flags);
            }

            base.OnDrawItem(e);
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
            // 
            // EventListBox
            // 
            this.DataSource = this.eventoBindingSource;
            this.DisplayMember = "Nome";
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Size = new System.Drawing.Size(120, 95);
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

    }
}
