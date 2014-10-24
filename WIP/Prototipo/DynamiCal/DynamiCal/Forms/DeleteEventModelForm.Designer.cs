namespace DynamiCal.Forms
{
    partial class DeleteEventModelForm
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
            System.Windows.Forms.GroupBox groupBox1;
            this.eventModelListBox = new System.Windows.Forms.ListBox();
            this.modelloEventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventLabel = new System.Windows.Forms.Label();
            this.overviewGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new DynamiCal.Presentation.DataGridView.DataGridViewEntryTypeColumn();
            this.voceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.countEventLabel = new System.Windows.Forms.Label();
            this.dataGridViewEntryTypeColumn1 = new DynamiCal.Presentation.DataGridView.DataGridViewEntryTypeColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelloEventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.eventModelListBox);
            groupBox1.Location = new System.Drawing.Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(156, 115);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modelli";
            // 
            // eventModelListBox
            // 
            this.eventModelListBox.BackColor = System.Drawing.SystemColors.Control;
            this.eventModelListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventModelListBox.DataSource = this.modelloEventoBindingSource;
            this.eventModelListBox.DisplayMember = "Nome";
            this.eventModelListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventModelListBox.FormattingEnabled = true;
            this.eventModelListBox.Location = new System.Drawing.Point(3, 18);
            this.eventModelListBox.Name = "eventModelListBox";
            this.eventModelListBox.Size = new System.Drawing.Size(150, 94);
            this.eventModelListBox.TabIndex = 7;
            this.eventModelListBox.SelectedValueChanged += new System.EventHandler(this.eventModelListBox_SelectedValueChanged);
            // 
            // modelloEventoBindingSource
            // 
            this.modelloEventoBindingSource.DataSource = typeof(DynamiCal.Model.ModelloEvento);
            // 
            // eventLabel
            // 
            this.eventLabel.Location = new System.Drawing.Point(174, 7);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(102, 31);
            this.eventLabel.TabIndex = 11;
            this.eventLabel.Text = "Eventi con questo modello:";
            this.eventLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eventLabel.Visible = false;
            // 
            // overviewGridView
            // 
            this.overviewGridView.AllowUserToAddRows = false;
            this.overviewGridView.AllowUserToOrderColumns = true;
            this.overviewGridView.AllowUserToResizeRows = false;
            this.overviewGridView.AutoGenerateColumns = false;
            this.overviewGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.overviewGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.overviewGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.overviewGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.overviewGridView.ColumnHeadersHeight = 25;
            this.overviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.overviewGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.Tipo});
            this.overviewGridView.DataSource = this.voceBindingSource;
            this.overviewGridView.Location = new System.Drawing.Point(12, 129);
            this.overviewGridView.Name = "overviewGridView";
            this.overviewGridView.ReadOnly = true;
            this.overviewGridView.RowHeadersVisible = false;
            this.overviewGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.overviewGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overviewGridView.Size = new System.Drawing.Size(264, 120);
            this.overviewGridView.TabIndex = 6;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TipoVoce";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // voceBindingSource
            // 
            this.voceBindingSource.DataSource = typeof(DynamiCal.Model.Voce);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(174, 69);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Elimina";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(174, 99);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(102, 23);
            this.addNewButton.TabIndex = 9;
            this.addNewButton.Text = "Aggiungi nuovo";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // countEventLabel
            // 
            this.countEventLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countEventLabel.Location = new System.Drawing.Point(173, 41);
            this.countEventLabel.Name = "countEventLabel";
            this.countEventLabel.Size = new System.Drawing.Size(103, 18);
            this.countEventLabel.TabIndex = 10;
            this.countEventLabel.Text = "0";
            this.countEventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countEventLabel.Visible = false;
            // 
            // dataGridViewEntryTypeColumn1
            // 
            this.dataGridViewEntryTypeColumn1.DataPropertyName = "TipoVoce";
            this.dataGridViewEntryTypeColumn1.HeaderText = "Tipo";
            this.dataGridViewEntryTypeColumn1.Name = "dataGridViewEntryTypeColumn1";
            this.dataGridViewEntryTypeColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEntryTypeColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewEntryTypeColumn1.Width = 261;
            // 
            // DeleteEventModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 261);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.countEventLabel);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.overviewGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DeleteEventModelForm";
            this.Text = "Gestione modelli evento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteEventModel_FormClosing);
            this.Load += new System.EventHandler(this.DeleteEventModel_Load);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelloEventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource voceBindingSource;
        private System.Windows.Forms.DataGridView overviewGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private Presentation.DataGridView.DataGridViewEntryTypeColumn Tipo;
        private System.Windows.Forms.ListBox eventModelListBox;
        private System.Windows.Forms.BindingSource modelloEventoBindingSource;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Label countEventLabel;
        private Presentation.DataGridView.DataGridViewEntryTypeColumn dataGridViewEntryTypeColumn1;
        private System.Windows.Forms.Label eventLabel;
    }
}