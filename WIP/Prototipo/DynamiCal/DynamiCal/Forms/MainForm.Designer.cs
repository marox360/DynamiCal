namespace DynamiCal.Forms
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
            DynamiCal.View.DataGridView.DataGridViewDayColumn lunedìDataGridViewColumn;
            DynamiCal.View.DataGridView.DataGridViewDayColumn martedìDataGridViewColumn;
            DynamiCal.View.DataGridView.DataGridViewDayColumn mercoledìDataGridViewColumn;
            DynamiCal.View.DataGridView.DataGridViewDayColumn giovedìDataGridViewColumn;
            DynamiCal.View.DataGridView.DataGridViewDayColumn venerdìDataGridViewColumn;
            DynamiCal.View.DataGridView.DataGridViewDayColumn sabatoDataGridViewColumn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            DynamiCal.View.DataGridView.DataGridViewDayColumn domenicaDataGridViewColumn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Panel leftSidePanel;
            System.Windows.Forms.Panel calendarTitlePanel;
            System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
            System.Windows.Forms.Panel rightSidePanel;
            System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem creaNuovoCalendarioToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem modelloEventoToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem creaModelloEventoToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem creaEventoToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem cercaEventoToolStripMenuItem;
            System.Windows.Forms.MenuStrip menuBar;
            System.Windows.Forms.ToolStripMenuItem deleteStripMenuItem;
            System.Windows.Forms.Panel calendarPanel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.calendarTreeView = new DynamiCal.View.TreeView.CalendarTreeView();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.eventPanel = new DynamiCal.View.EventPanel();
            this.topRightPanel = new System.Windows.Forms.Panel();
            this.eventsListBox = new DynamiCal.View.ListBox.EventListBox();
            this.searchBoxPanel = new DynamiCal.View.TextBox.SearchBoxPanel();
            this.noEventsLabel = new System.Windows.Forms.Label();
            this.eliminaModelloEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarGridView = new DynamiCal.View.DataGridView.CalendarDataGridView();
            this.weekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeNodeMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lunedìDataGridViewColumn = new DynamiCal.View.DataGridView.DataGridViewDayColumn();
            martedìDataGridViewColumn = new DynamiCal.View.DataGridView.DataGridViewDayColumn();
            mercoledìDataGridViewColumn = new DynamiCal.View.DataGridView.DataGridViewDayColumn();
            giovedìDataGridViewColumn = new DynamiCal.View.DataGridView.DataGridViewDayColumn();
            venerdìDataGridViewColumn = new DynamiCal.View.DataGridView.DataGridViewDayColumn();
            sabatoDataGridViewColumn = new DynamiCal.View.DataGridView.DataGridViewDayColumn();
            domenicaDataGridViewColumn = new DynamiCal.View.DataGridView.DataGridViewDayColumn();
            leftSidePanel = new System.Windows.Forms.Panel();
            calendarTitlePanel = new System.Windows.Forms.Panel();
            topFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            rightSidePanel = new System.Windows.Forms.Panel();
            calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            creaNuovoCalendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modelloEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            creaModelloEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            creaEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cercaEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuBar = new System.Windows.Forms.MenuStrip();
            deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            calendarPanel = new System.Windows.Forms.Panel();
            leftSidePanel.SuspendLayout();
            calendarTitlePanel.SuspendLayout();
            topFlowLayoutPanel.SuspendLayout();
            rightSidePanel.SuspendLayout();
            this.topRightPanel.SuspendLayout();
            menuBar.SuspendLayout();
            calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).BeginInit();
            this.treeNodeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lunedìDataGridViewColumn
            // 
            lunedìDataGridViewColumn.DataPropertyName = "Lunedì";
            lunedìDataGridViewColumn.HeaderText = "lunedì";
            lunedìDataGridViewColumn.Name = "lunedìDataGridViewColumn";
            lunedìDataGridViewColumn.ReadOnly = true;
            lunedìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            lunedìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // martedìDataGridViewColumn
            // 
            martedìDataGridViewColumn.DataPropertyName = "Martedì";
            martedìDataGridViewColumn.HeaderText = "martedì";
            martedìDataGridViewColumn.Name = "martedìDataGridViewColumn";
            martedìDataGridViewColumn.ReadOnly = true;
            martedìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            martedìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mercoledìDataGridViewColumn
            // 
            mercoledìDataGridViewColumn.DataPropertyName = "Mercoledì";
            mercoledìDataGridViewColumn.HeaderText = "mercoledì";
            mercoledìDataGridViewColumn.Name = "mercoledìDataGridViewColumn";
            mercoledìDataGridViewColumn.ReadOnly = true;
            mercoledìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            mercoledìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // giovedìDataGridViewColumn
            // 
            giovedìDataGridViewColumn.DataPropertyName = "Giovedì";
            giovedìDataGridViewColumn.HeaderText = "giovedì";
            giovedìDataGridViewColumn.Name = "giovedìDataGridViewColumn";
            giovedìDataGridViewColumn.ReadOnly = true;
            giovedìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            giovedìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // venerdìDataGridViewColumn
            // 
            venerdìDataGridViewColumn.DataPropertyName = "Venerdì";
            venerdìDataGridViewColumn.HeaderText = "venerdì";
            venerdìDataGridViewColumn.Name = "venerdìDataGridViewColumn";
            venerdìDataGridViewColumn.ReadOnly = true;
            venerdìDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            venerdìDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sabatoDataGridViewColumn
            // 
            sabatoDataGridViewColumn.DataPropertyName = "Sabato";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            sabatoDataGridViewColumn.DefaultCellStyle = dataGridViewCellStyle1;
            sabatoDataGridViewColumn.HeaderText = "sabato";
            sabatoDataGridViewColumn.Name = "sabatoDataGridViewColumn";
            sabatoDataGridViewColumn.ReadOnly = true;
            sabatoDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            sabatoDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // domenicaDataGridViewColumn
            // 
            domenicaDataGridViewColumn.DataPropertyName = "Domenica";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            domenicaDataGridViewColumn.DefaultCellStyle = dataGridViewCellStyle2;
            domenicaDataGridViewColumn.HeaderText = "domenica";
            domenicaDataGridViewColumn.Name = "domenicaDataGridViewColumn";
            domenicaDataGridViewColumn.ReadOnly = true;
            domenicaDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            domenicaDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // leftSidePanel
            // 
            leftSidePanel.BackColor = System.Drawing.SystemColors.Window;
            leftSidePanel.Controls.Add(this.calendarTreeView);
            leftSidePanel.Controls.Add(this.datePicker);
            leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            leftSidePanel.Location = new System.Drawing.Point(0, 24);
            leftSidePanel.Name = "leftSidePanel";
            leftSidePanel.Padding = new System.Windows.Forms.Padding(5);
            leftSidePanel.Size = new System.Drawing.Size(237, 562);
            leftSidePanel.TabIndex = 1;
            // 
            // calendarTreeView
            // 
            this.calendarTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendarTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.calendarTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarTreeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.calendarTreeView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarTreeView.FullRowSelect = true;
            this.calendarTreeView.ItemHeight = 20;
            this.calendarTreeView.Location = new System.Drawing.Point(5, 5);
            this.calendarTreeView.Name = "calendarTreeView";
            this.calendarTreeView.ShowLines = false;
            this.calendarTreeView.ShowPlusMinus = false;
            this.calendarTreeView.Size = new System.Drawing.Size(227, 390);
            this.calendarTreeView.TabIndex = 1;
            this.calendarTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.calendarTreeView_NodeMouseClick);
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.SystemColors.Window;
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datePicker.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.datePicker.Location = new System.Drawing.Point(5, 395);
            this.datePicker.Margin = new System.Windows.Forms.Padding(0);
            this.datePicker.MaxSelectionCount = 1;
            this.datePicker.Name = "datePicker";
            this.datePicker.TabIndex = 0;
            this.datePicker.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.datePicker_DateSelected);
            // 
            // calendarTitlePanel
            // 
            calendarTitlePanel.BackColor = System.Drawing.Color.White;
            calendarTitlePanel.Controls.Add(topFlowLayoutPanel);
            calendarTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            calendarTitlePanel.Location = new System.Drawing.Point(0, 0);
            calendarTitlePanel.Name = "calendarTitlePanel";
            calendarTitlePanel.Size = new System.Drawing.Size(680, 30);
            calendarTitlePanel.TabIndex = 0;
            // 
            // topFlowLayoutPanel
            // 
            topFlowLayoutPanel.Controls.Add(this.yearLabel);
            topFlowLayoutPanel.Controls.Add(this.monthLabel);
            topFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            topFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            topFlowLayoutPanel.Location = new System.Drawing.Point(480, 0);
            topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            topFlowLayoutPanel.Size = new System.Drawing.Size(200, 30);
            topFlowLayoutPanel.TabIndex = 1;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(143, 4);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(55, 25);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Anno";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.monthLabel.Location = new System.Drawing.Point(86, 4);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(57, 25);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "Mese";
            // 
            // rightSidePanel
            // 
            rightSidePanel.Controls.Add(this.eventPanel);
            rightSidePanel.Controls.Add(this.topRightPanel);
            rightSidePanel.Controls.Add(this.noEventsLabel);
            rightSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            rightSidePanel.Location = new System.Drawing.Point(922, 24);
            rightSidePanel.Name = "rightSidePanel";
            rightSidePanel.Size = new System.Drawing.Size(237, 562);
            rightSidePanel.TabIndex = 2;
            // 
            // eventPanel
            // 
            this.eventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventPanel.Location = new System.Drawing.Point(0, 155);
            this.eventPanel.Name = "eventPanel";
            this.eventPanel.OverrideDate = new System.DateTime(((long)(0)));
            this.eventPanel.Padding = new System.Windows.Forms.Padding(5);
            this.eventPanel.Size = new System.Drawing.Size(237, 407);
            this.eventPanel.TabIndex = 0;
            // 
            // topRightPanel
            // 
            this.topRightPanel.Controls.Add(this.eventsListBox);
            this.topRightPanel.Controls.Add(this.searchBoxPanel);
            this.topRightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRightPanel.Location = new System.Drawing.Point(0, 0);
            this.topRightPanel.Name = "topRightPanel";
            this.topRightPanel.Padding = new System.Windows.Forms.Padding(5);
            this.topRightPanel.Size = new System.Drawing.Size(237, 155);
            this.topRightPanel.TabIndex = 1;
            this.topRightPanel.Visible = false;
            // 
            // eventsListBox
            // 
            this.eventsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventsListBox.DisplayMember = "Nome";
            this.eventsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.eventsListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 17;
            this.eventsListBox.Location = new System.Drawing.Point(5, 35);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(227, 115);
            this.eventsListBox.TabIndex = 1;
            this.eventsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eventsListBox_MouseDown);
            // 
            // searchBoxPanel
            // 
            this.searchBoxPanel.BackColor = System.Drawing.SystemColors.Window;
            this.searchBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBoxPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxPanel.Location = new System.Drawing.Point(5, 5);
            this.searchBoxPanel.Name = "searchBoxPanel";
            this.searchBoxPanel.Padding = new System.Windows.Forms.Padding(0, 2, 2, 5);
            this.searchBoxPanel.Size = new System.Drawing.Size(227, 30);
            this.searchBoxPanel.TabIndex = 2;
            // 
            // noEventsLabel
            // 
            this.noEventsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noEventsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noEventsLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.noEventsLabel.Location = new System.Drawing.Point(1, 256);
            this.noEventsLabel.Name = "noEventsLabel";
            this.noEventsLabel.Size = new System.Drawing.Size(235, 72);
            this.noEventsLabel.TabIndex = 0;
            this.noEventsLabel.Text = "Nessun evento";
            this.noEventsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calendarioToolStripMenuItem
            // 
            calendarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            creaNuovoCalendarioToolStripMenuItem});
            calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            calendarioToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            calendarioToolStripMenuItem.Text = "Calendario";
            calendarioToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem_MouseEnter);
            // 
            // creaNuovoCalendarioToolStripMenuItem
            // 
            creaNuovoCalendarioToolStripMenuItem.Name = "creaNuovoCalendarioToolStripMenuItem";
            creaNuovoCalendarioToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            creaNuovoCalendarioToolStripMenuItem.Text = "Crea nuovo calendario";
            creaNuovoCalendarioToolStripMenuItem.Click += new System.EventHandler(this.createCalendarToolStripMenuItem_Click);
            // 
            // modelloEventoToolStripMenuItem
            // 
            modelloEventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            creaModelloEventoToolStripMenuItem,
            this.eliminaModelloEventoToolStripMenuItem});
            modelloEventoToolStripMenuItem.Name = "modelloEventoToolStripMenuItem";
            modelloEventoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            modelloEventoToolStripMenuItem.Text = "Modello evento";
            modelloEventoToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem_MouseEnter);
            // 
            // creaModelloEventoToolStripMenuItem
            // 
            creaModelloEventoToolStripMenuItem.Name = "creaModelloEventoToolStripMenuItem";
            creaModelloEventoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            creaModelloEventoToolStripMenuItem.Text = "Crea nuovo modello evento";
            creaModelloEventoToolStripMenuItem.Click += new System.EventHandler(this.creaModelloEventoToolStripMenuItem_Click);
            // 
            // eliminaModelloEventoToolStripMenuItem
            // 
            this.eliminaModelloEventoToolStripMenuItem.Name = "eliminaModelloEventoToolStripMenuItem";
            this.eliminaModelloEventoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.eliminaModelloEventoToolStripMenuItem.Text = "Elimina modello evento";
            this.eliminaModelloEventoToolStripMenuItem.Click += new System.EventHandler(this.eliminaModelloEventoToolStripMenuItem_Click);
            // 
            // eventoToolStripMenuItem
            // 
            eventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            creaEventoToolStripMenuItem,
            cercaEventoToolStripMenuItem});
            eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            eventoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            eventoToolStripMenuItem.Text = "Evento";
            eventoToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolStripMenuItem_MouseEnter);
            // 
            // creaEventoToolStripMenuItem
            // 
            creaEventoToolStripMenuItem.Name = "creaEventoToolStripMenuItem";
            creaEventoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            creaEventoToolStripMenuItem.Text = "Crea nuovo evento";
            creaEventoToolStripMenuItem.Click += new System.EventHandler(this.creaEventoToolStripMenuItem_Click);
            // 
            // cercaEventoToolStripMenuItem
            // 
            cercaEventoToolStripMenuItem.Name = "cercaEventoToolStripMenuItem";
            cercaEventoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            cercaEventoToolStripMenuItem.Text = "Cerca evento";
            cercaEventoToolStripMenuItem.Click += new System.EventHandler(this.cercaEventoToolStripMenuItem_Click);
            // 
            // menuBar
            // 
            menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            calendarioToolStripMenuItem,
            modelloEventoToolStripMenuItem,
            eventoToolStripMenuItem});
            menuBar.Location = new System.Drawing.Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new System.Drawing.Size(1159, 24);
            menuBar.TabIndex = 2;
            // 
            // deleteStripMenuItem
            // 
            deleteStripMenuItem.Name = "deleteStripMenuItem";
            deleteStripMenuItem.Size = new System.Drawing.Size(96, 22);
            deleteStripMenuItem.Text = "Elimina";
            // 
            // calendarPanel
            // 
            calendarPanel.Controls.Add(this.calendarGridView);
            calendarPanel.Controls.Add(calendarTitlePanel);
            calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            calendarPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calendarPanel.Location = new System.Drawing.Point(237, 24);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 3);
            calendarPanel.Size = new System.Drawing.Size(685, 562);
            calendarPanel.TabIndex = 3;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.calendarGridView.ColumnHeadersHeight = 35;
            this.calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calendarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            lunedìDataGridViewColumn,
            martedìDataGridViewColumn,
            mercoledìDataGridViewColumn,
            giovedìDataGridViewColumn,
            venerdìDataGridViewColumn,
            sabatoDataGridViewColumn,
            domenicaDataGridViewColumn});
            this.calendarGridView.DataSource = this.weekBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
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
            this.calendarGridView.RowTemplate.Height = 82;
            this.calendarGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.calendarGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.calendarGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.calendarGridView.Size = new System.Drawing.Size(680, 529);
            this.calendarGridView.TabIndex = 1;
            // 
            // weekBindingSource
            // 
            this.weekBindingSource.DataSource = typeof(DynamiCal.View.DataGridView.BindingSources.CalendarWeek);
            // 
            // treeNodeMenuStrip
            // 
            this.treeNodeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            deleteStripMenuItem,
            this.modificaToolStripMenuItem});
            this.treeNodeMenuStrip.Name = "treeNodeMenuStrip";
            this.treeNodeMenuStrip.ShowImageMargin = false;
            this.treeNodeMenuStrip.Size = new System.Drawing.Size(97, 48);
            this.treeNodeMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.treeNodeMenuStrip_ItemClicked);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1159, 586);
            this.Controls.Add(calendarPanel);
            this.Controls.Add(rightSidePanel);
            this.Controls.Add(leftSidePanel);
            this.Controls.Add(menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = menuBar;
            this.MinimumSize = new System.Drawing.Size(1175, 625);
            this.Name = "MainForm";
            this.Text = "DynamiCal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            leftSidePanel.ResumeLayout(false);
            calendarTitlePanel.ResumeLayout(false);
            topFlowLayoutPanel.ResumeLayout(false);
            topFlowLayoutPanel.PerformLayout();
            rightSidePanel.ResumeLayout(false);
            this.topRightPanel.ResumeLayout(false);
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            calendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).EndInit();
            this.treeNodeMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar datePicker;
        private View.DataGridView.CalendarDataGridView calendarGridView;
        private System.Windows.Forms.BindingSource weekBindingSource;
        private View.TreeView.CalendarTreeView calendarTreeView;
        private System.Windows.Forms.Label noEventsLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ContextMenuStrip treeNodeMenuStrip;
        private System.Windows.Forms.Panel topRightPanel;
        private View.ListBox.EventListBox eventsListBox;
        private View.EventPanel eventPanel;
        private View.TextBox.SearchBoxPanel searchBoxPanel;
        private System.Windows.Forms.ToolStripMenuItem eliminaModelloEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;

    }
}

