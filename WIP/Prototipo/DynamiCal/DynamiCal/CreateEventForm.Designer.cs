namespace DynamiCal
{
    partial class CreateEventForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.calendarSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.calendarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.allDayCheckBox = new System.Windows.Forms.CheckBox();
            this.durationUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.entriesDataGridView = new DynamiCal.Presentation.DataGridView.VociDataGridView();
            this.eventModelSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.modelloEventoContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.eventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.frequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frequencyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.frequenzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.frequencyComboBox = new System.Windows.Forms.ComboBox();
            this.periodicitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.eventLocationTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelloEventoContainerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicitaBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scegli il calendario:";
            // 
            // calendarSelectorComboBox
            // 
            this.calendarSelectorComboBox.DataSource = this.calendarioBindingSource;
            this.calendarSelectorComboBox.DisplayMember = "Nome";
            this.calendarSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calendarSelectorComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarSelectorComboBox.FormattingEnabled = true;
            this.calendarSelectorComboBox.Location = new System.Drawing.Point(205, 36);
            this.calendarSelectorComboBox.Name = "calendarSelectorComboBox";
            this.calendarSelectorComboBox.Size = new System.Drawing.Size(185, 23);
            this.calendarSelectorComboBox.TabIndex = 1;
            this.calendarSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.validateForm);
            // 
            // calendarioBindingSource
            // 
            this.calendarioBindingSource.DataSource = typeof(DynamiCal.Model.Calendario);
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(217, 585);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(195, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Crea";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 585);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(194, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inserisci il nome:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(9, 37);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(185, 22);
            this.eventNameTextBox.TabIndex = 6;
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.validateForm);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inserisci la durata:";
            // 
            // durationComboBox
            // 
            this.durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Items.AddRange(new object[] {
            "Minuti",
            "Ore",
            "Giorni"});
            this.durationComboBox.Location = new System.Drawing.Point(107, 81);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(154, 21);
            this.durationComboBox.TabIndex = 8;
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.CustomFormat = "dddd, dd MMMM yyyy alle HH:mm";
            this.eventDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.eventDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventDateTimePicker.Location = new System.Drawing.Point(12, 36);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(378, 22);
            this.eventDateTimePicker.TabIndex = 9;
            // 
            // allDayCheckBox
            // 
            this.allDayCheckBox.AutoSize = true;
            this.allDayCheckBox.Location = new System.Drawing.Point(267, 83);
            this.allDayCheckBox.Name = "allDayCheckBox";
            this.allDayCheckBox.Size = new System.Drawing.Size(100, 17);
            this.allDayCheckBox.TabIndex = 10;
            this.allDayCheckBox.Text = "Tutto il giorno";
            this.allDayCheckBox.UseVisualStyleBackColor = true;
            this.allDayCheckBox.CheckedChanged += new System.EventHandler(this.allDayCheckBox_CheckedChanged);
            // 
            // durationUpDown
            // 
            this.durationUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationUpDown.Location = new System.Drawing.Point(12, 82);
            this.durationUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.durationUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationUpDown.Name = "durationUpDown";
            this.durationUpDown.Size = new System.Drawing.Size(89, 23);
            this.durationUpDown.TabIndex = 12;
            this.durationUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.durationUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.durationUpDown_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inserisci data e ora di inizio:";
            // 
            // entriesDataGridView
            // 
            this.entriesDataGridView.AllowUserToAddRows = false;
            this.entriesDataGridView.AllowUserToDeleteRows = false;
            this.entriesDataGridView.AllowUserToResizeColumns = false;
            this.entriesDataGridView.AllowUserToResizeRows = false;
            this.entriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entriesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.entriesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.entriesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.entriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.entriesDataGridView.Location = new System.Drawing.Point(6, 62);
            this.entriesDataGridView.MultiSelect = false;
            this.entriesDataGridView.Name = "entriesDataGridView";
            this.entriesDataGridView.RowHeadersVisible = false;
            this.entriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entriesDataGridView.Size = new System.Drawing.Size(384, 120);
            this.entriesDataGridView.TabIndex = 14;
            this.entriesDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.entriesDataGridView_CellValidating);
            // 
            // eventModelSelectorComboBox
            // 
            this.eventModelSelectorComboBox.DataSource = this.modelloEventoContainerBindingSource;
            this.eventModelSelectorComboBox.DisplayMember = "DisplayText";
            this.eventModelSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventModelSelectorComboBox.Location = new System.Drawing.Point(205, 35);
            this.eventModelSelectorComboBox.Name = "eventModelSelectorComboBox";
            this.eventModelSelectorComboBox.Size = new System.Drawing.Size(185, 21);
            this.eventModelSelectorComboBox.TabIndex = 15;
            this.eventModelSelectorComboBox.ValueMember = "Value";
            this.eventModelSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.eventModelSelectorComboBox_SelectedIndexChanged);
            // 
            // modelloEventoContainerBindingSource
            // 
            this.modelloEventoContainerBindingSource.DataSource = typeof(DynamiCal.Presentation.IBindingContainer);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Scegli il modello:";
            // 
            // eventDescriptionTextBox
            // 
            this.eventDescriptionTextBox.AcceptsReturn = true;
            this.eventDescriptionTextBox.Location = new System.Drawing.Point(9, 86);
            this.eventDescriptionTextBox.Multiline = true;
            this.eventDescriptionTextBox.Name = "eventDescriptionTextBox";
            this.eventDescriptionTextBox.Size = new System.Drawing.Size(381, 82);
            this.eventDescriptionTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Inserisci la descrizione:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.eventNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eventDescriptionTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.calendarSelectorComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 178);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generali";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.eventDateTimePicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.durationUpDown);
            this.groupBox2.Controls.Add(this.durationComboBox);
            this.groupBox2.Controls.Add(this.allDayCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 112);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durata";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.frequencyNumericUpDown);
            this.groupBox3.Controls.Add(this.frequencyTypeComboBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.frequencyComboBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 67);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ripetizione";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Inserisci la frequenza:";
            // 
            // frequencyNumericUpDown
            // 
            this.frequencyNumericUpDown.Enabled = false;
            this.frequencyNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyNumericUpDown.Location = new System.Drawing.Point(292, 35);
            this.frequencyNumericUpDown.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.frequencyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencyNumericUpDown.Name = "frequencyNumericUpDown";
            this.frequencyNumericUpDown.Size = new System.Drawing.Size(98, 23);
            this.frequencyNumericUpDown.TabIndex = 3;
            this.frequencyNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frequencyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencyNumericUpDown.ValueChanged += new System.EventHandler(this.SetCustomFrequency);
            // 
            // frequencyTypeComboBox
            // 
            this.frequencyTypeComboBox.DataSource = this.frequenzaBindingSource;
            this.frequencyTypeComboBox.DisplayMember = "DisplayText";
            this.frequencyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frequencyTypeComboBox.Enabled = false;
            this.frequencyTypeComboBox.FormattingEnabled = true;
            this.frequencyTypeComboBox.Location = new System.Drawing.Point(165, 35);
            this.frequencyTypeComboBox.Name = "frequencyTypeComboBox";
            this.frequencyTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.frequencyTypeComboBox.TabIndex = 2;
            this.frequencyTypeComboBox.ValueMember = "Value";
            this.frequencyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SetCustomFrequency);
            // 
            // frequenzaBindingSource
            // 
            this.frequenzaBindingSource.DataSource = typeof(DynamiCal.Presentation.IBindingContainer);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ogni quanto si ripete l\'evento?";
            // 
            // frequencyComboBox
            // 
            this.frequencyComboBox.DataSource = this.periodicitaBindingSource;
            this.frequencyComboBox.DisplayMember = "DisplayText";
            this.frequencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frequencyComboBox.FormattingEnabled = true;
            this.frequencyComboBox.Location = new System.Drawing.Point(11, 35);
            this.frequencyComboBox.Name = "frequencyComboBox";
            this.frequencyComboBox.Size = new System.Drawing.Size(148, 21);
            this.frequencyComboBox.TabIndex = 0;
            this.frequencyComboBox.ValueMember = "Value";
            this.frequencyComboBox.SelectedIndexChanged += new System.EventHandler(this.frequencyComboBox_SelectedIndexChanged);
            // 
            // periodicitaBindingSource
            // 
            this.periodicitaBindingSource.DataSource = typeof(DynamiCal.Presentation.IBindingContainer);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.eventLocationTextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.eventModelSelectorComboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.entriesDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(12, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 191);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Altro";
            // 
            // eventLocationTextBox
            // 
            this.eventLocationTextBox.Location = new System.Drawing.Point(6, 35);
            this.eventLocationTextBox.Name = "eventLocationTextBox";
            this.eventLocationTextBox.Size = new System.Drawing.Size(188, 22);
            this.eventLocationTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Inserisci il luogo:";
            // 
            // CreateEventForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(424, 618);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateEventForm";
            this.Text = "Crea un nuovo evento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEventForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelloEventoContainerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicitaBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox calendarSelectorComboBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.CheckBox allDayCheckBox;
        private System.Windows.Forms.NumericUpDown durationUpDown;
        private System.Windows.Forms.Label label4;
        private DynamiCal.Presentation.DataGridView.VociDataGridView entriesDataGridView;
        private System.Windows.Forms.ComboBox eventModelSelectorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventDescriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource calendarioBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown frequencyNumericUpDown;
        private System.Windows.Forms.ComboBox frequencyTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox frequencyComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox eventLocationTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource modelloEventoContainerBindingSource;
        private System.Windows.Forms.BindingSource periodicitaBindingSource;
        private System.Windows.Forms.BindingSource frequenzaBindingSource;
    }
}