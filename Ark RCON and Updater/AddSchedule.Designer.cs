namespace Ark_RCON_and_Updater
{
    partial class AddSchedule
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
            this.radioBtnBroadcast = new System.Windows.Forms.RadioButton();
            this.radioBtnChatMessage = new System.Windows.Forms.RadioButton();
            this.radioBtnCommand = new System.Windows.Forms.RadioButton();
            this.radioBtnRestart = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeMinuteOfHour = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTimeOfDay = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnTimeOfDay = new System.Windows.Forms.RadioButton();
            this.radioBtnMinuteofHour = new System.Windows.Forms.RadioButton();
            this.radioBtnInterval = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxRestartUpdate = new System.Windows.Forms.CheckBox();
            this.numericUpDownRestartSavePause = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartSavePause)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnBroadcast
            // 
            this.radioBtnBroadcast.AutoSize = true;
            this.radioBtnBroadcast.Location = new System.Drawing.Point(12, 12);
            this.radioBtnBroadcast.Name = "radioBtnBroadcast";
            this.radioBtnBroadcast.Size = new System.Drawing.Size(73, 17);
            this.radioBtnBroadcast.TabIndex = 0;
            this.radioBtnBroadcast.TabStop = true;
            this.radioBtnBroadcast.Text = "Broadcast";
            this.radioBtnBroadcast.UseVisualStyleBackColor = true;
            // 
            // radioBtnChatMessage
            // 
            this.radioBtnChatMessage.AutoSize = true;
            this.radioBtnChatMessage.Location = new System.Drawing.Point(12, 35);
            this.radioBtnChatMessage.Name = "radioBtnChatMessage";
            this.radioBtnChatMessage.Size = new System.Drawing.Size(93, 17);
            this.radioBtnChatMessage.TabIndex = 1;
            this.radioBtnChatMessage.TabStop = true;
            this.radioBtnChatMessage.Text = "Chat Message";
            this.radioBtnChatMessage.UseVisualStyleBackColor = true;
            // 
            // radioBtnCommand
            // 
            this.radioBtnCommand.AutoSize = true;
            this.radioBtnCommand.Location = new System.Drawing.Point(12, 58);
            this.radioBtnCommand.Name = "radioBtnCommand";
            this.radioBtnCommand.Size = new System.Drawing.Size(72, 17);
            this.radioBtnCommand.TabIndex = 2;
            this.radioBtnCommand.TabStop = true;
            this.radioBtnCommand.Text = "Command";
            this.radioBtnCommand.UseVisualStyleBackColor = true;
            // 
            // radioBtnRestart
            // 
            this.radioBtnRestart.AutoSize = true;
            this.radioBtnRestart.Location = new System.Drawing.Point(12, 81);
            this.radioBtnRestart.Name = "radioBtnRestart";
            this.radioBtnRestart.Size = new System.Drawing.Size(127, 17);
            this.radioBtnRestart.TabIndex = 3;
            this.radioBtnRestart.TabStop = true;
            this.radioBtnRestart.Text = "Restart (+SaveWorld)";
            this.radioBtnRestart.UseVisualStyleBackColor = true;
            this.radioBtnRestart.CheckedChanged += new System.EventHandler(this.radioBtnRestart_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(236, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(116, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message /\r\nCommand:";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(236, 38);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(193, 77);
            this.textBoxCommand.TabIndex = 8;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(64, 21);
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownMinutes.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Minutes";
            // 
            // dateTimeMinuteOfHour
            // 
            this.dateTimeMinuteOfHour.CustomFormat = "mm:ss";
            this.dateTimeMinuteOfHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeMinuteOfHour.Location = new System.Drawing.Point(122, 48);
            this.dateTimeMinuteOfHour.Name = "dateTimeMinuteOfHour";
            this.dateTimeMinuteOfHour.ShowUpDown = true;
            this.dateTimeMinuteOfHour.Size = new System.Drawing.Size(58, 20);
            this.dateTimeMinuteOfHour.TabIndex = 5;
            this.dateTimeMinuteOfHour.Value = new System.DateTime(2015, 11, 2, 0, 0, 0, 0);
            // 
            // dateTimeTimeOfDay
            // 
            this.dateTimeTimeOfDay.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeTimeOfDay.Location = new System.Drawing.Point(72, 74);
            this.dateTimeTimeOfDay.Name = "dateTimeTimeOfDay";
            this.dateTimeTimeOfDay.ShowUpDown = true;
            this.dateTimeTimeOfDay.Size = new System.Drawing.Size(67, 20);
            this.dateTimeTimeOfDay.TabIndex = 6;
            this.dateTimeTimeOfDay.Value = new System.DateTime(2015, 11, 2, 0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(374, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownMinutes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimeMinuteOfHour);
            this.groupBox1.Controls.Add(this.dateTimeTimeOfDay);
            this.groupBox1.Controls.Add(this.radioBtnTimeOfDay);
            this.groupBox1.Controls.Add(this.radioBtnMinuteofHour);
            this.groupBox1.Controls.Add(this.radioBtnInterval);
            this.groupBox1.Location = new System.Drawing.Point(7, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // radioBtnTimeOfDay
            // 
            this.radioBtnTimeOfDay.AutoSize = true;
            this.radioBtnTimeOfDay.Location = new System.Drawing.Point(6, 74);
            this.radioBtnTimeOfDay.Name = "radioBtnTimeOfDay";
            this.radioBtnTimeOfDay.Size = new System.Drawing.Size(60, 17);
            this.radioBtnTimeOfDay.TabIndex = 3;
            this.radioBtnTimeOfDay.TabStop = true;
            this.radioBtnTimeOfDay.Text = "Daily at";
            this.radioBtnTimeOfDay.UseVisualStyleBackColor = true;
            this.radioBtnTimeOfDay.CheckedChanged += new System.EventHandler(this.radioBtnRestart_CheckedChanged);
            // 
            // radioBtnMinuteofHour
            // 
            this.radioBtnMinuteofHour.AutoSize = true;
            this.radioBtnMinuteofHour.Location = new System.Drawing.Point(6, 48);
            this.radioBtnMinuteofHour.Name = "radioBtnMinuteofHour";
            this.radioBtnMinuteofHour.Size = new System.Drawing.Size(116, 17);
            this.radioBtnMinuteofHour.TabIndex = 3;
            this.radioBtnMinuteofHour.TabStop = true;
            this.radioBtnMinuteofHour.Text = "Delay after full hour";
            this.radioBtnMinuteofHour.UseVisualStyleBackColor = true;
            this.radioBtnMinuteofHour.CheckedChanged += new System.EventHandler(this.radioBtnRestart_CheckedChanged);
            // 
            // radioBtnInterval
            // 
            this.radioBtnInterval.AutoSize = true;
            this.radioBtnInterval.Location = new System.Drawing.Point(6, 21);
            this.radioBtnInterval.Name = "radioBtnInterval";
            this.radioBtnInterval.Size = new System.Drawing.Size(52, 17);
            this.radioBtnInterval.TabIndex = 3;
            this.radioBtnInterval.TabStop = true;
            this.radioBtnInterval.Text = "Every";
            this.radioBtnInterval.UseVisualStyleBackColor = true;
            this.radioBtnInterval.CheckedChanged += new System.EventHandler(this.radioBtnRestart_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxRestartUpdate);
            this.groupBox2.Controls.Add(this.numericUpDownRestartSavePause);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(229, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restart-Settings";
            // 
            // checkBoxRestartUpdate
            // 
            this.checkBoxRestartUpdate.AutoSize = true;
            this.checkBoxRestartUpdate.Location = new System.Drawing.Point(9, 48);
            this.checkBoxRestartUpdate.Name = "checkBoxRestartUpdate";
            this.checkBoxRestartUpdate.Size = new System.Drawing.Size(108, 17);
            this.checkBoxRestartUpdate.TabIndex = 5;
            this.checkBoxRestartUpdate.Text = "Update on restart";
            this.checkBoxRestartUpdate.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRestartSavePause
            // 
            this.numericUpDownRestartSavePause.Location = new System.Drawing.Point(151, 17);
            this.numericUpDownRestartSavePause.Name = "numericUpDownRestartSavePause";
            this.numericUpDownRestartSavePause.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownRestartSavePause.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Break after SaveWorld (in s):";
            // 
            // AddSchedule
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.radioBtnRestart);
            this.Controls.Add(this.radioBtnCommand);
            this.Controls.Add(this.radioBtnChatMessage);
            this.Controls.Add(this.radioBtnBroadcast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddSchedule";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.AddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartSavePause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnBroadcast;
        private System.Windows.Forms.RadioButton radioBtnChatMessage;
        private System.Windows.Forms.RadioButton radioBtnCommand;
        private System.Windows.Forms.RadioButton radioBtnRestart;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeMinuteOfHour;
        private System.Windows.Forms.DateTimePicker dateTimeTimeOfDay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnTimeOfDay;
        private System.Windows.Forms.RadioButton radioBtnMinuteofHour;
        private System.Windows.Forms.RadioButton radioBtnInterval;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxRestartUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDownRestartSavePause;
        private System.Windows.Forms.Label label3;
    }
}