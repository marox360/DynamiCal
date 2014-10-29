namespace DynamiCal.View.TextBox
{
    partial class SearchBoxPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBoxPanel));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.searchBox = new DynamiCal.View.TextBox.SearchBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox.Size = new System.Drawing.Size(23, 23);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBox.Location = new System.Drawing.Point(23, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Inserisci un testo da cercare";
            this.searchBox.Size = new System.Drawing.Size(202, 22);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "Inserisci un testo da cercare";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchBox_PreviewKeyDown);
            // 
            // SearchBoxPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SearchBoxPanel";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 2, 5);
            this.Size = new System.Drawing.Size(227, 30);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private SearchBox searchBox;

    }
}
