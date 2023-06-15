using System.IO;


namespace MikrotikAddClient
{
    public partial class MikrotikAddClient : Form
    {
        string ipAddress = "";
        string clientDescription = "";
        int UploadSpeed = 0;
        int DownloadSpeed = 0;
        string DHCP_Server = "";
        string MAC_Address = "";

        public MikrotikAddClient()
        {
            InitializeComponent();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            ipAddress = ipaddress_box.Text;
            clientDescription = description_box.Text;
            DownloadSpeed = int.Parse(DownloadSpeedBox.Text);
            UploadSpeed = int.Parse(UploadSpeedBox.Text);
            MAC_Address = MacAddressBox.Text;
            DHCP_Server = DHCP_Value.Text;

            clientInfoPrint.Text = "/queue simple\n" +
                "add burst-limit=" + ((int)(UploadSpeed * 1.1)) + "M/" + ((int)(DownloadSpeed * 1.1)) + "M burst-threshold=" + UploadSpeed + "M/" + DownloadSpeed + "M burst-time=8s/8s max-limit=" + UploadSpeed + "M/" + DownloadSpeed + "M name=" + clientDescription + " queue=wireless-default/wireless-default target=" + ipAddress +
                "\n/ip firewall address-list\nadd address=" + ipAddress + " comment=" + clientDescription + " list=klienci" +
                "\n/ip dhcp-server lease\nadd address=" + ipAddress + " always-broadcast=yes comment=" + clientDescription + " disabled=no mac-address=" + MAC_Address + " server=" + DHCP_Server;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] FromFile = File.ReadAllLines(@"DHCP-Servers.txt");
            DHCP_Value.DataSource = FromFile;
        }
    }
}