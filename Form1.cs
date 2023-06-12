namespace MikrotikAddClient
{
    public partial class Form1 : Form
    {
        string ipAddress = "";
        string clientDescription = "";
        int UploadSpeed = 0;
        int DownloadSpeed = 0;
        string dhcp = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            ipAddress = ipaddress_box.Text;
            clientDescription = description_box.Text;
            DownloadSpeed = int.Parse(DownloadSpeedBox.Text);
            UploadSpeed = int.Parse(UploadSpeedBox.Text);
            //clientInfoPrint.Text="<queue>\" test \"\n"+ipAddress+" info "+clientDescription+" test.\n kropka.";
            clientInfoPrint.Text = "/queue simple\n" +
                "add burst-limit=" + UploadSpeed*1.2 + "M/" + DownloadSpeed*1.2 + "M burst-threshold=" + UploadSpeed + "M/" + DownloadSpeed + "M burst-time=8s/8s max-limit="+UploadSpeed+"M/"+DownloadSpeed+"M name=" + clientDescription + " queue=wireless-default/wireless-default target=" + ipAddress;
        }
    }
}