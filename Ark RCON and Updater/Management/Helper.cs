using QueryMaster;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ark_RCON_and_Updater.Management
{
    public class Helper
    {
        StreamWriter logWriter;

        string configPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ArkRCONandUpdater\\config.cfg";
        string logPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ArkRCONandUpdater\\log.txt";

        /// <summary>
        /// Ark-Server, mit dem eine Verbindung hergestellt wurde.
        /// </summary>
        public ArkServer loadedServer;
        //public Server svr;
        public Rcon rcon;

        static Helper instance;
        public static Helper Instance
        {
            get
            {
                if (instance == null)
                    instance = new Helper();

                return instance;
            }
        }

        public Config Settings;     

        public Helper()
        {
            Settings = new Config();
            loadedServer = null;
            rcon = null;
            //Config laden bzw. erstellen...
            if (!File.Exists(configPath))
            {
                if (!Directory.Exists(Directory.GetParent(configPath).ToString()))
                    Directory.CreateDirectory(Directory.GetParent(configPath).ToString());

                SaveConfig();
            }
            else
            {
                LoadConfig();
            }
        }

        public void LoadConfig()
        {
            TextReader reader = new StreamReader(configPath);
            XmlSerializer deserializer = new XmlSerializer(Settings.GetType(), new Type[] { typeof(ArkServer) });
            Settings = (Config)deserializer.Deserialize(reader);
            reader.Close();
        }

        public void SaveConfig()
        {
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(configPath, xmlSettings))
            {
                writer.WriteStartDocument();

                XmlSerializer serializer = new XmlSerializer(Settings.GetType(), new Type[] { typeof(ArkServer) });
                serializer.Serialize(writer, Settings);

                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
        }

        /// <summary>
        /// Prüft, ob eine Verbindung zum Server hergestellt werden kann.
        /// </summary>
        /// <param name="Ip">Ip-Adresse oder Hostname</param>
        /// <param name="Port">Port</param>
        /// <returns></returns>
        public bool ServerAvailable(IPEndPoint Address)
        {
            Server svr = ServerQuery.GetServerInstance(EngineType.Source, Address, false, 500, 500);

            //Prüfen, ob Server antwortet
            if (svr.Ping() == -1)
                return false;
            else
                return true;
        }
        
        /// <summary>
        /// Prüft, ob Server ein Ark-Server ist. Voraussetzung, dass Server erreichbar ist.
        /// </summary>
        /// <param name="Address"></param>
        /// <returns></returns>
        public bool ServerIsArk(IPEndPoint Address)
        {
            Server svr = ServerQuery.GetServerInstance(EngineType.Source, Address, false, 500, 500);

            if (svr.GetInfo().Extra.GameId == Convert.ToUInt32(346110))
                return true;
            else
                return false;
        }

        public void WriteLog(string Message)
        {
            logWriter = new StreamWriter(logPath, true);
            logWriter.WriteLine(DateTime.Now + " - " + Message);
            logWriter.Close();
        }

        public bool ConnectRCON()
        {
            try
            {
                rcon = ServerQuery.GetServerInstance(EngineType.Source, loadedServer.getRCONIPEndPoint()).GetControl(loadedServer.RCONpw);
                WriteLog("Connected to RCON");
                return true;
            }
            catch
            {
                WriteLog("Connecting to RCON failed");
                return false;
            }
        }
    }
}
