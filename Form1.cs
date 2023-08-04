using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;


namespace MikrotikAddClient
{
    public partial class MikrotikAddClient : Form
    {
        List<string> FromFile = new();
        readonly string FileName = "DHCP-Servers.txt";
        ClientData clientData = new ClientData();

        public MikrotikAddClient()
        {
            InitializeComponent();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            clientData.IpAddress = ipaddress_box.Text;
            clientData.ClientDescription = description_box.Text;
            clientData.DownloadSpeed = int.Parse(DownloadSpeedBox.Text);
            clientData.UploadSpeed = int.Parse(UploadSpeedBox.Text);
            clientData.MAC_Address = MacAddressBox.Text;
            clientData.DHCP_Server = DHCP_Value.Text;

            if (description_box.Text.Length == 0)
            {

            }
            else
            {
                clientInfoPrint.Text = clientData.MikrotikPrintData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void UpdateForm()
        {
            DHCP_Value.Items.Clear();
            DHCP_Value.Items.AddRange(FromFile.ToArray());
            DHCP_ServerList.Items.Clear();
            DHCP_ServerList.Items.AddRange(FromFile.ToArray());
        }

        private void Copy_Button_Click(object sender, EventArgs e)
        {
            //WARNING Can't read from box because it doesn't read newlines.
            //Clipboard.SetDataObject(clientInfoPrint.Text);
            Clipboard.SetDataObject(clientData.MikrotikPrintData());
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
            Update_Box.Clear();
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
            //Input only numbers & backspace
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b');
        }

        private void UploadSpeedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input only numbers & backspace
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b');
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void GenerateMacButton_Click(object sender, EventArgs e)
        {
            MacAddressBox.Text = clientData.GetRandomMacAddress();
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

        private void NewDHCP_ServerBox_TextChanged(object sender, EventArgs e)
        {
            if (NewDHCP_ServerBox.Text.Length == 0)
            {
                AddDHCP_ServerButton.Enabled = false;
            }
            else
            {
                AddDHCP_ServerButton.Enabled = true;
            }
        }

        private void Update_Box_TextChanged(object sender, EventArgs e)
        {
            if (Update_Box.Text.Length == 0)
            {
                UpdateButton.Enabled = false;
            }
            else
            {
                UpdateButton.Enabled = true;
            }
        }
    }
}