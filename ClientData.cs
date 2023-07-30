using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikrotikAddClient
{
    public class ClientData
    {
        public string Queue { get; set; } = "";
        public string DhcpLeases { get; set; } = "";
        public string FirewallList { get; set; } = "";
        public string IpAddress { get; set; } = "";
        public string ClientDescription { get; set; } = "";
        public int UploadSpeed { get; set; } = 0;    
        public int DownloadSpeed { get; set; } = 0;  
        public string DHCP_Server { get; set; } = "";
        public int DownloadBurst { get; set; } = 0;
        public int UploadBurst { get; set; } = 0;
        public string MAC_Address { get; set; } = "";
        public List<string> FromFile = new();
    }
}
