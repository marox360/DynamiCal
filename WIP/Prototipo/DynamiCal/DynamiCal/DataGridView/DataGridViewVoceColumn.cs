﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiCal.DataGridView
{
    public class DataGridViewVoceColumn : DataGridViewColumn
    {
        public DataGridViewVoceColumn() : base(new DataGridViewVoceCell()) { }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewVoceCell)))
                {
                    throw new InvalidCastException("Must be a DataGridViewVoceCell");
                }

                base.CellTemplate = value;
            }
        }
    }
}
