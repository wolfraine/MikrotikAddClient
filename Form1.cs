using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;

namespace MikrotikAddClient
{
    public partial class MikrotikAddClient : Form
    {
        string queue = "";
        string dhcpleases = "";
        string firewall_list = "";
        string clipboardtext = "";
        string ipAddress = "";
        string clientDescription = "";
        int UploadSpeed = 0;
        int DownloadSpeed = 0;
        string DHCP_Server = "";
        string MAC_Address = "";
        List<string> FromFile = new();
        readonly string FileName = "DHCP-Servers.txt";

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
            int DownloadBurst = 0;
            int UploadBurst = 0;


            if (DownloadSpeed < 10)
            {
                DownloadBurst = DownloadSpeed + 2;
            }
            else if (DownloadSpeed > 1000)
            {
                DownloadSpeed = 1000;
            }
            else
            {
                DownloadBurst = ((int)(DownloadSpeed * 1.1));
            }

            if (UploadSpeed < 10)
            {
                UploadBurst = DownloadSpeed + 2;
            }
            else if (UploadSpeed > 1000)
            {
                UploadSpeed = 1000;
            }
            else
            {
                UploadBurst = ((int)(UploadSpeed * 1.1));
            }

            queue = "/queue simple\r\n add burst-limit=" + DownloadBurst + "M/" + UploadBurst + "M burst-threshold=" + UploadSpeed + "M/" + DownloadSpeed + "M burst-time=8s/8s max-limit=" + UploadSpeed + "M/" + DownloadSpeed + "M name=" + clientDescription + " queue=wireless-default/wireless-default target=" + ipAddress + " \r\n"; dhcpleases = "/delay 1 \r\n/ip dhcp-server lease\r\n add address=" + ipAddress + " always-broadcast=yes comment=" + clientDescription + " disabled=no mac-address=" + MAC_Address + " server=" + DHCP_Server + " \r\n";
            dhcpleases = "/delay 1 \r\n/ip dhcp-server lease\r\n add address=" + ipAddress + " always-broadcast=yes comment=" + clientDescription + " disabled=no mac-address=" + MAC_Address + " server=" + DHCP_Server + " \r\n";
            firewall_list = "/delay 1 \r\n/ip firewall address-list\r\n add address=" + ipAddress + " comment=" + clientDescription + " list=klienci \r\n";

            clipboardtext = queue + dhcpleases + firewall_list;
            clientInfoPrint.Text = clipboardtext;
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
            Clipboard.SetDataObject(clipboardtext);
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
            IPAddress ipAddress = null;
            string tmp = ipaddress_box.Text;
            bool isValidIp = tmp.Count(c => c == '.') == 3 && IPAddress.TryParse(tmp, out ipAddress);
            if (ipaddress_box.Text == null)
            {
                Ip_Error.Text = "";
                Ip_Error.Visible = false;
            }
            else if(isValidIp)
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