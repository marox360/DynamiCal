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
            this.entriesdataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.entriesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // entriesdataGridView
            // 
            this.entriesdataGridView.AllowUserToAddRows = false;
            this.entriesdataGridView.AllowUserToDeleteRows = false;
            this.entriesdataGridView.AutoGenerateColumns = false;
            this.entriesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entriesdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.entriesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entriesdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.entriesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entriesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.valoreDataGridViewTextBoxColumn});
            this.entriesdataGridView.DataSource = this.voceBindingSource;
            this.entriesdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesdataGridView.Location = new System.Drawing.Point(0, 250);
            this.entriesdataGridView.MultiSelect = false;
            this.entriesdataGridView.Name = "entriesdataGridView";
            this.entriesdataGridView.ReadOnly = true;
            this.entriesdataGridView.RowHeadersVisible = false;
            this.entriesdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.entriesdataGridView.Size = new System.Drawing.Size(237, 157);
            this.entriesdataGridView.TabIndex = 0;
            this.entriesdataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.entriesdataGridView_CellPainting);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(237, 250);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoreDataGridViewTextBoxColumn
            // 
            this.valoreDataGridViewTextBoxColumn.DataPropertyName = "Valore";
            this.valoreDataGridViewTextBoxColumn.HeaderText = "Valore";
            this.valoreDataGridViewTextBoxColumn.Name = "valoreDataGridViewTextBoxColumn";
            this.valoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voceBindingSource
            // 
            this.voceBindingSource.DataSource = typeof(DynamiCal.Model.IVoce);
            // 
            // EventPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entriesdataGridView);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "EventPanel";
            this.Size = new System.Drawing.Size(237, 407);
            ((System.ComponentModel.ISupportInitialize)(this.entriesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView entriesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource voceBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

    }
}
