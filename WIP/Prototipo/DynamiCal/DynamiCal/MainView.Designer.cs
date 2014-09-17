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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.calendarList = new System.Windows.Forms.ListBox();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.calendarGridView = new System.Windows.Forms.DataGridView();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarTitlePanel = new System.Windows.Forms.Panel();
            this.displayedMonth = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
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
            this.datePicker.Name = "datePicker";
            this.datePicker.TabIndex = 0;
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
            this.calendarGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calendarGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            this.calendarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarGridView.Location = new System.Drawing.Point(0, 30);
            this.calendarGridView.Name = "calendarGridView";
            this.calendarGridView.RowHeadersVisible = false;
            this.calendarGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.calendarGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.calendarGridView.Size = new System.Drawing.Size(508, 386);
            this.calendarGridView.TabIndex = 1;
            this.calendarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Lunedì";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Martedì";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Mercoledì";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Giovedì";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Venerdì";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Sabato";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Domenica";
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            this.Sunday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.displayedMonth.Location = new System.Drawing.Point(427, 0);
            this.displayedMonth.Name = "displayedMonth";
            this.displayedMonth.Size = new System.Drawing.Size(81, 30);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;

    }
}

