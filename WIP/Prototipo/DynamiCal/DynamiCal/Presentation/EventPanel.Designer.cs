namespace DynamiCal.Presentation
{
    partial class EventPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.entriesdataGridView = new DynamiCal.Presentation.DataGridView.VociDataGridView();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entriesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.Window;
            this.topPanel.Controls.Add(this.descriptionTextBox);
            this.topPanel.Controls.Add(this.repeatLabel);
            this.topPanel.Controls.Add(this.timeLabel);
            this.topPanel.Controls.Add(this.dateLabel);
            this.topPanel.Controls.Add(this.locationLabel);
            this.topPanel.Controls.Add(this.nameLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(237, 250);
            this.topPanel.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 132);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(237, 118);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // repeatLabel
            // 
            this.repeatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatLabel.Location = new System.Drawing.Point(0, 104);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(237, 13);
            this.repeatLabel.TabIndex = 4;
            this.repeatLabel.Text = "Ripeti: ";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Location = new System.Drawing.Point(0, 76);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(237, 13);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Dalle ... alle ...";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Location = new System.Drawing.Point(0, 59);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(237, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Giorno dell\'evento";
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.Location = new System.Drawing.Point(0, 31);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(237, 13);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Luogo evento";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(237, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome Evento";
            // 
            // entriesdataGridView
            // 
            this.entriesdataGridView.AllowUserToAddRows = false;
            this.entriesdataGridView.AllowUserToDeleteRows = false;
            this.entriesdataGridView.AllowUserToResizeColumns = false;
            this.entriesdataGridView.AllowUserToResizeRows = false;
            this.entriesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entriesdataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.entriesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entriesdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.entriesdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.entriesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entriesdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesdataGridView.Location = new System.Drawing.Point(0, 250);
            this.entriesdataGridView.MultiSelect = false;
            this.entriesdataGridView.Name = "entriesdataGridView";
            this.entriesdataGridView.ReadOnly = true;
            this.entriesdataGridView.RowHeadersVisible = false;
            this.entriesdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.entriesdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entriesdataGridView.Size = new System.Drawing.Size(237, 157);
            this.entriesdataGridView.TabIndex = 0;
            this.entriesdataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.entriesdataGridView_CellPainting);
            // 
            // EventPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entriesdataGridView);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EventPanel";
            this.Size = new System.Drawing.Size(237, 407);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entriesdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DynamiCal.Presentation.DataGridView.VociDataGridView entriesdataGridView;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label repeatLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ToolTip toolTip;

    }
}
