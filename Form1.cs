namespace MikrotikAddClient
{
    public partial class Form1 : Form
    {
        string ipAddress = "";
        string clientDescription = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            ipAddress=ipaddress_box.Text;
            clientDescription=description_box.Text;
            clientInfoPrint.Text="<queue>\" test \"\n"+ipAddress+" info "+clientDescription+" test.\n kropka.";
        }
    }
}