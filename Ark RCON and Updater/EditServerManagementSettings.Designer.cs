namespace Ark_RCON_and_Updater
{
    partial class EditServerManagementSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.dialogOpenRemote = new System.Windows.Forms.OpenFileDialog();
            this.textBoxRemotePath = new System.Windows.Forms.TextBox();
            this.btnOpenRemote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServerPath = new System.Windows.Forms.TextBox();
            this.btnArkServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSteamCMDPath = new System.Windows.Forms.TextBox();
            this.btnOpenSteamCMD = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dialogOpenServer = new System.Windows.Forms.OpenFileDialog();
            this.dialogOpenSteamCMD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArkRemote Path:";
            // 
            // dialogOpenRemote
            // 
            this.dialogOpenRemote.FileName = "openFileDialog1";
            this.dialogOpenRemote.Filter = " Anwendung|*.exe";
            this.dialogOpenRemote.FileOk += new System.ComponentModel.CancelEventHandler(this.dialogOpenRemote_FileOk);
            // 
            // textBoxRemotePath
            // 
            this.textBoxRemotePath.Location = new System.Drawing.Point(106, 9);
            this.textBoxRemotePath.Name = "textBoxRemotePath";
            this.textBoxRemotePath.Size = new System.Drawing.Size(217, 20);
            this.textBoxRemotePath.TabIndex = 1;
            // 
            // btnOpenRemote
            // 
            this.btnOpenRemote.Location = new System.Drawing.Point(329, 7);
            this.btnOpenRemote.Name = "btnOpenRemote";
            this.btnOpenRemote.Size = new System.Drawing.Size(75, 23);
            this.btnOpenRemote.TabIndex = 2;
            this.btnOpenRemote.Text = "Open";
            this.btnOpenRemote.UseVisualStyleBackColor = true;
            this.btnOpenRemote.Click += new System.EventHandler(this.btnOpenRemote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ark Server Path:";
            // 
            // textBoxServerPath
            // 
            this.textBoxServerPath.Location = new System.Drawing.Point(106, 35);
            this.textBoxServerPath.Name = "textBoxServerPath";
            this.textBoxServerPath.Size = new System.Drawing.Size(217, 20);
            this.textBoxServerPath.TabIndex = 1;
            // 
            // btnArkServer
            // 
            this.btnArkServer.Location = new System.Drawing.Point(329, 33);
            this.btnArkServer.Name = "btnArkServer";
            this.btnArkServer.Size = new System.Drawing.Size(75, 23);
            this.btnArkServer.TabIndex = 2;
            this.btnArkServer.Text = "Open";
            this.btnArkServer.UseVisualStyleBackColor = true;
            this.btnArkServer.Click += new System.EventHandler(this.btnArkServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SteamCMD Path:";
            // 
            // textBoxSteamCMDPath
            // 
            this.textBoxSteamCMDPath.Location = new System.Drawing.Point(106, 61);
            this.textBoxSteamCMDPath.Name = "textBoxSteamCMDPath";
            this.textBoxSteamCMDPath.Size = new System.Drawing.Size(217, 20);
            this.textBoxSteamCMDPath.TabIndex = 1;
            // 
            // btnOpenSteamCMD
            // 
            this.btnOpenSteamCMD.Location = new System.Drawing.Point(329, 62);
            this.btnOpenSteamCMD.Name = "btnOpenSteamCMD";
            this.btnOpenSteamCMD.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSteamCMD.TabIndex = 2;
            this.btnOpenSteamCMD.Text = "Open";
            this.btnOpenSteamCMD.UseVisualStyleBackColor = true;
            this.btnOpenSteamCMD.Click += new System.EventHandler(this.btnOpenSteamCMD_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(396, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(315, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dialogOpenServer
            // 
            this.dialogOpenServer.FileName = "openFileDialog1";
            this.dialogOpenServer.Filter = "Anwendung|*.exe";
            this.dialogOpenServer.FileOk += new System.ComponentModel.CancelEventHandler(this.dialogOpenServer_FileOk);
            // 
            // dialogOpenSteamCMD
            // 
            this.dialogOpenSteamCMD.FileName = "openFileDialog2";
            this.dialogOpenSteamCMD.Filter = "Anwendung|*.exe";
            this.dialogOpenSteamCMD.FileOk += new System.ComponentModel.CancelEventHandler(this.dialogOpenSteamCMD_FileOk);
            // 
            // EditServerManagementSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(483, 142);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOpenSteamCMD);
            this.Controls.Add(this.btnArkServer);
            this.Controls.Add(this.btnOpenRemote);
            this.Controls.Add(this.textBoxSteamCMDPath);
            this.Controls.Add(this.textBoxServerPath);
            this.Controls.Add(this.textBoxRemotePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditServerManagementSettings";
            this.Text = "Edit Server Settings";
            this.Load += new System.EventHandler(this.EditServerManagementSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dialogOpenRemote;
        private System.Windows.Forms.TextBox textBoxRemotePath;
        private System.Windows.Forms.Button btnOpenRemote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServerPath;
        private System.Windows.Forms.Button btnArkServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSteamCMDPath;
        private System.Windows.Forms.Button btnOpenSteamCMD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog dialogOpenServer;
        private System.Windows.Forms.OpenFileDialog dialogOpenSteamCMD;
    }
}