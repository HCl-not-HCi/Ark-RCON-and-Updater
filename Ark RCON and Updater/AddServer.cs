using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using QueryMaster;
using Ark_RCON_and_Updater.Management;

namespace Ark_RCON_and_Updater
{
    public partial class AddServer : Form
    {
        IPAddress ip;

        public AddServer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //Hostname auflösen 
                ip = Dns.GetHostAddresses(textBoxIp.Text)[0];
                IPEndPoint address = new IPEndPoint(ip, Convert.ToInt32(numericPort.Value));
                
                //Prüfen, ob Server antwortet
                if (!Helper.Instance.ServerAvailable(address))
                    MessageBox.Show("Hostname/IP-Adresse bzw. Port ungültig!", "Ungültige Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Prüfen, ob es sich um Ark handelt
                else if (Helper.Instance.ServerIsArk(address))
                {
                    //Prüfen, ob RCON-pw korrekt
                    IPEndPoint rconAddress = new IPEndPoint(ip, Convert.ToInt32(numericRCONPort.Value));
                    Server svrRcon = ServerQuery.GetServerInstance(EngineType.Source, rconAddress, false, 500, 500);
                    

                    try
                    {
                        Rcon rcon = svrRcon.GetControl(textBoxPassword.Text);

                        //ServerId zum Speichern finden
                        int id;
                        if (Helper.Instance.Settings.Servers.Count > 0)
                            id = Helper.Instance.Settings.Servers[Helper.Instance.Settings.Servers.Count - 1].Id + 1;
                        else
                            id = 0;

                        //Wenn ausgewählt, Passwort speichern
                        if (checkBoxSavePw.Checked)
                            Helper.Instance.Settings.Servers.Add(new ArkServer(id, textBoxName.Text, address.Address.ToString(), address.Port, rconAddress.Port, textBoxPassword.Text, textBoxUsername.Text));
                        else
                            Helper.Instance.Settings.Servers.Add(new ArkServer(id, textBoxName.Text, address.Address.ToString(), address.Port, rconAddress.Port, textBoxUsername.Text));

                        //Einstellungen speichern
                        Helper.Instance.SaveConfig();
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ungültiges RCON-Passwort oder ungültiger Port", "Ungültige RCON-Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Das ist kein Ark!", "Falsches Spiel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Hostname/IP-Adresse bzw. Port ungültig!", "Ungültige Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
