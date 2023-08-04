using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public string MAC_Address { get; set; } = "";
        public List<string> FromFile = new();


        public string MikrotikPrintData()
        {
            Queue = "/queue simple \r\n add burst-limit=" + SpeedCalculate(UploadSpeed) + "M/" + SpeedCalculate(DownloadSpeed) 
                + "M burst-threshold=" + UploadSpeed + "M/" + DownloadSpeed + "M burst-time=8s/8s max-limit=" + UploadSpeed + "M/" 
                + DownloadSpeed + "M name=" + ClientDescription + " queue=wireless-default/wireless-default target=" + IpAddress + " \r\n";

            DhcpLeases = "/delay 1 \r\n/ip dhcp-server lease\r\n add address=" + IpAddress + " always-broadcast=yes comment="
                + ClientDescription + " disabled=no mac-address=" + MAC_Address + " server=" + DHCP_Server + " \r\n";

            FirewallList = "/delay 1 \r\n/ip firewall address-list\r\n add address=" + IpAddress + " comment="
                + ClientDescription + " list=klienci \r\n / \r\n";
            return Queue + DhcpLeases + FirewallList;
        }

        public string GetRandomMacAddress()
        {
            var random = new Random();
            var buffer = new byte[6];
            random.NextBytes(buffer);
            var result = String.Concat(buffer.Select(x => string.Format("{0}:", x.ToString("X2"))).ToArray());
            return result.TrimEnd(':');
        }

        private int SpeedCalculate(int speed)
        {
            if (speed < 10)
            {
                speed = speed + 2;
            }
            else if (speed > 1000)
            {
                speed = 1000;
            }
            else
            {
                speed = ((int)(speed * 1.1));
            }
            return speed;
        }
    }
}
