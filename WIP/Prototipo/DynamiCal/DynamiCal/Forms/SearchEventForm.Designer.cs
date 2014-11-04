namespace DynamiCal.Forms
{
    partial class SearchEventForm
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
            System.Windows.Forms.Panel panel;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
            System.Windows.Forms.Panel eventBottomPanel;
            System.Windows.Forms.Panel bottomModelPanel;
            System.Windows.Forms.Panel eventModelPanel;
            System.Windows.Forms.Label eventModelLabel;
            System.Windows.Forms.Panel eventListPanel;
            System.Windows.Forms.Label eventLabel;
            System.Windows.Forms.Panel calendarPanel;
            System.Windows.Forms.Label calendarLabel;
            System.Windows.Forms.Panel bottomCalendarPanel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Panel topPanel;
            System.Windows.Forms.Panel sidePanel;
            System.Windows.Forms.Label noEventsLabel;
            this.showInCalendarButton = new System.Windows.Forms.Button();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventModelListBox = new System.Windows.Forms.CheckedListBox();
            this.eventListBox = new DynamiCal.View.ListBox.EventListBox();
            this.calendarTreeView = new DynamiCal.View.TreeView.CalendarTreeView();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.searchBoxPanel = new DynamiCal.View.TextBox.SearchBoxPanel();
            this.eventPanel = new DynamiCal.View.EventPanel();
            panel = new System.Windows.Forms.Panel();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            eventBottomPanel = new System.Windows.Forms.Panel();
            bottomModelPanel = new System.Windows.Forms.Panel();
            eventModelPanel = new System.Windows.Forms.Panel();
            eventModelLabel = new System.Windows.Forms.Label();
            eventListPanel = new System.Windows.Forms.Panel();
            eventLabel = new System.Windows.Forms.Label();
            calendarPanel = new System.Windows.Forms.Panel();
            calendarLabel = new System.Windows.Forms.Label();
            bottomCalendarPanel = new System.Windows.Forms.Panel();
            dateLabel = new System.Windows.Forms.Label();
            topPanel = new System.Windows.Forms.Panel();
            sidePanel = new System.Windows.Forms.Panel();
            noEventsLabel = new System.Windows.Forms.Label();
            panel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            eventBottomPanel.SuspendLayout();
            bottomModelPanel.SuspendLayout();
            eventModelPanel.SuspendLayout();
            eventListPanel.SuspendLayout();
            calendarPanel.SuspendLayout();
            bottomCalendarPanel.SuspendLayout();
            topPanel.SuspendLayout();
            sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(tableLayoutPanel);
            panel.Controls.Add(topPanel);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            panel.Size = new System.Drawing.Size(512, 361);
            panel.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableLayoutPanel.Controls.Add(eventBottomPanel, 2, 1);
            tableLayoutPanel.Controls.Add(bottomModelPanel, 1, 1);
            tableLayoutPanel.Controls.Add(eventModelPanel, 1, 0);
            tableLayoutPanel.Controls.Add(eventListPanel, 2, 0);
            tableLayoutPanel.Controls.Add(calendarPanel, 0, 0);
            tableLayoutPanel.Controls.Add(bottomCalendarPanel, 0, 1);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(5, 40);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            tableLayoutPanel.Size = new System.Drawing.Size(502, 316);
            tableLayoutPanel.TabIndex = 2;
            // 
            // eventBottomPanel
            // 
            eventBottomPanel.Controls.Add(this.showInCalendarButton);
            eventBottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            eventBottomPanel.Location = new System.Drawing.Point(337, 264);
            eventBottomPanel.Name = "eventBottomPanel";
            eventBottomPanel.Padding = new System.Windows.Forms.Padding(20, 13, 20, 13);
            eventBottomPanel.Size = new System.Drawing.Size(162, 49);
            eventBottomPanel.TabIndex = 8;
            // 
            // showInCalendarButton
            // 
            this.showInCalendarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showInCalendarButton.Enabled = false;
            this.showInCalendarButton.Location = new System.Drawing.Point(20, 13);
            this.showInCalendarButton.Name = "showInCalendarButton";
            this.showInCalendarButton.Size = new System.Drawing.Size(122, 23);
            this.showInCalendarButton.TabIndex = 1;
            this.showInCalendarButton.Text = "Apri nel calendario";
            this.showInCalendarButton.UseVisualStyleBackColor = true;
            this.showInCalendarButton.Click += new System.EventHandler(this.showInCalendarButton_Click);
            // 
            // bottomModelPanel
            // 
            bottomModelPanel.Controls.Add(this.endDateTimePicker);
            bottomModelPanel.Controls.Add(this.startDateTimePicker);
            bottomModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomModelPanel.Location = new System.Drawing.Point(170, 264);
            bottomModelPanel.Name = "bottomModelPanel";
            bottomModelPanel.Size = new System.Drawing.Size(161, 49);
            bottomModelPanel.TabIndex = 7;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.endDateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(0, 27);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(161, 22);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.startDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(161, 22);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // eventModelPanel
            // 
            eventModelPanel.Controls.Add(this.eventModelListBox);
            eventModelPanel.Controls.Add(eventModelLabel);
            eventModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            eventModelPanel.Location = new System.Drawing.Point(170, 3);
            eventModelPanel.Name = "eventModelPanel";
            eventModelPanel.Size = new System.Drawing.Size(161, 255);
            eventModelPanel.TabIndex = 3;
            // 
            // eventModelListBox
            // 
            this.eventModelListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventModelListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventModelListBox.FormattingEnabled = true;
            this.eventModelListBox.Location = new System.Drawing.Point(0, 25);
            this.eventModelListBox.Name = "eventModelListBox";
            this.eventModelListBox.Size = new System.Drawing.Size(161, 230);
            this.eventModelListBox.TabIndex = 2;
            // 
            // eventModelLabel
            // 
            eventModelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            eventModelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eventModelLabel.Location = new System.Drawing.Point(0, 0);
            eventModelLabel.Name = "eventModelLabel";
            eventModelLabel.Size = new System.Drawing.Size(161, 25);
            eventModelLabel.TabIndex = 3;
            eventModelLabel.Text = "Filtra modelli:";
            eventModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventListPanel
            // 
            eventListPanel.Controls.Add(this.eventListBox);
            eventListPanel.Controls.Add(eventLabel);
            eventListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            eventListPanel.Location = new System.Drawing.Point(337, 3);
            eventListPanel.Name = "eventListPanel";
            eventListPanel.Size = new System.Drawing.Size(162, 255);
            eventListPanel.TabIndex = 4;
            // 
            // eventListBox
            // 
            this.eventListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventListBox.DisplayMember = "Nome";
            this.eventListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 17;
            this.eventListBox.Location = new System.Drawing.Point(0, 25);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(162, 230);
            this.eventListBox.TabIndex = 0;
            this.eventListBox.SelectedValueChanged += new System.EventHandler(this.eventListBox_SelectedValueChanged);
            // 
            // eventLabel
            // 
            eventLabel.Dock = System.Windows.Forms.DockStyle.Top;
            eventLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eventLabel.Location = new System.Drawing.Point(0, 0);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new System.Drawing.Size(162, 25);
            eventLabel.TabIndex = 4;
            eventLabel.Text = "Seleziona un evento:";
            eventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calendarPanel
            // 
            calendarPanel.Controls.Add(this.calendarTreeView);
            calendarPanel.Controls.Add(calendarLabel);
            calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            calendarPanel.Location = new System.Drawing.Point(3, 3);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new System.Drawing.Size(161, 255);
            calendarPanel.TabIndex = 5;
            // 
            // calendarTreeView
            // 
            this.calendarTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendarTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarTreeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.calendarTreeView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarTreeView.FullRowSelect = true;
            this.calendarTreeView.Location = new System.Drawing.Point(0, 25);
            this.calendarTreeView.Name = "calendarTreeView";
            this.calendarTreeView.ShowLines = false;
            this.calendarTreeView.ShowPlusMinus = false;
            this.calendarTreeView.Size = new System.Drawing.Size(161, 230);
            this.calendarTreeView.TabIndex = 1;
            // 
            // calendarLabel
            // 
            calendarLabel.Dock = System.Windows.Forms.DockStyle.Top;
            calendarLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calendarLabel.Location = new System.Drawing.Point(0, 0);
            calendarLabel.Name = "calendarLabel";
            calendarLabel.Size = new System.Drawing.Size(161, 25);
            calendarLabel.TabIndex = 4;
            calendarLabel.Text = "Filtra calendari:";
            calendarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomCalendarPanel
            // 
            bottomCalendarPanel.Controls.Add(this.dateComboBox);
            bottomCalendarPanel.Controls.Add(dateLabel);
            bottomCalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomCalendarPanel.Location = new System.Drawing.Point(3, 264);
            bottomCalendarPanel.Name = "bottomCalendarPanel";
            bottomCalendarPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            bottomCalendarPanel.Size = new System.Drawing.Size(161, 49);
            bottomCalendarPanel.TabIndex = 6;
            // 
            // dateComboBox
            // 
            this.dateComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Items.AddRange(new object[] {
            "Nessuna",
            "Giornata",
            "Periodo"});
            this.dateComboBox.Location = new System.Drawing.Point(20, 28);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(121, 21);
            this.dateComboBox.TabIndex = 6;
            // 
            // dateLabel
            // 
            dateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            dateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(20, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(121, 17);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Filtra data:";
            dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(this.searchBoxPanel);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(5, 10);
            topPanel.Name = "topPanel";
            topPanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            topPanel.Size = new System.Drawing.Size(502, 30);
            topPanel.TabIndex = 5;
            // 
            // searchBoxPanel
            // 
            this.searchBoxPanel.BackColor = System.Drawing.SystemColors.Window;
            this.searchBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBoxPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxPanel.Location = new System.Drawing.Point(15, 0);
            this.searchBoxPanel.Name = "searchBoxPanel";
            this.searchBoxPanel.Padding = new System.Windows.Forms.Padding(0, 2, 2, 5);
            this.searchBoxPanel.Size = new System.Drawing.Size(487, 30);
            this.searchBoxPanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            sidePanel.Controls.Add(this.eventPanel);
            sidePanel.Controls.Add(noEventsLabel);
            sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel.Location = new System.Drawing.Point(512, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new System.Drawing.Size(222, 361);
            sidePanel.TabIndex = 3;
            // 
            // eventPanel
            // 
            this.eventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventPanel.Location = new System.Drawing.Point(0, 0);
            this.eventPanel.Name = "eventPanel";
            this.eventPanel.OverrideDate = new System.DateTime(((long)(0)));
            this.eventPanel.Size = new System.Drawing.Size(222, 361);
            this.eventPanel.TabIndex = 0;
            // 
            // noEventsLabel
            // 
            noEventsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            noEventsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noEventsLabel.ForeColor = System.Drawing.Color.DarkGray;
            noEventsLabel.Location = new System.Drawing.Point(0, 0);
            noEventsLabel.Name = "noEventsLabel";
            noEventsLabel.Size = new System.Drawing.Size(222, 361);
            noEventsLabel.TabIndex = 1;
            noEventsLabel.Text = "Nessun evento";
            noEventsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(panel);
            this.Controls.Add(sidePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "SearchEventForm";
            this.Text = "Cerca evento";
            this.Load += new System.EventHandler(this.SearchEventForm_Load);
            panel.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            eventBottomPanel.ResumeLayout(false);
            bottomModelPanel.ResumeLayout(false);
            eventModelPanel.ResumeLayout(false);
            eventListPanel.ResumeLayout(false);
            calendarPanel.ResumeLayout(false);
            bottomCalendarPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private View.EventPanel eventPanel;
        private View.TextBox.SearchBoxPanel searchBoxPanel;
        private View.ListBox.EventListBox eventListBox;
        private View.TreeView.CalendarTreeView calendarTreeView;
        private System.Windows.Forms.CheckedListBox eventModelListBox;
        private System.Windows.Forms.Button showInCalendarButton;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.ComboBox dateComboBox;

    }
}