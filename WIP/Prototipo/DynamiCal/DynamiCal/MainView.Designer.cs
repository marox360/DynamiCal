namespace DynamiCal
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.calendarList = new System.Windows.Forms.ListBox();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.calendarGridView = new System.Windows.Forms.DataGridView();
            this.lunedìDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martedìDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mercoledìDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giovedìDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venerdìDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domenicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarTitlePanel = new System.Windows.Forms.Panel();
            this.displayedMonth = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).BeginInit();
            this.calendarTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.calendarList);
            this.sidePanel.Controls.Add(this.datePicker);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(226, 416);
            this.sidePanel.TabIndex = 1;
            // 
            // calendarList
            // 
            this.calendarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarList.FormattingEnabled = true;
            this.calendarList.Location = new System.Drawing.Point(0, 0);
            this.calendarList.Margin = new System.Windows.Forms.Padding(0);
            this.calendarList.Name = "calendarList";
            this.calendarList.Size = new System.Drawing.Size(226, 254);
            this.calendarList.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datePicker.Location = new System.Drawing.Point(0, 254);
            this.datePicker.MaxSelectionCount = 1;
            this.datePicker.Name = "datePicker";
            this.datePicker.TabIndex = 0;
            this.datePicker.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.datePicker_DateSelected);
            // 
            // calendarPanel
            // 
            this.calendarPanel.Controls.Add(this.calendarGridView);
            this.calendarPanel.Controls.Add(this.calendarTitlePanel);
            this.calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel.Location = new System.Drawing.Point(226, 0);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(508, 416);
            this.calendarPanel.TabIndex = 3;
            // 
            // calendarGridView
            // 
            this.calendarGridView.AllowUserToAddRows = false;
            this.calendarGridView.AllowUserToDeleteRows = false;
            this.calendarGridView.AllowUserToResizeColumns = false;
            this.calendarGridView.AllowUserToResizeRows = false;
            this.calendarGridView.AutoGenerateColumns = false;
            this.calendarGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calendarGridView.ColumnHeadersHeight = 35;
            this.calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calendarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lunedìDataGridViewTextBoxColumn,
            this.martedìDataGridViewTextBoxColumn,
            this.mercoledìDataGridViewTextBoxColumn,
            this.giovedìDataGridViewTextBoxColumn,
            this.venerdìDataGridViewTextBoxColumn,
            this.sabatoDataGridViewTextBoxColumn,
            this.domenicaDataGridViewTextBoxColumn});
            this.calendarGridView.DataSource = this.weekBindingSource;
            this.calendarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarGridView.Location = new System.Drawing.Point(0, 30);
            this.calendarGridView.Name = "calendarGridView";
            this.calendarGridView.ReadOnly = true;
            this.calendarGridView.RowHeadersVisible = false;
            this.calendarGridView.RowTemplate.Height = 50;
            this.calendarGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.calendarGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.calendarGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.calendarGridView.Size = new System.Drawing.Size(508, 386);
            this.calendarGridView.TabIndex = 1;
            this.calendarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendarGridView_CellContentClick);
            this.calendarGridView.Resize += new System.EventHandler(this.calendarGridView_Resize);
            // 
            // lunedìDataGridViewTextBoxColumn
            // 
            this.lunedìDataGridViewTextBoxColumn.DataPropertyName = "Lunedì";
            this.lunedìDataGridViewTextBoxColumn.HeaderText = "Lunedì";
            this.lunedìDataGridViewTextBoxColumn.Name = "lunedìDataGridViewTextBoxColumn";
            this.lunedìDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // martedìDataGridViewTextBoxColumn
            // 
            this.martedìDataGridViewTextBoxColumn.DataPropertyName = "Martedì";
            this.martedìDataGridViewTextBoxColumn.HeaderText = "Martedì";
            this.martedìDataGridViewTextBoxColumn.Name = "martedìDataGridViewTextBoxColumn";
            this.martedìDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mercoledìDataGridViewTextBoxColumn
            // 
            this.mercoledìDataGridViewTextBoxColumn.DataPropertyName = "Mercoledì";
            this.mercoledìDataGridViewTextBoxColumn.HeaderText = "Mercoledì";
            this.mercoledìDataGridViewTextBoxColumn.Name = "mercoledìDataGridViewTextBoxColumn";
            this.mercoledìDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giovedìDataGridViewTextBoxColumn
            // 
            this.giovedìDataGridViewTextBoxColumn.DataPropertyName = "Giovedì";
            this.giovedìDataGridViewTextBoxColumn.HeaderText = "Giovedì";
            this.giovedìDataGridViewTextBoxColumn.Name = "giovedìDataGridViewTextBoxColumn";
            this.giovedìDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venerdìDataGridViewTextBoxColumn
            // 
            this.venerdìDataGridViewTextBoxColumn.DataPropertyName = "Venerdì";
            this.venerdìDataGridViewTextBoxColumn.HeaderText = "Venerdì";
            this.venerdìDataGridViewTextBoxColumn.Name = "venerdìDataGridViewTextBoxColumn";
            this.venerdìDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sabatoDataGridViewTextBoxColumn
            // 
            this.sabatoDataGridViewTextBoxColumn.DataPropertyName = "Sabato";
            this.sabatoDataGridViewTextBoxColumn.HeaderText = "Sabato";
            this.sabatoDataGridViewTextBoxColumn.Name = "sabatoDataGridViewTextBoxColumn";
            this.sabatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domenicaDataGridViewTextBoxColumn
            // 
            this.domenicaDataGridViewTextBoxColumn.DataPropertyName = "Domenica";
            this.domenicaDataGridViewTextBoxColumn.HeaderText = "Domenica";
            this.domenicaDataGridViewTextBoxColumn.Name = "domenicaDataGridViewTextBoxColumn";
            this.domenicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weekBindingSource
            // 
            this.weekBindingSource.DataSource = typeof(DynamiCal.DataGridBindingSources.Week);
            // 
            // calendarTitlePanel
            // 
            this.calendarTitlePanel.Controls.Add(this.displayedMonth);
            this.calendarTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.calendarTitlePanel.Name = "calendarTitlePanel";
            this.calendarTitlePanel.Size = new System.Drawing.Size(508, 30);
            this.calendarTitlePanel.TabIndex = 0;
            // 
            // displayedMonth
            // 
            this.displayedMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayedMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayedMonth.Location = new System.Drawing.Point(358, 0);
            this.displayedMonth.Name = "displayedMonth";
            this.displayedMonth.Size = new System.Drawing.Size(150, 30);
            this.displayedMonth.TabIndex = 0;
            this.displayedMonth.Text = "Mese Anno";
            this.displayedMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(734, 416);
            this.Controls.Add(this.calendarPanel);
            this.Controls.Add(this.sidePanel);
            this.MinimumSize = new System.Drawing.Size(750, 455);
            this.Name = "MainView";
            this.Text = "DynamiCal";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.sidePanel.ResumeLayout(false);
            this.calendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).EndInit();
            this.calendarTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.MonthCalendar datePicker;
        private System.Windows.Forms.ListBox calendarList;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.Panel calendarTitlePanel;
        private System.Windows.Forms.Label displayedMonth;
        private System.Windows.Forms.DataGridView calendarGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunedìDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn martedìDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mercoledìDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giovedìDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venerdìDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domenicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource weekBindingSource;

    }
}

