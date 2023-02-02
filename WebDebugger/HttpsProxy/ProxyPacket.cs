using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDebugger.HttpsProxy {
    class ProxyPacket {
        public enum PacketType {
            GET,
            PUT,
            CONNECT
        }

        public bool hasJSON;
        public string hostname;
        public string body;
        public string[] headers;
        public PacketType type;

        public ProxyPacket() {

        }

        public void GetJSON() {

        }
    }
}
