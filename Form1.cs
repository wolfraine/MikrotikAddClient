using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;


namespace MikrotikAddClient
{
    public partial class MikrotikAddClient : Form
    {
        //string queue = "";
        //string dhcpleases = "";
        //string firewall_list = "";
        string ClipboardText = "";
        //string ipAddress = "";
        //string clientDescription = "";
        //int UploadSpeed = 0;
        //int DownloadSpeed = 0;
        //string DHCP_Server = "";
        //string MAC_Address = "";
        List<string> FromFile = new();
        readonly string FileName = "DHCP-Servers.txt";


        public MikrotikAddClient()
        {
            InitializeComponent();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            ClientData clientData = new ClientData();
            
            clientData.IpAddress = ipaddress_box.Text;
            clientData.ClientDescription = description_box.Text;
            clientData.DownloadSpeed = int.Parse(DownloadSpeedBox.Text);
            clientData.UploadSpeed = int.Parse(UploadSpeedBox.Text);
            clientData.MAC_Address = MacAddressBox.Text;
            clientData.DHCP_Server = DHCP_Value.Text;

            if (clientData.DownloadSpeed < 10)
            {
                clientData.DownloadBurst = clientData.DownloadSpeed + 2;
            }
            else if (clientData.DownloadSpeed > 1000)
            {
                clientData.DownloadSpeed = 1000;
            }
            else
            {
                clientData.DownloadBurst = ((int)(clientData.DownloadSpeed * 1.1));
            }

            if (clientData.UploadSpeed < 10)
            {
                clientData.UploadBurst = clientData.DownloadSpeed + 2;
            }
            else if (clientData.UploadSpeed > 1000)
            {
                clientData.UploadSpeed = 1000;
            }
            else
            {
                clientData.UploadBurst = ((int)(clientData.UploadSpeed * 1.1));
            }

            clientData.Queue = "/Queue simple\r\n add burst-limit=" + clientData.DownloadBurst + "M/" + clientData.UploadBurst + "M burst-threshold=" + clientData.UploadSpeed + "M/" + clientData.DownloadSpeed + "M burst-time=8s/8s max-limit=" + clientData.UploadSpeed + "M/" + clientData.DownloadSpeed + "M name=" + clientData.ClientDescription + " Queue=wireless-default/wireless-default target=" + clientData.IpAddress + " \r\n"; 
            clientData.DhcpLeases = "/delay 1 \r\n/ip dhcp-server lease\r\n add address=" + clientData.IpAddress + " always-broadcast=yes comment=" + clientData.ClientDescription + " disabled=no mac-address=" + clientData.MAC_Address + " server=" + clientData.DHCP_Server + " \r\n";
            clientData.FirewallList = "/delay 1 \r\n/ip firewall address-list\r\n add address=" + clientData.IpAddress + " comment=" + clientData.ClientDescription + " list=klienci \r\n";

            ClipboardText = clientData.Queue + clientData.DhcpLeases + clientData.FirewallList;
            if (description_box.Text.Length == 0)
            {

            }
            else
            {
                clientInfoPrint.Text = ClipboardText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DownloadSpeedBox.Text = "10";
            UploadSpeedBox.Text = "2";

            if (!File.Exists(FileName))
            {
                using StreamWriter sw = File.CreateText(FileName);
                sw.WriteLine("List is Empty");
            }

            FromFile.AddRange(File.ReadAllLines(FileName));
            UpdateForm();
        }

        private void AddDHCP_ServerButton_Click(object sender, EventArgs e)
        {
            FromFile.Add(NewDHCP_ServerBox.Text);
            NewDHCP_ServerBox.Clear();
            SaveToFile();
            UpdateForm();
        }

        private void SaveToFile()
        {
            using StreamWriter sw = File.CreateText(FileName);
            foreach (var line in FromFile)
            {
                sw.WriteLine(line);
            }
        }

        public static string GetRandomMacAddress()
        {
            var random = new Random();
            var buffer = new byte[6];
            random.NextBytes(buffer);
            var result = String.Concat(buffer.Select(x => string.Format("{0}:", x.ToString("X2"))).ToArray());
            return result.TrimEnd(':');
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
            Clipboard.SetDataObject(ClipboardText);
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            Update_Box.Text = DHCP_ServerList.Text;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int index = DHCP_ServerList.SelectedIndex;
            FromFile.RemoveAt(index);
            FromFile.Insert(index, Update_Box.Text);
            SaveToFile();
            UpdateForm();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            FromFile.RemoveAt(DHCP_ServerList.SelectedIndex);
            SaveToFile();
            UpdateForm();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            ipaddress_box.Clear();
            description_box.Clear();
            DownloadSpeedBox.Clear();
            UploadSpeedBox.Clear();
            MacAddressBox.Clear();
            clientInfoPrint.Clear();
            DHCP_Value.SelectedItem = null;
        }

        private void DownloadSpeedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void UploadSpeedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void GenerateMacButton_Click(object sender, EventArgs e)
        {
            MacAddressBox.Text = GetRandomMacAddress();
        }

        private void clientInfoPrint_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientInfoPrint.Text))
            {
                Copy_Button.Enabled = false;
            }
            else
            {
                Copy_Button.Enabled = true;
            }
        }

        private void ipaddress_box_TextChanged(object sender, EventArgs e)
        {
            string tmp = ipaddress_box.Text;
            bool isValidIp = tmp.Count(c => c == '.') == 3 && IPAddress.TryParse(tmp, out _);
            if (ipaddress_box.Text == null)
            {
                Ip_Error.Text = "";
                Ip_Error.ForeColor = Color.Black;
                Ip_Error.Visible = false;
            }
            else if (isValidIp)
            {
                Ip_Error.Text = "Ip Addres is Correct";
                Ip_Error.ForeColor = Color.Green;
                Ip_Error.Visible = true;
            }
            else
            {
                Ip_Error.Text = "This is not IP address";
                Ip_Error.ForeColor = Color.Red;
                Ip_Error.Visible = true;
            }

        }
    }
}