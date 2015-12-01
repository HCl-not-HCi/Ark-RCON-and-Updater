namespace Ark_RCON_and_Updater
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnServerSettings = new System.Windows.Forms.ToolStripButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSchedules = new System.Windows.Forms.TabPage();
            this.toolStripSchedules = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAddTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorSchedules = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnExecuteTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDeleteTask = new System.Windows.Forms.ToolStripButton();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSchedules.SuspendLayout();
            this.toolStripSchedules.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnConnect,
            this.toolStripBtnDisconnect,
            this.toolStripSeparator1,
            this.toolStripBtnServerSettings,
            this.toolStripButtonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnConnect
            // 
            this.toolStripBtnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnConnect.Name = "toolStripBtnConnect";
            this.toolStripBtnConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripBtnConnect.Size = new System.Drawing.Size(56, 22);
            this.toolStripBtnConnect.Text = "Connect";
            this.toolStripBtnConnect.Click += new System.EventHandler(this.toolStripBtnConnect_Click);
            // 
            // toolStripBtnDisconnect
            // 
            this.toolStripBtnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDisconnect.Image")));
            this.toolStripBtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDisconnect.Name = "toolStripBtnDisconnect";
            this.toolStripBtnDisconnect.Size = new System.Drawing.Size(70, 22);
            this.toolStripBtnDisconnect.Text = "Disconnect";
            this.toolStripBtnDisconnect.Click += new System.EventHandler(this.toolStripBtnDisconnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnServerSettings
            // 
            this.toolStripBtnServerSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnServerSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnServerSettings.Image")));
            this.toolStripBtnServerSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnServerSettings.Name = "toolStripBtnServerSettings";
            this.toolStripBtnServerSettings.Size = new System.Drawing.Size(90, 22);
            this.toolStripBtnServerSettings.Text = "Server-Settings";
            this.toolStripBtnServerSettings.Click += new System.EventHandler(this.toolStripBtnServerSettings_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.tabControl1);
            this.panelMain.Location = new System.Drawing.Point(12, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(504, 395);
            this.panelMain.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSchedules);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSchedules
            // 
            this.tabSchedules.Controls.Add(this.toolStripSchedules);
            this.tabSchedules.Controls.Add(this.listViewTasks);
            this.tabSchedules.Location = new System.Drawing.Point(4, 22);
            this.tabSchedules.Name = "tabSchedules";
            this.tabSchedules.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedules.Size = new System.Drawing.Size(490, 363);
            this.tabSchedules.TabIndex = 1;
            this.tabSchedules.Text = "Schedules";
            this.tabSchedules.UseVisualStyleBackColor = true;
            // 
            // toolStripSchedules
            // 
            this.toolStripSchedules.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAddTask,
            this.toolStripSeparatorSchedules,
            this.toolStripBtnExecuteTask,
            this.toolStripBtnDeleteTask});
            this.toolStripSchedules.Location = new System.Drawing.Point(3, 3);
            this.toolStripSchedules.Name = "toolStripSchedules";
            this.toolStripSchedules.Size = new System.Drawing.Size(484, 25);
            this.toolStripSchedules.TabIndex = 2;
            this.toolStripSchedules.Text = "toolStrip2";
            // 
            // toolStripBtnAddTask
            // 
            this.toolStripBtnAddTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAddTask.Image")));
            this.toolStripBtnAddTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAddTask.Name = "toolStripBtnAddTask";
            this.toolStripBtnAddTask.Size = new System.Drawing.Size(59, 22);
            this.toolStripBtnAddTask.Text = "Add Task";
            this.toolStripBtnAddTask.Click += new System.EventHandler(this.toolstripBtnAddTask_Click);
            // 
            // toolStripSeparatorSchedules
            // 
            this.toolStripSeparatorSchedules.Name = "toolStripSeparatorSchedules";
            this.toolStripSeparatorSchedules.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnExecuteTask
            // 
            this.toolStripBtnExecuteTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnExecuteTask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExecuteTask.Image")));
            this.toolStripBtnExecuteTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExecuteTask.Name = "toolStripBtnExecuteTask";
            this.toolStripBtnExecuteTask.Size = new System.Drawing.Size(51, 22);
            this.toolStripBtnExecuteTask.Text = "Execute";
            this.toolStripBtnExecuteTask.Click += new System.EventHandler(this.toolStripBtnExecuteTask_Click);
            // 
            // toolStripBtnDeleteTask
            // 
            this.toolStripBtnDeleteTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnDeleteTask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDeleteTask.Image")));
            this.toolStripBtnDeleteTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDeleteTask.Name = "toolStripBtnDeleteTask";
            this.toolStripBtnDeleteTask.Size = new System.Drawing.Size(70, 22);
            this.toolStripBtnDeleteTask.Text = "Delete Task";
            this.toolStripBtnDeleteTask.Click += new System.EventHandler(this.toolStripBtnDeleteTask_Click);
            // 
            // listViewTasks
            // 
            this.listViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.TaskName,
            this.Time,
            this.Description});
            this.listViewTasks.GridLines = true;
            this.listViewTasks.Location = new System.Drawing.Point(6, 35);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(478, 322);
            this.listViewTasks.TabIndex = 0;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 71;
            // 
            // TaskName
            // 
            this.TaskName.Text = "Name";
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 87;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 199;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(528, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabelStatus.Text = "Disconnected";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(44, 22);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 452);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Ark RCON and Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSchedules.ResumeLayout(false);
            this.tabSchedules.PerformLayout();
            this.toolStripSchedules.ResumeLayout(false);
            this.toolStripSchedules.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnConnect;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripButton toolStripBtnDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnServerSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSchedules;
        private System.Windows.Forms.ToolStrip toolStripSchedules;
        private System.Windows.Forms.ToolStripButton toolStripBtnAddTask;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorSchedules;
        private System.Windows.Forms.ToolStripButton toolStripBtnExecuteTask;
        private System.Windows.Forms.ToolStripButton toolStripBtnDeleteTask;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader TaskName;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
    }
}

