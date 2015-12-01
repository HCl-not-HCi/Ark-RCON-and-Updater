using Ark_RCON_and_Updater.Management;
using QueryMaster;
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
    public partial class ChooseServer : Form
    {
        AddServer formAddServer;
        RCONPwInput formRCONPwInput;

        /// <summary>
        /// Server, der zum Verbinden ausgewählt wurde.
        /// </summary>
        public ArkServer Server;

        public ChooseServer()
        {
            InitializeComponent();
        }

        private void ChooseServer_Load(object sender, EventArgs e)
        {
            toolStripButtonConnect.Visible = false;
            toolStripButtonDelete.Visible = false;

            LoadServers();
        }

        private void toolStripBtnAddServer_Click(object sender, EventArgs e)
        {
            formAddServer = new AddServer();
            formAddServer.Show();
            formAddServer.FormClosing += FormAddServer_FormClosing;
            Enabled = false;
        }

        private void FormAddServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverView.Items.Clear();
            LoadServers();
            Enabled = true;
        }

        private void serverView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (serverView.SelectedItems.Count > 0)
            {
                toolStripButtonConnect.Visible = true;
                toolStripButtonDelete.Visible = true;
            }
            else
            {
                toolStripButtonConnect.Visible = false;
                toolStripButtonDelete.Visible = false;
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Helper.Instance.Settings.Servers.RemoveAt(Helper.Instance.Settings.Servers.FindIndex(x => x.Id == (int)serverView.SelectedItems[0].Tag));
            Helper.Instance.SaveConfig();
            serverView.Items.Remove(serverView.SelectedItems[0]);
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            if (serverView.SelectedItems.Count > 0)
            {
                try
                {
                    Server = Helper.Instance.Settings.Servers.Find(x => x.Id == (int)serverView.SelectedItems[0].Tag);
                    if (Helper.Instance.ServerAvailable(Server.getQueryIPEndPoint()) && Helper.Instance.ServerIsArk(Server.getQueryIPEndPoint()))
                    {
                        //Prüfen, ob Pw gespeichert wurde
                        if (Server.RCONpw == string.Empty)
                        {
                            formRCONPwInput = new RCONPwInput();
                            formRCONPwInput.Show();
                            formRCONPwInput.FormClosing += FormRCONPwInput_FormClosing;
                        }
                        else
                        {
                            if (checkRCON(Server.RCONpw))
                                Close();
                            else
                                Server = null;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Verbindung zum Server konnte nicht hergestellt werden!", "Verbindung zum Server fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Server = null;
                    }
                }
                catch
                {
                    MessageBox.Show("Verbindung zum Server konnte nicht hergestellt werden!", "Verbindung zum Server fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Server = null;
                }
            }
        }

        private void FormRCONPwInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formRCONPwInput.Pw != string.Empty)
            {
                if (checkRCON(formRCONPwInput.Pw))
                {
                    Server.RCONpw = formRCONPwInput.Pw;
                    Close();
                }
                else
                    Server = null;
            }

        }

        private void LoadServers()
        {
            Helper.Instance.LoadConfig();
            //Serverliste aus Config füllen
            if (Helper.Instance.Settings.Servers != null)
            {
                foreach (ArkServer server in Helper.Instance.Settings.Servers)
                {
                    string[] arrServer = new string[4];
                    arrServer[0] = server.Name;
                    arrServer[1] = server.Ip.ToString();
                    arrServer[2] = server.QueryPort.ToString();
                    arrServer[3] = server.RCONPort.ToString();
                    ListViewItem item = new ListViewItem(arrServer);
                    item.Tag = server.Id;
                    serverView.Items.Add(item);
                }
            }
        }

        private bool checkRCON(string RCONPw)
        {
            try
            {
                Server svrRcon = ServerQuery.GetServerInstance(EngineType.Source, Server.getRCONIPEndPoint(), false, 500, 500);
                svrRcon.GetControl(RCONPw);
                return true;
            }
            catch
            {
                MessageBox.Show("Verbindung zum Server-RCON konnte nicht hergestellt werden!", "Verbindung zum Server-RCON fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
