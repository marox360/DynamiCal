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
            this.calendarTitlePanel = new System.Windows.Forms.Panel();
            this.displayedMonth = new System.Windows.Forms.Label();
            this.lunedìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.martedìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.mercoledìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.giovedìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.venerdìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.sabatoDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.domenicaDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.weekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sidePanel.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
            this.calendarTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).BeginInit();
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
            this.lunedìDataGridViewColumn,
            this.martedìDataGridViewColumn,
            this.mercoledìDataGridViewColumn,
            this.giovedìDataGridViewColumn,
            this.venerdìDataGridViewColumn,
            this.sabatoDataGridViewColumn,
            this.domenicaDataGridViewColumn});
            this.calendarGridView.DataSource = this.weekBindingSource;
            this.calendarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarGridView.Location = new System.Drawing.Point(0, 30);
            this.calendarGridView.MultiSelect = false;
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
            // lunedìDataGridViewColumn
            // 
            this.lunedìDataGridViewColumn.DataPropertyName = "Lunedì";
            this.lunedìDataGridViewColumn.HeaderText = "Lunedì";
            this.lunedìDataGridViewColumn.Name = "lunedìDataGridViewColumn";
            this.lunedìDataGridViewColumn.ReadOnly = true;
            this.lunedìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lunedìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // martedìDataGridViewColumn
            // 
            this.martedìDataGridViewColumn.DataPropertyName = "Martedì";
            this.martedìDataGridViewColumn.HeaderText = "Martedì";
            this.martedìDataGridViewColumn.Name = "martedìDataGridViewColumn";
            this.martedìDataGridViewColumn.ReadOnly = true;
            this.martedìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.martedìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mercoledìDataGridViewColumn
            // 
            this.mercoledìDataGridViewColumn.DataPropertyName = "Mercoledì";
            this.mercoledìDataGridViewColumn.HeaderText = "Mercoledì";
            this.mercoledìDataGridViewColumn.Name = "mercoledìDataGridViewColumn";
            this.mercoledìDataGridViewColumn.ReadOnly = true;
            this.mercoledìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mercoledìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // giovedìDataGridViewColumn
            // 
            this.giovedìDataGridViewColumn.DataPropertyName = "Giovedì";
            this.giovedìDataGridViewColumn.HeaderText = "Giovedì";
            this.giovedìDataGridViewColumn.Name = "giovedìDataGridViewColumn";
            this.giovedìDataGridViewColumn.ReadOnly = true;
            this.giovedìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.giovedìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // venerdìDataGridViewColumn
            // 
            this.venerdìDataGridViewColumn.DataPropertyName = "Venerdì";
            this.venerdìDataGridViewColumn.HeaderText = "Venerdì";
            this.venerdìDataGridViewColumn.Name = "venerdìDataGridViewColumn";
            this.venerdìDataGridViewColumn.ReadOnly = true;
            this.venerdìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.venerdìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sabatoDataGridViewColumn
            // 
            this.sabatoDataGridViewColumn.DataPropertyName = "Sabato";
            this.sabatoDataGridViewColumn.HeaderText = "Sabato";
            this.sabatoDataGridViewColumn.Name = "sabatoDataGridViewColumn";
            this.sabatoDataGridViewColumn.ReadOnly = true;
            this.sabatoDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sabatoDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // domenicaDataGridViewColumn
            // 
            this.domenicaDataGridViewColumn.DataPropertyName = "Domenica";
            this.domenicaDataGridViewColumn.HeaderText = "Domenica";
            this.domenicaDataGridViewColumn.Name = "domenicaDataGridViewColumn";
            this.domenicaDataGridViewColumn.ReadOnly = true;
            this.domenicaDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.domenicaDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // weekBindingSource
            // 
            this.weekBindingSource.DataSource = typeof(DynamiCal.DataGridView.BindingSources.CalendarWeek);
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
            this.calendarTitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource weekBindingSource;
        private DataGridView.DataGridViewDayColumn lunedìDataGridViewColumn;
        private DataGridView.DataGridViewDayColumn martedìDataGridViewColumn;
        private DataGridView.DataGridViewDayColumn mercoledìDataGridViewColumn;
        private DataGridView.DataGridViewDayColumn giovedìDataGridViewColumn;
        private DataGridView.DataGridViewDayColumn venerdìDataGridViewColumn;
        private DataGridView.DataGridViewDayColumn sabatoDataGridViewColumn;
        private DataGridView.DataGridViewDayColumn domenicaDataGridViewColumn;

    }
}

