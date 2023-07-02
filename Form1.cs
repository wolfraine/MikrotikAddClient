using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;

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
        List<string> FromFile = new List<string>();
        string FileName = "DHCP-Servers.txt";

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

            queue = "/queue simple\r\n add burst-limit=" + ((int)(UploadSpeed * 1.1)) + "M/" + ((int)(DownloadSpeed * 1.1)) + "M burst-threshold=" + UploadSpeed + "M/" + DownloadSpeed + "M burst-time=8s/8s max-limit=" + UploadSpeed + "M/" + DownloadSpeed + "M name=" + clientDescription + " queue=wireless-default/wireless-default target=" + ipAddress + " \r\n";
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
                using (StreamWriter sw = File.CreateText(FileName))
                {
                    sw.WriteLine("List is Empty");
                    //foreach (var line in employeeList.Items)
                    //{
                    //    sw.WriteLine(((Employee)line).FirstName);
                    //    sw.WriteLine(((Employee)line).LastName);
                    //    sw.WriteLine(((Employee)line).JobTitle);
                    //}
                }
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
            using (StreamWriter sw = File.CreateText(FileName))
            {
                foreach (var line in FromFile)
                {
                    sw.WriteLine(line);
                }
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
    }
}