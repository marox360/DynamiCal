﻿namespace DynamiCal
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
            this.entriesDataGridView = new System.Windows.Forms.DataGridView();
            this.eventModelSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.modelloEventoContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.eventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dayPeriodicRadioButton = new System.Windows.Forms.RadioButton();
            this.periodicityCheckBox = new System.Windows.Forms.CheckBox();
            this.weekPeriodicRadioButton = new System.Windows.Forms.RadioButton();
            this.monthPeriodicRadioButton = new System.Windows.Forms.RadioButton();
            this.yearPeriodicRadioButton = new System.Windows.Forms.RadioButton();
            this.periodicityRadioButtonsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelloEventoContainerBindingSource)).BeginInit();
            this.periodicityRadioButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendario";
            // 
            // calendarSelectorComboBox
            // 
            this.calendarSelectorComboBox.DataSource = this.calendarioBindingSource;
            this.calendarSelectorComboBox.DisplayMember = "Nome";
            this.calendarSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calendarSelectorComboBox.FormattingEnabled = true;
            this.calendarSelectorComboBox.Location = new System.Drawing.Point(24, 410);
            this.calendarSelectorComboBox.Name = "calendarSelectorComboBox";
            this.calendarSelectorComboBox.Size = new System.Drawing.Size(149, 21);
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
            this.createButton.Location = new System.Drawing.Point(190, 621);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(149, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Crea";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(24, 621);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(149, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(24, 27);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventNameTextBox.TabIndex = 6;
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.validateForm);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durata";
            // 
            // durationComboBox
            // 
            this.durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Items.AddRange(new object[] {
            "Minuti",
            "Ore",
            "Giorni"});
            this.durationComboBox.Location = new System.Drawing.Point(87, 240);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(121, 21);
            this.durationComboBox.TabIndex = 8;
            this.durationComboBox.SelectedIndexChanged += new System.EventHandler(this.validateForm);
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.CustomFormat = "dddd, dd MMMM yyyy alle HH:mm";
            this.eventDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventDateTimePicker.Location = new System.Drawing.Point(24, 189);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(247, 20);
            this.eventDateTimePicker.TabIndex = 9;
            // 
            // allDayCheckBox
            // 
            this.allDayCheckBox.AutoSize = true;
            this.allDayCheckBox.Location = new System.Drawing.Point(238, 242);
            this.allDayCheckBox.Name = "allDayCheckBox";
            this.allDayCheckBox.Size = new System.Drawing.Size(90, 17);
            this.allDayCheckBox.TabIndex = 10;
            this.allDayCheckBox.Text = "Tutto il giorno";
            this.allDayCheckBox.UseVisualStyleBackColor = true;
            this.allDayCheckBox.CheckedChanged += new System.EventHandler(this.allDayCheckBox_CheckedChanged);
            // 
            // durationUpDown
            // 
            this.durationUpDown.Location = new System.Drawing.Point(24, 241);
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
            this.durationUpDown.Size = new System.Drawing.Size(57, 20);
            this.durationUpDown.TabIndex = 12;
            this.durationUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationUpDown.ValueChanged += new System.EventHandler(this.validateForm);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giorno-Ora di inizio";
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
            this.entriesDataGridView.Location = new System.Drawing.Point(24, 457);
            this.entriesDataGridView.MultiSelect = false;
            this.entriesDataGridView.Name = "entriesDataGridView";
            this.entriesDataGridView.RowHeadersVisible = false;
            this.entriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entriesDataGridView.Size = new System.Drawing.Size(316, 150);
            this.entriesDataGridView.TabIndex = 14;
            this.entriesDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.entriesDataGridView_CellValidating);
            // 
            // eventModelSelectorComboBox
            // 
            this.eventModelSelectorComboBox.DataSource = this.modelloEventoContainerBindingSource;
            this.eventModelSelectorComboBox.DisplayMember = "DisplayValue";
            this.eventModelSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventModelSelectorComboBox.Location = new System.Drawing.Point(190, 410);
            this.eventModelSelectorComboBox.Name = "eventModelSelectorComboBox";
            this.eventModelSelectorComboBox.Size = new System.Drawing.Size(149, 21);
            this.eventModelSelectorComboBox.TabIndex = 15;
            this.eventModelSelectorComboBox.ValueMember = "EventModel";
            this.eventModelSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.eventModelSelectorComboBox_SelectedIndexChanged);
            // 
            // modelloEventoContainerBindingSource
            // 
            this.modelloEventoContainerBindingSource.DataSource = typeof(DynamiCal.ModelloEventoContainer);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Modello";
            // 
            // eventDescriptionTextBox
            // 
            this.eventDescriptionTextBox.AcceptsReturn = true;
            this.eventDescriptionTextBox.Location = new System.Drawing.Point(24, 74);
            this.eventDescriptionTextBox.Multiline = true;
            this.eventDescriptionTextBox.Name = "eventDescriptionTextBox";
            this.eventDescriptionTextBox.Size = new System.Drawing.Size(316, 82);
            this.eventDescriptionTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Descrizione";
            // 
            // dayPeriodicRadioButton
            // 
            this.dayPeriodicRadioButton.AutoSize = true;
            this.dayPeriodicRadioButton.Location = new System.Drawing.Point(6, 8);
            this.dayPeriodicRadioButton.Name = "dayPeriodicRadioButton";
            this.dayPeriodicRadioButton.Size = new System.Drawing.Size(93, 17);
            this.dayPeriodicRadioButton.TabIndex = 20;
            this.dayPeriodicRadioButton.TabStop = true;
            this.dayPeriodicRadioButton.Text = "Ogni GIORNO";
            this.dayPeriodicRadioButton.UseVisualStyleBackColor = true;
            // 
            // periodicityCheckBox
            // 
            this.periodicityCheckBox.AutoSize = true;
            this.periodicityCheckBox.Location = new System.Drawing.Point(79, 315);
            this.periodicityCheckBox.Name = "periodicityCheckBox";
            this.periodicityCheckBox.Size = new System.Drawing.Size(70, 17);
            this.periodicityCheckBox.TabIndex = 21;
            this.periodicityCheckBox.Text = "Periodico";
            this.periodicityCheckBox.UseVisualStyleBackColor = true;
            this.periodicityCheckBox.CheckedChanged += new System.EventHandler(this.periodicityCheckBox_CheckedChanged);
            // 
            // weekPeriodicRadioButton
            // 
            this.weekPeriodicRadioButton.AutoSize = true;
            this.weekPeriodicRadioButton.Location = new System.Drawing.Point(6, 29);
            this.weekPeriodicRadioButton.Name = "weekPeriodicRadioButton";
            this.weekPeriodicRadioButton.Size = new System.Drawing.Size(112, 17);
            this.weekPeriodicRadioButton.TabIndex = 22;
            this.weekPeriodicRadioButton.TabStop = true;
            this.weekPeriodicRadioButton.Text = "Ogni SETTIMANA";
            this.weekPeriodicRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthPeriodicRadioButton
            // 
            this.monthPeriodicRadioButton.AutoSize = true;
            this.monthPeriodicRadioButton.Location = new System.Drawing.Point(6, 52);
            this.monthPeriodicRadioButton.Name = "monthPeriodicRadioButton";
            this.monthPeriodicRadioButton.Size = new System.Drawing.Size(80, 17);
            this.monthPeriodicRadioButton.TabIndex = 23;
            this.monthPeriodicRadioButton.TabStop = true;
            this.monthPeriodicRadioButton.Text = "Ogni MESE";
            this.monthPeriodicRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearPeriodicRadioButton
            // 
            this.yearPeriodicRadioButton.AutoSize = true;
            this.yearPeriodicRadioButton.Location = new System.Drawing.Point(6, 75);
            this.yearPeriodicRadioButton.Name = "yearPeriodicRadioButton";
            this.yearPeriodicRadioButton.Size = new System.Drawing.Size(81, 17);
            this.yearPeriodicRadioButton.TabIndex = 24;
            this.yearPeriodicRadioButton.TabStop = true;
            this.yearPeriodicRadioButton.Text = "Ogni ANNO";
            this.yearPeriodicRadioButton.UseVisualStyleBackColor = true;
            // 
            // periodicityRadioButtonsPanel
            // 
            this.periodicityRadioButtonsPanel.Controls.Add(this.weekPeriodicRadioButton);
            this.periodicityRadioButtonsPanel.Controls.Add(this.yearPeriodicRadioButton);
            this.periodicityRadioButtonsPanel.Controls.Add(this.dayPeriodicRadioButton);
            this.periodicityRadioButtonsPanel.Controls.Add(this.monthPeriodicRadioButton);
            this.periodicityRadioButtonsPanel.Enabled = false;
            this.periodicityRadioButtonsPanel.Location = new System.Drawing.Point(172, 276);
            this.periodicityRadioButtonsPanel.Name = "periodicityRadioButtonsPanel";
            this.periodicityRadioButtonsPanel.Size = new System.Drawing.Size(119, 100);
            this.periodicityRadioButtonsPanel.TabIndex = 25;
            // 
            // CreateEventForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(363, 655);
            this.Controls.Add(this.periodicityRadioButtonsPanel);
            this.Controls.Add(this.periodicityCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eventDescriptionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eventModelSelectorComboBox);
            this.Controls.Add(this.entriesDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.durationUpDown);
            this.Controls.Add(this.allDayCheckBox);
            this.Controls.Add(this.eventDateTimePicker);
            this.Controls.Add(this.durationComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.calendarSelectorComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateEventForm";
            this.Text = "Aggiungi Evento ad un Calendario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEventForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelloEventoContainerBindingSource)).EndInit();
            this.periodicityRadioButtonsPanel.ResumeLayout(false);
            this.periodicityRadioButtonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView entriesDataGridView;
        private System.Windows.Forms.ComboBox eventModelSelectorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventDescriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton dayPeriodicRadioButton;
        private System.Windows.Forms.CheckBox periodicityCheckBox;
        private System.Windows.Forms.RadioButton weekPeriodicRadioButton;
        private System.Windows.Forms.RadioButton monthPeriodicRadioButton;
        private System.Windows.Forms.RadioButton yearPeriodicRadioButton;
        private System.Windows.Forms.Panel periodicityRadioButtonsPanel;
        private System.Windows.Forms.BindingSource calendarioBindingSource;
        private System.Windows.Forms.BindingSource modelloEventoContainerBindingSource;
    }
}