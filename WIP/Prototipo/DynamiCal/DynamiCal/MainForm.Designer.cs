namespace DynamiCal
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Calendari");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Calendari Condivisi");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.calendarTreeView = new System.Windows.Forms.TreeView();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.calendarGridView = new System.Windows.Forms.DataGridView();
            this.calendarTitlePanel = new System.Windows.Forms.Panel();
            this.displayedMonth = new System.Windows.Forms.Label();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaNuovoCalendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelloEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaModelloEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightSidePanel = new System.Windows.Forms.Panel();
            this.lunedìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.martedìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.mercoledìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.giovedìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.venerdìDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.sabatoDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.domenicaDataGridViewColumn = new DynamiCal.DataGridView.DataGridViewDayColumn();
            this.weekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leftSidePanel.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
            this.calendarTitlePanel.SuspendLayout();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.BackColor = System.Drawing.SystemColors.Window;
            this.leftSidePanel.Controls.Add(this.calendarTreeView);
            this.leftSidePanel.Controls.Add(this.datePicker);
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 24);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Padding = new System.Windows.Forms.Padding(5);
            this.leftSidePanel.Size = new System.Drawing.Size(237, 487);
            this.leftSidePanel.TabIndex = 1;
            // 
            // calendarTreeView
            // 
            this.calendarTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendarTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.calendarTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarTreeView.FullRowSelect = true;
            this.calendarTreeView.Location = new System.Drawing.Point(5, 5);
            this.calendarTreeView.Name = "calendarTreeView";
            treeNode1.ForeColor = System.Drawing.Color.Black;
            treeNode1.Name = "LocalCalendars";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Calendari";
            treeNode2.ForeColor = System.Drawing.Color.Black;
            treeNode2.Name = "SharedCalendars";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Text = "Calendari Condivisi";
            this.calendarTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.calendarTreeView.ShowLines = false;
            this.calendarTreeView.Size = new System.Drawing.Size(227, 315);
            this.calendarTreeView.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.SystemColors.Window;
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datePicker.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.datePicker.Location = new System.Drawing.Point(5, 320);
            this.datePicker.Margin = new System.Windows.Forms.Padding(0);
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
            this.calendarPanel.Location = new System.Drawing.Point(237, 24);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 3);
            this.calendarPanel.Size = new System.Drawing.Size(535, 487);
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
            this.calendarGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.calendarGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendarGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.calendarGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calendarGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.calendarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarGridView.Location = new System.Drawing.Point(0, 30);
            this.calendarGridView.Margin = new System.Windows.Forms.Padding(0);
            this.calendarGridView.MultiSelect = false;
            this.calendarGridView.Name = "calendarGridView";
            this.calendarGridView.ReadOnly = true;
            this.calendarGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.calendarGridView.RowHeadersVisible = false;
            this.calendarGridView.RowTemplate.Height = 50;
            this.calendarGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.calendarGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.calendarGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.calendarGridView.Size = new System.Drawing.Size(530, 454);
            this.calendarGridView.TabIndex = 1;
            this.calendarGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendarGridView_CellClick);
            this.calendarGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.calendarGridView_CellPainting);
            this.calendarGridView.Resize += new System.EventHandler(this.calendarGridView_Resize);
            // 
            // calendarTitlePanel
            // 
            this.calendarTitlePanel.BackColor = System.Drawing.Color.White;
            this.calendarTitlePanel.Controls.Add(this.displayedMonth);
            this.calendarTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.calendarTitlePanel.Name = "calendarTitlePanel";
            this.calendarTitlePanel.Size = new System.Drawing.Size(530, 30);
            this.calendarTitlePanel.TabIndex = 0;
            // 
            // displayedMonth
            // 
            this.displayedMonth.BackColor = System.Drawing.Color.White;
            this.displayedMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayedMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayedMonth.Location = new System.Drawing.Point(380, 0);
            this.displayedMonth.Name = "displayedMonth";
            this.displayedMonth.Size = new System.Drawing.Size(150, 30);
            this.displayedMonth.TabIndex = 0;
            this.displayedMonth.Text = "Mese Anno";
            this.displayedMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modelloEventoToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1009, 24);
            this.menuBar.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaNuovoCalendarioToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.fileToolStripMenuItem.Text = "Calendario";
            // 
            // creaNuovoCalendarioToolStripMenuItem
            // 
            this.creaNuovoCalendarioToolStripMenuItem.Name = "creaNuovoCalendarioToolStripMenuItem";
            this.creaNuovoCalendarioToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.creaNuovoCalendarioToolStripMenuItem.Text = "Crea nuovo calendario";
            this.creaNuovoCalendarioToolStripMenuItem.Click += new System.EventHandler(this.createCalendarMenuItem_Click);
            // 
            // modelloEventoToolStripMenuItem
            // 
            this.modelloEventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaModelloEventoToolStripMenuItem});
            this.modelloEventoToolStripMenuItem.Name = "modelloEventoToolStripMenuItem";
            this.modelloEventoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.modelloEventoToolStripMenuItem.Text = "Modello evento";
            // 
            // creaModelloEventoToolStripMenuItem
            // 
            this.creaModelloEventoToolStripMenuItem.Name = "creaModelloEventoToolStripMenuItem";
            this.creaModelloEventoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.creaModelloEventoToolStripMenuItem.Text = "Crea nuovo modello evento";
            this.creaModelloEventoToolStripMenuItem.Click += new System.EventHandler(this.creaModelloEventoToolStripMenuItem_Click);
            // 
            // rightSidePanel
            // 
            this.rightSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightSidePanel.Location = new System.Drawing.Point(772, 24);
            this.rightSidePanel.Name = "rightSidePanel";
            this.rightSidePanel.Size = new System.Drawing.Size(237, 487);
            this.rightSidePanel.TabIndex = 2;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            this.sabatoDataGridViewColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sabatoDataGridViewColumn.HeaderText = "Sabato";
            this.sabatoDataGridViewColumn.Name = "sabatoDataGridViewColumn";
            this.sabatoDataGridViewColumn.ReadOnly = true;
            this.sabatoDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sabatoDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // domenicaDataGridViewColumn
            // 
            this.domenicaDataGridViewColumn.DataPropertyName = "Domenica";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.domenicaDataGridViewColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1009, 511);
            this.Controls.Add(this.calendarPanel);
            this.Controls.Add(this.rightSidePanel);
            this.Controls.Add(this.leftSidePanel);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.MinimumSize = new System.Drawing.Size(1025, 550);
            this.Name = "MainForm";
            this.Text = "DynamiCal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftSidePanel.ResumeLayout(false);
            this.calendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).EndInit();
            this.calendarTitlePanel.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.MonthCalendar datePicker;
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
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaNuovoCalendarioToolStripMenuItem;
        private System.Windows.Forms.TreeView calendarTreeView;
        private System.Windows.Forms.ToolStripMenuItem modelloEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaModelloEventoToolStripMenuItem;
        private System.Windows.Forms.Panel rightSidePanel;

    }
}

