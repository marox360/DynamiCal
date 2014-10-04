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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEventForm));
            this.label1 = new System.Windows.Forms.Label();
            this.calendarSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
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
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventModelSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.addModelEventButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleziona il Calendario";
            // 
            // calendarSelectorComboBox
            // 
            this.calendarSelectorComboBox.FormattingEnabled = true;
            this.calendarSelectorComboBox.Location = new System.Drawing.Point(24, 182);
            this.calendarSelectorComboBox.Name = "calendarSelectorComboBox";
            this.calendarSelectorComboBox.Size = new System.Drawing.Size(149, 21);
            this.calendarSelectorComboBox.TabIndex = 1;
            this.calendarSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.calendarSelectorComboBox_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(110, 397);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(191, 397);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Evento";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(24, 27);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.eventNameTextBox.TabIndex = 6;
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.eventNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durata Evento";
            // 
            // durationComboBox
            // 
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Items.AddRange(new object[] {
            "Minuti",
            "Ore",
            "Giorni"});
            this.durationComboBox.Location = new System.Drawing.Point(87, 125);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(121, 21);
            this.durationComboBox.TabIndex = 8;
            this.durationComboBox.Text = "Ore/Minuti/Giorni";
            this.durationComboBox.SelectedIndexChanged += new System.EventHandler(this.durationComboBox_SelectedIndexChanged);
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.Location = new System.Drawing.Point(24, 74);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eventDateTimePicker.TabIndex = 9;
            // 
            // allDayCheckBox
            // 
            this.allDayCheckBox.AutoSize = true;
            this.allDayCheckBox.Location = new System.Drawing.Point(238, 127);
            this.allDayCheckBox.Name = "allDayCheckBox";
            this.allDayCheckBox.Size = new System.Drawing.Size(90, 17);
            this.allDayCheckBox.TabIndex = 10;
            this.allDayCheckBox.Text = "Tutto il giorno";
            this.allDayCheckBox.UseVisualStyleBackColor = true;
            this.allDayCheckBox.CheckedChanged += new System.EventHandler(this.allDayCheckBox_CheckedChanged);
            // 
            // durationUpDown
            // 
            this.durationUpDown.Location = new System.Drawing.Point(24, 126);
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
            this.durationUpDown.ValueChanged += new System.EventHandler(this.durationUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giorno-Ora di inizio";
            // 
            // entriesDataGridView
            // 
            this.entriesDataGridView.AutoGenerateColumns = false;
            this.entriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.entriesDataGridView.DataSource = this.voceBindingSource;
            this.entriesDataGridView.Location = new System.Drawing.Point(24, 229);
            this.entriesDataGridView.Name = "entriesDataGridView";
            this.entriesDataGridView.Size = new System.Drawing.Size(316, 150);
            this.entriesDataGridView.TabIndex = 14;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voceBindingSource
            // 
            this.voceBindingSource.DataSource = typeof(DynamiCal.Model.Voce);
            // 
            // eventModelSelectorComboBox
            // 
            this.eventModelSelectorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendaBindingSource, "ModelliEvento", true));
            this.eventModelSelectorComboBox.DataSource = this.agendaBindingSource;
            this.eventModelSelectorComboBox.DisplayMember = "ModelliEvento";
            this.eventModelSelectorComboBox.FormattingEnabled = true;
            this.eventModelSelectorComboBox.Location = new System.Drawing.Point(190, 181);
            this.eventModelSelectorComboBox.Name = "eventModelSelectorComboBox";
            this.eventModelSelectorComboBox.Size = new System.Drawing.Size(127, 21);
            this.eventModelSelectorComboBox.TabIndex = 15;
            this.eventModelSelectorComboBox.ValueMember = "ModelliEvento";
            this.eventModelSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.eventModelSelectorComboBox_SelectedIndexChanged);
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataSource = typeof(DynamiCal.Model.Agenda);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seleziona il Modello";
            // 
            // addModelEventButton
            // 
            this.addModelEventButton.Image = ((System.Drawing.Image)(resources.GetObject("addModelEventButton.Image")));
            this.addModelEventButton.Location = new System.Drawing.Point(317, 180);
            this.addModelEventButton.Name = "addModelEventButton";
            this.addModelEventButton.Size = new System.Drawing.Size(23, 23);
            this.addModelEventButton.TabIndex = 17;
            this.addModelEventButton.UseVisualStyleBackColor = true;
            this.addModelEventButton.Click += new System.EventHandler(this.addModelEventButton_Click);
            // 
            // CreateEventForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(363, 434);
            this.Controls.Add(this.addModelEventButton);
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
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.calendarSelectorComboBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateEventForm";
            this.Text = "Aggiungi Evento ad un Calendario";
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox calendarSelectorComboBox;
        private System.Windows.Forms.Button okButton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource voceBindingSource;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private System.Windows.Forms.Button addModelEventButton;
    }
}