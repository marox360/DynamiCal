namespace DynamiCal.Forms
{
    partial class CreateEventModelForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox eventModelGroup;
            System.Windows.Forms.GroupBox modelEntryGroup;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.entryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tipoVoceContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryNameTextBox = new System.Windows.Forms.TextBox();
            this.overviewGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new DynamiCal.Presentation.DataGridView.DataGridViewEntryTypeColumn();
            this.voceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            eventModelGroup = new System.Windows.Forms.GroupBox();
            modelEntryGroup = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            eventModelGroup.SuspendLayout();
            modelEntryGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVoceContainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(167, 314);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(146, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Crea";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 314);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(151, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 13);
            label1.TabIndex = 2;
            label1.Text = "Inserisci il nome:";
            // 
            // eventModelGroup
            // 
            eventModelGroup.Controls.Add(this.modelNameTextBox);
            eventModelGroup.Controls.Add(label1);
            eventModelGroup.Cursor = System.Windows.Forms.Cursors.Default;
            eventModelGroup.Location = new System.Drawing.Point(13, 13);
            eventModelGroup.Name = "eventModelGroup";
            eventModelGroup.Size = new System.Drawing.Size(300, 67);
            eventModelGroup.TabIndex = 3;
            eventModelGroup.TabStop = false;
            eventModelGroup.Text = "Modello Evento";
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.Location = new System.Drawing.Point(9, 39);
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(285, 22);
            this.modelNameTextBox.TabIndex = 3;
            this.modelNameTextBox.TextChanged += new System.EventHandler(this.modelNameTextBox_TextChanged);
            // 
            // modelEntryGroup
            // 
            modelEntryGroup.Controls.Add(this.addEntryButton);
            modelEntryGroup.Controls.Add(label3);
            modelEntryGroup.Controls.Add(this.entryTypeComboBox);
            modelEntryGroup.Controls.Add(this.entryNameTextBox);
            modelEntryGroup.Controls.Add(label2);
            modelEntryGroup.Location = new System.Drawing.Point(13, 86);
            modelEntryGroup.Name = "modelEntryGroup";
            modelEntryGroup.Size = new System.Drawing.Size(300, 95);
            modelEntryGroup.TabIndex = 4;
            modelEntryGroup.TabStop = false;
            modelEntryGroup.Text = "Voce";
            // 
            // addEntryButton
            // 
            this.addEntryButton.Enabled = false;
            this.addEntryButton.Location = new System.Drawing.Point(154, 64);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(140, 23);
            this.addEntryButton.TabIndex = 4;
            this.addEntryButton.Text = "Aggiungi";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(154, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 13);
            label3.TabIndex = 3;
            label3.Text = "Scegli il tipo:";
            // 
            // entryTypeComboBox
            // 
            this.entryTypeComboBox.DataSource = this.tipoVoceContainerBindingSource;
            this.entryTypeComboBox.DisplayMember = "DisplayText";
            this.entryTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryTypeComboBox.FormattingEnabled = true;
            this.entryTypeComboBox.ItemHeight = 15;
            this.entryTypeComboBox.Location = new System.Drawing.Point(154, 36);
            this.entryTypeComboBox.Name = "entryTypeComboBox";
            this.entryTypeComboBox.Size = new System.Drawing.Size(140, 23);
            this.entryTypeComboBox.TabIndex = 2;
            this.entryTypeComboBox.ValueMember = "Value";
            // 
            // tipoVoceContainerBindingSource
            // 
            this.tipoVoceContainerBindingSource.DataSource = typeof(DynamiCal.Presentation.IBindingContainer);
            // 
            // entryNameTextBox
            // 
            this.entryNameTextBox.Location = new System.Drawing.Point(10, 37);
            this.entryNameTextBox.Name = "entryNameTextBox";
            this.entryNameTextBox.Size = new System.Drawing.Size(140, 22);
            this.entryNameTextBox.TabIndex = 1;
            this.entryNameTextBox.TextChanged += new System.EventHandler(this.entryNameTextBox_TextChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 13);
            label2.TabIndex = 0;
            label2.Text = "Inserisci il nome:";
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
            this.overviewGridView.Location = new System.Drawing.Point(13, 188);
            this.overviewGridView.Name = "overviewGridView";
            this.overviewGridView.ReadOnly = true;
            this.overviewGridView.RowHeadersVisible = false;
            this.overviewGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.overviewGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overviewGridView.Size = new System.Drawing.Size(300, 120);
            this.overviewGridView.TabIndex = 5;
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
            // CreateEventModelForm
            // 
            this.AcceptButton = this.createButton;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(325, 349);
            this.Controls.Add(this.overviewGridView);
            this.Controls.Add(modelEntryGroup);
            this.Controls.Add(eventModelGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateEventModelForm";
            this.Text = "Crea nuovo modello evento";
            eventModelGroup.ResumeLayout(false);
            eventModelGroup.PerformLayout();
            modelEntryGroup.ResumeLayout(false);
            modelEntryGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVoceContainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.ComboBox entryTypeComboBox;
        private System.Windows.Forms.TextBox entryNameTextBox;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.DataGridView overviewGridView;
        private System.Windows.Forms.BindingSource voceBindingSource;
        private System.Windows.Forms.BindingSource tipoVoceContainerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private Presentation.DataGridView.DataGridViewEntryTypeColumn Tipo;
    }
}