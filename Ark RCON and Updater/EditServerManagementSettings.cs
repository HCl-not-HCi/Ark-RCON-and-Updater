using Ark_RCON_and_Updater.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ark_RCON_and_Updater
{
    public partial class EditServerManagementSettings : Form
    {
        public string RemotePath;
        public string ServerPath;
        public string SteamCMDPath;

        public EditServerManagementSettings()
        {
            InitializeComponent();
        }

        private void btnOpenRemote_Click(object sender, EventArgs e)
        {
            dialogOpenRemote.ShowDialog();
            
        }

        private void dialogOpenRemote_FileOk(object sender, CancelEventArgs e)
        {
            textBoxRemotePath.Text = dialogOpenRemote.FileName;
        }

        private void btnArkServer_Click(object sender, EventArgs e)
        {
            dialogOpenServer.ShowDialog();
        }

        private void dialogOpenServer_FileOk(object sender, CancelEventArgs e)
        {
            textBoxServerPath.Text = dialogOpenServer.FileName;
        }

        private void btnOpenSteamCMD_Click(object sender, EventArgs e)
        {
            dialogOpenSteamCMD.ShowDialog();
        }

        private void dialogOpenSteamCMD_FileOk(object sender, CancelEventArgs e)
        {
            textBoxSteamCMDPath.Text = dialogOpenSteamCMD.FileName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RemotePath = textBoxRemotePath.Text;
            ServerPath = textBoxServerPath.Text;
            SteamCMDPath = textBoxSteamCMDPath.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditServerManagementSettings_Load(object sender, EventArgs e)
        {
            textBoxRemotePath.Text = Helper.Instance.loadedServer.ArkRemotePath;
            textBoxServerPath.Text = Helper.Instance.loadedServer.ArkServerPath;
            textBoxSteamCMDPath.Text = Helper.Instance.loadedServer.SteamCMDPath;
        }
    }
}
