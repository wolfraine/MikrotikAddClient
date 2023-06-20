using System.IO;
using System.Windows.Forms;


namespace MikrotikAddClient
{
    public partial class MikrotikAddClient : Form
    {
        string clipboardtext = "";
        string ipAddress = "";
        string clientDescription = "";
        int UploadSpeed = 0;
        int DownloadSpeed = 0;
        string DHCP_Server = "";
        string MAC_Address = "";
        List<string> FromFile = new List<string>();

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

            clipboardtext = "/queue simple\n" +
                "add burst-limit=" + ((int)(UploadSpeed * 1.1)) + "M/" + ((int)(DownloadSpeed * 1.1)) + "M burst-threshold=" + UploadSpeed + "M/" + DownloadSpeed + "M burst-time=8s/8s max-limit=" + UploadSpeed + "M/" + DownloadSpeed + "M name=" + clientDescription + " queue=wireless-default/wireless-default target=" + ipAddress +
                "\n/delay 1\n/ip firewall address-list\nadd address=" + ipAddress + " comment=" + clientDescription + " list=klienci" +
                "\n/delay 1\n/ip dhcp-server lease\nadd address=" + ipAddress + " always-broadcast=yes comment=" + clientDescription + " disabled=no mac-address=" + MAC_Address + " server=" + DHCP_Server + " \n/delay 1";
            clientInfoPrint.Text = clipboardtext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FromFile.AddRange(File.ReadAllLines(@"DHCP-Servers.txt"));
            UpdateForm();
        }

        private void AddDHCP_ServerButton_Click(object sender, EventArgs e)
        {
            FromFile.Add(NewDHCP_ServerBox.Text);
            NewDHCP_ServerBox.Clear();
            UpdateForm();
        }
        private void UpdateForm()
        {
            DHCP_Value.Items.Clear();
            DHCP_Value.Items.AddRange(FromFile.ToArray());
            DHCP_ServerList.Items.Clear();
            DHCP_ServerList.Items.AddRange(FromFile.ToArray());
        }

        private void Copy_Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(clipboardtext);
        }
    }
}