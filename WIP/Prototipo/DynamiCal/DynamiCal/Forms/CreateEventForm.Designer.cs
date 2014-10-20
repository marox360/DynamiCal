namespace DynamiCal.Forms
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.GroupBox groupBox4;
            System.Windows.Forms.Label label9;
            this.calendarSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.calendarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.allDayCheckBox = new System.Windows.Forms.CheckBox();
            this.durationUpDown = new System.Windows.Forms.NumericUpDown();
            this.entriesDataGridView = new DynamiCal.Presentation.DataGridView.VociDataGridView();
            this.eventModelSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.modelloEventoContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.frequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frequencyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.frequenzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frequencyComboBox = new System.Windows.Forms.ComboBox();
            this.periodicitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventLocationTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelloEventoContainerBindingSource)).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicitaBindingSource)).BeginInit();
            groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(202, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 13);
            label1.TabIndex = 0;
            label1.Text = "Scegli il calendario:";
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
            this.calendarioBindingSource.DataSource = typeof(DynamiCal.Model.Calendars.Calendario);
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
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 13);
            label2.TabIndex = 5;
            label2.Text = "Inserisci il nome:";
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
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 13);
            label3.TabIndex = 7;
            label3.Text = "Inserisci la durata:";
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
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(150, 13);
            label4.TabIndex = 13;
            label4.Text = "Inserisci data e ora di inizio:";
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
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(202, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 13);
            label5.TabIndex = 16;
            label5.Text = "Scegli il modello:";
            // 
            // eventDescriptionTextBox
            // 
            this.eventDescriptionTextBox.AcceptsReturn = true;
            this.eventDescriptionTextBox.Location = new System.Drawing.Point(9, 86);
            this.eventDescriptionTextBox.Multiline = true;
            this.eventDescriptionTextBox.Name = "eventDescriptionTextBox";
            this.eventDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventDescriptionTextBox.Size = new System.Drawing.Size(381, 82);
            this.eventDescriptionTextBox.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 70);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(124, 13);
            label6.TabIndex = 19;
            label6.Text = "Inserisci la descrizione:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.eventNameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(this.eventDescriptionTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(this.calendarSelectorComboBox);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(400, 178);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generali";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(this.eventDateTimePicker);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(this.durationUpDown);
            groupBox2.Controls.Add(this.durationComboBox);
            groupBox2.Controls.Add(this.allDayCheckBox);
            groupBox2.Location = new System.Drawing.Point(12, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(400, 112);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Durata";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(this.frequencyNumericUpDown);
            groupBox3.Controls.Add(this.frequencyTypeComboBox);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(this.frequencyComboBox);
            groupBox3.Location = new System.Drawing.Point(12, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(400, 67);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ripetizione";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(272, 19);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(118, 13);
            label8.TabIndex = 4;
            label8.Text = "Inserisci la frequenza:";
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
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(9, 19);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(167, 13);
            label7.TabIndex = 1;
            label7.Text = "Ogni quanto si ripete l\'evento?";
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
            groupBox4.Controls.Add(this.eventLocationTextBox);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(this.eventModelSelectorComboBox);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(this.entriesDataGridView);
            groupBox4.Location = new System.Drawing.Point(12, 388);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(400, 191);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Altro";
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
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(3, 19);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(94, 13);
            label9.TabIndex = 0;
            label9.Text = "Inserisci il luogo:";
            // 
            // CreateEventForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(424, 618);
            this.Controls.Add(groupBox4);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicitaBindingSource)).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox calendarSelectorComboBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.CheckBox allDayCheckBox;
        private System.Windows.Forms.NumericUpDown durationUpDown;
        private Presentation.DataGridView.VociDataGridView entriesDataGridView;
        private System.Windows.Forms.ComboBox eventModelSelectorComboBox;
        private System.Windows.Forms.TextBox eventDescriptionTextBox;
        private System.Windows.Forms.BindingSource calendarioBindingSource;
        private System.Windows.Forms.NumericUpDown frequencyNumericUpDown;
        private System.Windows.Forms.ComboBox frequencyTypeComboBox;
        private System.Windows.Forms.ComboBox frequencyComboBox;
        private System.Windows.Forms.TextBox eventLocationTextBox;
        private System.Windows.Forms.BindingSource modelloEventoContainerBindingSource;
        private System.Windows.Forms.BindingSource periodicitaBindingSource;
        private System.Windows.Forms.BindingSource frequenzaBindingSource;
        internal System.Windows.Forms.DateTimePicker eventDateTimePicker;
    }
}