namespace Ark_RCON_and_Updater
{
    partial class ChooseServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseServer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAddServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serverView = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAddServer,
            this.toolStripButtonConnect,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(366, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAddServer
            // 
            this.toolStripBtnAddServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnAddServer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAddServer.Image")));
            this.toolStripBtnAddServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAddServer.Name = "toolStripBtnAddServer";
            this.toolStripBtnAddServer.Size = new System.Drawing.Size(68, 22);
            this.toolStripBtnAddServer.Text = "Add Server";
            this.toolStripBtnAddServer.Click += new System.EventHandler(this.toolStripBtnAddServer_Click);
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnect.Image")));
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonConnect.Text = "Connect";
            this.toolStripButtonConnect.ToolTipText = "Verbinden";
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(44, 22);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 162;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 124;
            // 
            // port
            // 
            this.port.Text = "Port";
            this.port.Width = 52;
            // 
            // serverView
            // 
            this.serverView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.IP,
            this.port});
            this.serverView.FullRowSelect = true;
            this.serverView.Location = new System.Drawing.Point(12, 30);
            this.serverView.MultiSelect = false;
            this.serverView.Name = "serverView";
            this.serverView.Size = new System.Drawing.Size(342, 144);
            this.serverView.TabIndex = 0;
            this.serverView.UseCompatibleStateImageBehavior = false;
            this.serverView.View = System.Windows.Forms.View.Details;
            this.serverView.ItemActivate += new System.EventHandler(this.toolStripButtonConnect_Click);
            this.serverView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.serverView_ItemSelectionChanged);
            // 
            // ChooseServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 186);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.serverView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChooseServer";
            this.Text = "Choose Server";
            this.Load += new System.EventHandler(this.ChooseServer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAddServer;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ListView serverView;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
    }
}