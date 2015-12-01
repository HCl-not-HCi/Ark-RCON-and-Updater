using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ark_RCON_and_Updater.Management
{
    [Serializable()]
    [XmlRoot(Namespace = "Ark_RCON_and_Updater")]
    [XmlInclude(typeof(ArkServer))]
    public class Config
    {
        public Config()
        {
            Servers = new List<ArkServer>();
        }

        public List<ArkServer> Servers;
    }
}
