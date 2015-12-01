using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ark_RCON_and_Updater.Management
{
    public class ArkServer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public int QueryPort { get; set; }
        public int RCONPort { get; set; }
        public string RCONpw { get; set; }
        public string Username { get; set; }

        public string ArkRemotePath;
        public string ArkServerPath;
        public string SteamCMDPath;

        public List<ServerTask> Tasks;

        public ArkServer()
        {

        }
        public ArkServer(int Id, string Name, string IP, int QueryPort, int RCONPort, string RCONpw, string Username)
        {
            this.Id = Id;
            this.Name = Name;
            Ip = IP;
            this.QueryPort = QueryPort;
            this.RCONPort = RCONPort;
            this.RCONpw = RCONpw;
            this.Username = Username;
        }
        public ArkServer(int Id, string Name, string IP, int QueryPort, int RCONPort, string Username)
        {
            RCONpw = string.Empty;
            this.Id = Id;
            this.Name = Name;
            Ip = IP;
            this.QueryPort = QueryPort;
            this.RCONPort = RCONPort;
            this.Username = Username;
        }

        public IPAddress getIP()
        {
            return Dns.GetHostAddresses(Ip)[0];
        }

        public IPEndPoint getQueryIPEndPoint()
        {
            return new IPEndPoint(getIP(), QueryPort);
        }

        public IPEndPoint getRCONIPEndPoint()
        {
            return new IPEndPoint(getIP(), RCONPort);
        }
    }
}
