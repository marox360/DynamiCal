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
            System.Windows.Forms.Panel sidePanel;
            this.showInCalendarButton = new System.Windows.Forms.Button();
            this.mDeselectAllButton = new System.Windows.Forms.Button();
            this.mSelectAllButton = new System.Windows.Forms.Button();
            this.eventModelListBox = new System.Windows.Forms.CheckedListBox();
            this.eventListBox = new DynamiCal.Presentation.ListBox.EventListBox();
            this.calendarTreeView = new DynamiCal.Presentation.TreeView.CalendarTreeView();
            this.cDeselectAllButton = new System.Windows.Forms.Button();
            this.cSelectAllButton = new System.Windows.Forms.Button();
            this.searchBoxPanel = new DynamiCal.Presentation.TextBox.SearchBoxPanel();
            this.eventPanel = new DynamiCal.Presentation.EventPanel();
            this.noEventsLabel = new System.Windows.Forms.Label();
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
            sidePanel = new System.Windows.Forms.Panel();
            panel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            eventBottomPanel.SuspendLayout();
            bottomModelPanel.SuspendLayout();
            eventModelPanel.SuspendLayout();
            eventListPanel.SuspendLayout();
            calendarPanel.SuspendLayout();
            bottomCalendarPanel.SuspendLayout();
            sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(tableLayoutPanel);
            panel.Controls.Add(this.searchBoxPanel);
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
            bottomModelPanel.Controls.Add(this.mDeselectAllButton);
            bottomModelPanel.Controls.Add(this.mSelectAllButton);
            bottomModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomModelPanel.Location = new System.Drawing.Point(170, 264);
            bottomModelPanel.Name = "bottomModelPanel";
            bottomModelPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            bottomModelPanel.Size = new System.Drawing.Size(161, 49);
            bottomModelPanel.TabIndex = 7;
            // 
            // mDeselectAllButton
            // 
            this.mDeselectAllButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mDeselectAllButton.Location = new System.Drawing.Point(20, 26);
            this.mDeselectAllButton.Name = "mDeselectAllButton";
            this.mDeselectAllButton.Size = new System.Drawing.Size(121, 23);
            this.mDeselectAllButton.TabIndex = 1;
            this.mDeselectAllButton.Text = "Deseleziona tutti";
            this.mDeselectAllButton.UseVisualStyleBackColor = true;
            this.mDeselectAllButton.Click += new System.EventHandler(this.mDeselectAllButton_Click);
            // 
            // mSelectAllButton
            // 
            this.mSelectAllButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mSelectAllButton.Location = new System.Drawing.Point(20, 0);
            this.mSelectAllButton.Name = "mSelectAllButton";
            this.mSelectAllButton.Size = new System.Drawing.Size(121, 23);
            this.mSelectAllButton.TabIndex = 0;
            this.mSelectAllButton.Text = "Seleziona tutti";
            this.mSelectAllButton.UseVisualStyleBackColor = true;
            this.mSelectAllButton.Click += new System.EventHandler(this.mSelectAllButton_Click);
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
            this.eventModelListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.eventModelListBox_ItemCheck);
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
            this.eventListBox.EventFilter = null;
            this.eventListBox.EventPanel = null;
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 17;
            this.eventListBox.Location = new System.Drawing.Point(0, 25);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(162, 230);
            this.eventListBox.TabIndex = 0;
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
            this.calendarTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.UpdateFilter);
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
            bottomCalendarPanel.Controls.Add(this.cDeselectAllButton);
            bottomCalendarPanel.Controls.Add(this.cSelectAllButton);
            bottomCalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomCalendarPanel.Location = new System.Drawing.Point(3, 264);
            bottomCalendarPanel.Name = "bottomCalendarPanel";
            bottomCalendarPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            bottomCalendarPanel.Size = new System.Drawing.Size(161, 49);
            bottomCalendarPanel.TabIndex = 6;
            // 
            // cDeselectAllButton
            // 
            this.cDeselectAllButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDeselectAllButton.Location = new System.Drawing.Point(20, 26);
            this.cDeselectAllButton.Name = "cDeselectAllButton";
            this.cDeselectAllButton.Size = new System.Drawing.Size(121, 23);
            this.cDeselectAllButton.TabIndex = 1;
            this.cDeselectAllButton.Text = "Deseleziona tutti";
            this.cDeselectAllButton.UseVisualStyleBackColor = true;
            this.cDeselectAllButton.Click += new System.EventHandler(this.cDeselectAllButton_Click);
            // 
            // cSelectAllButton
            // 
            this.cSelectAllButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cSelectAllButton.Location = new System.Drawing.Point(20, 0);
            this.cSelectAllButton.Name = "cSelectAllButton";
            this.cSelectAllButton.Size = new System.Drawing.Size(121, 23);
            this.cSelectAllButton.TabIndex = 0;
            this.cSelectAllButton.Text = "Seleziona tutti";
            this.cSelectAllButton.UseVisualStyleBackColor = true;
            this.cSelectAllButton.Click += new System.EventHandler(this.cSelectAllButton_Click);
            // 
            // searchBoxPanel
            // 
            this.searchBoxPanel.BackColor = System.Drawing.SystemColors.Window;
            this.searchBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBoxPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxPanel.Location = new System.Drawing.Point(5, 10);
            this.searchBoxPanel.Name = "searchBoxPanel";
            this.searchBoxPanel.Padding = new System.Windows.Forms.Padding(0, 2, 2, 5);
            this.searchBoxPanel.Size = new System.Drawing.Size(502, 30);
            this.searchBoxPanel.TabIndex = 1;
            this.searchBoxPanel.SearchTextChanged += new System.EventHandler(this.UpdateFilter);
            // 
            // sidePanel
            // 
            sidePanel.Controls.Add(this.eventPanel);
            sidePanel.Controls.Add(this.noEventsLabel);
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
            this.eventPanel.Size = new System.Drawing.Size(222, 361);
            this.eventPanel.TabIndex = 0;
            // 
            // noEventsLabel
            // 
            this.noEventsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noEventsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noEventsLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.noEventsLabel.Location = new System.Drawing.Point(0, 0);
            this.noEventsLabel.Name = "noEventsLabel";
            this.noEventsLabel.Size = new System.Drawing.Size(222, 361);
            this.noEventsLabel.TabIndex = 1;
            this.noEventsLabel.Text = "Nessun evento";
            this.noEventsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Presentation.EventPanel eventPanel;
        private Presentation.TextBox.SearchBoxPanel searchBoxPanel;
        private Presentation.ListBox.EventListBox eventListBox;
        private Presentation.TreeView.CalendarTreeView calendarTreeView;
        private System.Windows.Forms.CheckedListBox eventModelListBox;
        private System.Windows.Forms.Button cDeselectAllButton;
        private System.Windows.Forms.Button cSelectAllButton;
        private System.Windows.Forms.Button mDeselectAllButton;
        private System.Windows.Forms.Button mSelectAllButton;
        private System.Windows.Forms.Button showInCalendarButton;
        private System.Windows.Forms.Label noEventsLabel;

    }
}