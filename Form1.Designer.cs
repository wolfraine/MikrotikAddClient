namespace MikrotikAddClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientTable = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UploadSpeedLabel = new System.Windows.Forms.Label();
            this.DownloadSpeedLabel = new System.Windows.Forms.Label();
            this.DownloadSpeedBox = new System.Windows.Forms.TextBox();
            this.print_btn = new System.Windows.Forms.Button();
            this.clientInfoPrint = new System.Windows.Forms.RichTextBox();
            this.Client_info = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.IPadress_label = new System.Windows.Forms.Label();
            this.ipaddress_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.AddClientTable.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 28);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(902, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem1
            // 
            this.programToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeProgramToolStripMenuItem});
            this.programToolStripMenuItem1.Name = "programToolStripMenuItem1";
            this.programToolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.programToolStripMenuItem1.Text = "Program";
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.closeProgramToolStripMenuItem.Text = "Close Program";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AddClientTable
            // 
            this.AddClientTable.Controls.Add(this.tabPage1);
            this.AddClientTable.Controls.Add(this.tabPage2);
            this.AddClientTable.Location = new System.Drawing.Point(0, 33);
            this.AddClientTable.Name = "AddClientTable";
            this.AddClientTable.SelectedIndex = 0;
            this.AddClientTable.Size = new System.Drawing.Size(909, 549);
            this.AddClientTable.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.UploadSpeedLabel);
            this.tabPage1.Controls.Add(this.DownloadSpeedLabel);
            this.tabPage1.Controls.Add(this.DownloadSpeedBox);
            this.tabPage1.Controls.Add(this.print_btn);
            this.tabPage1.Controls.Add(this.clientInfoPrint);
            this.tabPage1.Controls.Add(this.Client_info);
            this.tabPage1.Controls.Add(this.description_label);
            this.tabPage1.Controls.Add(this.IPadress_label);
            this.tabPage1.Controls.Add(this.ipaddress_box);
            this.tabPage1.Controls.Add(this.description_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(566, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // UploadSpeedLabel
            // 
            this.UploadSpeedLabel.AutoSize = true;
            this.UploadSpeedLabel.Location = new System.Drawing.Point(141, 107);
            this.UploadSpeedLabel.Name = "UploadSpeedLabel";
            this.UploadSpeedLabel.Size = new System.Drawing.Size(58, 20);
            this.UploadSpeedLabel.TabIndex = 22;
            this.UploadSpeedLabel.Text = "Upload";
            // 
            // DownloadSpeedLabel
            // 
            this.DownloadSpeedLabel.AutoSize = true;
            this.DownloadSpeedLabel.Location = new System.Drawing.Point(38, 107);
            this.DownloadSpeedLabel.Name = "DownloadSpeedLabel";
            this.DownloadSpeedLabel.Size = new System.Drawing.Size(78, 20);
            this.DownloadSpeedLabel.TabIndex = 21;
            this.DownloadSpeedLabel.Text = "Download";
            // 
            // DownloadSpeedBox
            // 
            this.DownloadSpeedBox.Location = new System.Drawing.Point(38, 133);
            this.DownloadSpeedBox.Name = "DownloadSpeedBox";
            this.DownloadSpeedBox.Size = new System.Drawing.Size(78, 27);
            this.DownloadSpeedBox.TabIndex = 3;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(758, 445);
            this.print_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(86, 31);
            this.print_btn.TabIndex = 6;
            this.print_btn.Text = "Print Info";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // clientInfoPrint
            // 
            this.clientInfoPrint.BackColor = System.Drawing.Color.White;
            this.clientInfoPrint.Location = new System.Drawing.Point(38, 212);
            this.clientInfoPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientInfoPrint.Name = "clientInfoPrint";
            this.clientInfoPrint.ReadOnly = true;
            this.clientInfoPrint.Size = new System.Drawing.Size(806, 225);
            this.clientInfoPrint.TabIndex = 5;
            this.clientInfoPrint.Text = "";
            // 
            // Client_info
            // 
            this.Client_info.AutoSize = true;
            this.Client_info.Location = new System.Drawing.Point(38, 188);
            this.Client_info.Name = "Client_info";
            this.Client_info.Size = new System.Drawing.Size(116, 20);
            this.Client_info.TabIndex = 16;
            this.Client_info.Text = "Client add value";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(293, 17);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(148, 20);
            this.description_label.TabIndex = 14;
            this.description_label.Text = "Put client description";
            // 
            // IPadress_label
            // 
            this.IPadress_label.AutoSize = true;
            this.IPadress_label.Location = new System.Drawing.Point(38, 17);
            this.IPadress_label.Name = "IPadress_label";
            this.IPadress_label.Size = new System.Drawing.Size(101, 20);
            this.IPadress_label.TabIndex = 15;
            this.IPadress_label.Text = "Put IP address";
            // 
            // ipaddress_box
            // 
            this.ipaddress_box.Location = new System.Drawing.Point(38, 41);
            this.ipaddress_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ipaddress_box.Name = "ipaddress_box";
            this.ipaddress_box.Size = new System.Drawing.Size(190, 27);
            this.ipaddress_box.TabIndex = 0;
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(293, 41);
            this.description_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(190, 27);
            this.description_box.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 573);
            this.Controls.Add(this.AddClientTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddClientTable.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem1;
        private ToolStripMenuItem closeProgramToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TabControl AddClientTable;
        private TabPage tabPage1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label UploadSpeedLabel;
        private Label DownloadSpeedLabel;
        private TextBox UploadSpeedBox;
        private TextBox DownloadSpeedBox;
        private Button print_btn;
        private RichTextBox clientInfoPrint;
        private Label Client_info;
        private Label description_label;
        private Label IPadress_label;
        private TextBox ipaddress_box;
        private TextBox description_box;
        private TabPage tabPage2;
        private ComboBox comboBox1;
    }
}