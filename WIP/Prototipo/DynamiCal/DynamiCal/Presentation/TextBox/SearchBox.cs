﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Presentation.TextBox
{
    class SearchBox : System.Windows.Forms.TextBox
    {
        private Color _placeholderColor = Color.DarkGray;
        private Color _textColor = Color.Black;

        [DefaultValue("Cerca")]
        public String PlaceholderText { get; set; }

        [DefaultValue(typeof(Color), "DarkGray")]
        public Color PlaceholderColor
        {
            get
            {
                return _placeholderColor;
            }
            set
            {
                _placeholderColor = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Black")]
        public Color TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            if (this.Text == this.PlaceholderText)
            {
                this.Text = "";
            }

            this.ForeColor = this.TextColor;

            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.Text.Length == 0)
            {
                this.ForeColor = this.PlaceholderColor;
                this.Text = this.PlaceholderText;
            }

            base.OnLeave(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            this.ForeColor = this.PlaceholderColor;
            this.Text = this.PlaceholderText;
        }
    }
}
