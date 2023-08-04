namespace MikrotikAddClient
{
    partial class MikrotikAddClient
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MikrotikAddClient));
            contextMenuStrip1 = new ContextMenuStrip(components);
            programToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem1 = new ToolStripMenuItem();
            closeProgramToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AddClientTable = new TabControl();
            tabPage1 = new TabPage();
            Ip_Error = new Label();
            GenerateMacButton = new Button();
            Clear_button = new Button();
            Copy_Button = new Button();
            DHCP_ServerLabel = new Label();
            MacAddressBox = new TextBox();
            MacAddresLabel = new Label();
            UploadSpeedBox = new TextBox();
            DHCP_Value = new ComboBox();
            UploadSpeedLabel = new Label();
            DownloadSpeedLabel = new Label();
            DownloadSpeedBox = new TextBox();
            print_btn = new Button();
            clientInfoPrint = new RichTextBox();
            Client_info = new Label();
            description_label = new Label();
            IPadress_label = new Label();
            ipaddress_box = new TextBox();
            description_box = new TextBox();
            tabPage2 = new TabPage();
            Edit_Button = new Button();
            Update_Box = new TextBox();
            UpdateButton = new Button();
            RemoveButton = new Button();
            DHCP_ServerList = new ListBox();
            AddDHCP_ServerButton = new Button();
            NewDHCP_ServerBox = new TextBox();
            AddNewDHCP_ServerLabel = new Label();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            AddClientTable.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 26);
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(120, 22);
            programToolStripMenuItem.Text = "Program";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem1, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(865, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem1
            // 
            programToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { closeProgramToolStripMenuItem });
            programToolStripMenuItem1.Name = "programToolStripMenuItem1";
            programToolStripMenuItem1.Size = new Size(65, 20);
            programToolStripMenuItem1.Text = "Program";
            // 
            // closeProgramToolStripMenuItem
            // 
            closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            closeProgramToolStripMenuItem.Size = new Size(152, 22);
            closeProgramToolStripMenuItem.Text = "Close Program";
            closeProgramToolStripMenuItem.Click += closeProgramToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // AddClientTable
            // 
            AddClientTable.Controls.Add(tabPage1);
            AddClientTable.Controls.Add(tabPage2);
            AddClientTable.Location = new Point(0, 25);
            AddClientTable.Margin = new Padding(3, 2, 3, 2);
            AddClientTable.Name = "AddClientTable";
            AddClientTable.SelectedIndex = 0;
            AddClientTable.Size = new Size(866, 412);
            AddClientTable.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Ip_Error);
            tabPage1.Controls.Add(GenerateMacButton);
            tabPage1.Controls.Add(Clear_button);
            tabPage1.Controls.Add(Copy_Button);
            tabPage1.Controls.Add(DHCP_ServerLabel);
            tabPage1.Controls.Add(MacAddressBox);
            tabPage1.Controls.Add(MacAddresLabel);
            tabPage1.Controls.Add(UploadSpeedBox);
            tabPage1.Controls.Add(DHCP_Value);
            tabPage1.Controls.Add(UploadSpeedLabel);
            tabPage1.Controls.Add(DownloadSpeedLabel);
            tabPage1.Controls.Add(DownloadSpeedBox);
            tabPage1.Controls.Add(print_btn);
            tabPage1.Controls.Add(clientInfoPrint);
            tabPage1.Controls.Add(Client_info);
            tabPage1.Controls.Add(description_label);
            tabPage1.Controls.Add(IPadress_label);
            tabPage1.Controls.Add(ipaddress_box);
            tabPage1.Controls.Add(description_box);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(858, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Client";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Ip_Error
            // 
            Ip_Error.AutoSize = true;
            Ip_Error.Location = new Point(33, 56);
            Ip_Error.Name = "Ip_Error";
            Ip_Error.Size = new Size(38, 15);
            Ip_Error.TabIndex = 28;
            Ip_Error.Text = "label1";
            Ip_Error.Visible = false;
            // 
            // GenerateMacButton
            // 
            GenerateMacButton.Location = new Point(749, 75);
            GenerateMacButton.Margin = new Padding(3, 2, 3, 2);
            GenerateMacButton.Name = "GenerateMacButton";
            GenerateMacButton.Size = new Size(82, 22);
            GenerateMacButton.TabIndex = 27;
            GenerateMacButton.Text = "Gen Mac";
            GenerateMacButton.UseVisualStyleBackColor = true;
            GenerateMacButton.Click += GenerateMacButton_Click;
            // 
            // Clear_button
            // 
            Clear_button.Location = new Point(33, 335);
            Clear_button.Margin = new Padding(3, 2, 3, 2);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(82, 22);
            Clear_button.TabIndex = 26;
            Clear_button.Text = "Clear";
            Clear_button.UseVisualStyleBackColor = true;
            Clear_button.Click += Clear_button_Click;
            // 
            // Copy_Button
            // 
            Copy_Button.Enabled = false;
            Copy_Button.Location = new Point(627, 335);
            Copy_Button.Margin = new Padding(3, 2, 3, 2);
            Copy_Button.Name = "Copy_Button";
            Copy_Button.Size = new Size(82, 22);
            Copy_Button.TabIndex = 9;
            Copy_Button.Text = "Copy";
            Copy_Button.UseVisualStyleBackColor = true;
            Copy_Button.Click += Copy_Button_Click;
            // 
            // DHCP_ServerLabel
            // 
            DHCP_ServerLabel.AutoSize = true;
            DHCP_ServerLabel.Location = new Point(256, 81);
            DHCP_ServerLabel.Name = "DHCP_ServerLabel";
            DHCP_ServerLabel.Size = new Size(74, 15);
            DHCP_ServerLabel.TabIndex = 25;
            DHCP_ServerLabel.Text = "DHCP Server";
            // 
            // MacAddressBox
            // 
            MacAddressBox.Location = new Point(543, 75);
            MacAddressBox.Margin = new Padding(3, 2, 3, 2);
            MacAddressBox.MaxLength = 17;
            MacAddressBox.Name = "MacAddressBox";
            MacAddressBox.Size = new Size(167, 23);
            MacAddressBox.TabIndex = 6;
            // 
            // MacAddresLabel
            // 
            MacAddresLabel.AutoSize = true;
            MacAddresLabel.Location = new Point(543, 56);
            MacAddresLabel.Name = "MacAddresLabel";
            MacAddresLabel.Size = new Size(79, 15);
            MacAddresLabel.TabIndex = 23;
            MacAddresLabel.Text = "MAC Address";
            // 
            // UploadSpeedBox
            // 
            UploadSpeedBox.Location = new Point(123, 100);
            UploadSpeedBox.Margin = new Padding(3, 2, 3, 2);
            UploadSpeedBox.MaxLength = 4;
            UploadSpeedBox.Name = "UploadSpeedBox";
            UploadSpeedBox.Size = new Size(69, 23);
            UploadSpeedBox.TabIndex = 3;
            UploadSpeedBox.KeyPress += UploadSpeedBox_KeyPress;
            // 
            // DHCP_Value
            // 
            DHCP_Value.FormattingEnabled = true;
            DHCP_Value.Location = new Point(256, 99);
            DHCP_Value.Margin = new Padding(3, 2, 3, 2);
            DHCP_Value.Name = "DHCP_Value";
            DHCP_Value.Size = new Size(244, 23);
            DHCP_Value.TabIndex = 5;
            // 
            // UploadSpeedLabel
            // 
            UploadSpeedLabel.AutoSize = true;
            UploadSpeedLabel.Location = new Point(123, 80);
            UploadSpeedLabel.Name = "UploadSpeedLabel";
            UploadSpeedLabel.Size = new Size(45, 15);
            UploadSpeedLabel.TabIndex = 22;
            UploadSpeedLabel.Text = "Upload";
            // 
            // DownloadSpeedLabel
            // 
            DownloadSpeedLabel.AutoSize = true;
            DownloadSpeedLabel.Location = new Point(33, 80);
            DownloadSpeedLabel.Name = "DownloadSpeedLabel";
            DownloadSpeedLabel.Size = new Size(61, 15);
            DownloadSpeedLabel.TabIndex = 21;
            DownloadSpeedLabel.Text = "Download";
            // 
            // DownloadSpeedBox
            // 
            DownloadSpeedBox.Location = new Point(33, 100);
            DownloadSpeedBox.Margin = new Padding(3, 2, 3, 2);
            DownloadSpeedBox.MaxLength = 4;
            DownloadSpeedBox.Name = "DownloadSpeedBox";
            DownloadSpeedBox.Size = new Size(69, 23);
            DownloadSpeedBox.TabIndex = 2;
            DownloadSpeedBox.KeyPress += DownloadSpeedBox_KeyPress;
            // 
            // print_btn
            // 
            print_btn.Location = new Point(738, 334);
            print_btn.Name = "print_btn";
            print_btn.Size = new Size(75, 23);
            print_btn.TabIndex = 8;
            print_btn.Text = "Print Info";
            print_btn.UseVisualStyleBackColor = true;
            print_btn.Click += print_btn_Click;
            // 
            // clientInfoPrint
            // 
            clientInfoPrint.BackColor = Color.White;
            clientInfoPrint.Location = new Point(33, 159);
            clientInfoPrint.Name = "clientInfoPrint";
            clientInfoPrint.ReadOnly = true;
            clientInfoPrint.Size = new Size(780, 170);
            clientInfoPrint.TabIndex = 7;
            clientInfoPrint.Text = "";
            clientInfoPrint.TextChanged += clientInfoPrint_TextChanged;
            // 
            // Client_info
            // 
            Client_info.AutoSize = true;
            Client_info.Location = new Point(33, 141);
            Client_info.Name = "Client_info";
            Client_info.Size = new Size(92, 15);
            Client_info.TabIndex = 16;
            Client_info.Text = "Client add value";
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Location = new Point(256, 13);
            description_label.Name = "description_label";
            description_label.Size = new Size(119, 15);
            description_label.TabIndex = 14;
            description_label.Text = "Put client description";
            // 
            // IPadress_label
            // 
            IPadress_label.AutoSize = true;
            IPadress_label.Location = new Point(33, 13);
            IPadress_label.Name = "IPadress_label";
            IPadress_label.Size = new Size(81, 15);
            IPadress_label.TabIndex = 15;
            IPadress_label.Text = "Put IP address";
            // 
            // ipaddress_box
            // 
            ipaddress_box.Location = new Point(33, 31);
            ipaddress_box.MaxLength = 15;
            ipaddress_box.Name = "ipaddress_box";
            ipaddress_box.Size = new Size(167, 23);
            ipaddress_box.TabIndex = 0;
            // 
            // description_box
            // 
            description_box.Location = new Point(256, 31);
            description_box.Name = "description_box";
            description_box.Size = new Size(244, 23);
            description_box.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Edit_Button);
            tabPage2.Controls.Add(Update_Box);
            tabPage2.Controls.Add(UpdateButton);
            tabPage2.Controls.Add(RemoveButton);
            tabPage2.Controls.Add(DHCP_ServerList);
            tabPage2.Controls.Add(AddDHCP_ServerButton);
            tabPage2.Controls.Add(NewDHCP_ServerBox);
            tabPage2.Controls.Add(AddNewDHCP_ServerLabel);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(858, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add DHCP Server";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Edit_Button
            // 
            Edit_Button.Location = new Point(378, 102);
            Edit_Button.Margin = new Padding(3, 2, 3, 2);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(82, 22);
            Edit_Button.TabIndex = 8;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = true;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // Update_Box
            // 
            Update_Box.Location = new Point(47, 302);
            Update_Box.Margin = new Padding(3, 2, 3, 2);
            Update_Box.Name = "Update_Box";
            Update_Box.Size = new Size(203, 23);
            Update_Box.TabIndex = 7;
            Update_Box.TextChanged += Update_Box_TextChanged;
            // 
            // UpdateButton
            // 
            UpdateButton.Enabled = false;
            UpdateButton.Location = new Point(276, 302);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(82, 22);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(378, 142);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(82, 22);
            RemoveButton.TabIndex = 5;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // DHCP_ServerList
            // 
            DHCP_ServerList.FormattingEnabled = true;
            DHCP_ServerList.ItemHeight = 15;
            DHCP_ServerList.Location = new Point(47, 102);
            DHCP_ServerList.Margin = new Padding(3, 2, 3, 2);
            DHCP_ServerList.Name = "DHCP_ServerList";
            DHCP_ServerList.Size = new Size(311, 184);
            DHCP_ServerList.TabIndex = 4;
            // 
            // AddDHCP_ServerButton
            // 
            AddDHCP_ServerButton.Enabled = false;
            AddDHCP_ServerButton.Location = new Point(276, 50);
            AddDHCP_ServerButton.Margin = new Padding(3, 2, 3, 2);
            AddDHCP_ServerButton.Name = "AddDHCP_ServerButton";
            AddDHCP_ServerButton.Size = new Size(82, 22);
            AddDHCP_ServerButton.TabIndex = 3;
            AddDHCP_ServerButton.Text = "Add";
            AddDHCP_ServerButton.UseVisualStyleBackColor = true;
            AddDHCP_ServerButton.Click += AddDHCP_ServerButton_Click;
            // 
            // NewDHCP_ServerBox
            // 
            NewDHCP_ServerBox.Location = new Point(47, 50);
            NewDHCP_ServerBox.Margin = new Padding(3, 2, 3, 2);
            NewDHCP_ServerBox.Name = "NewDHCP_ServerBox";
            NewDHCP_ServerBox.Size = new Size(177, 23);
            NewDHCP_ServerBox.TabIndex = 2;
            NewDHCP_ServerBox.TextChanged += NewDHCP_ServerBox_TextChanged;
            // 
            // AddNewDHCP_ServerLabel
            // 
            AddNewDHCP_ServerLabel.AutoSize = true;
            AddNewDHCP_ServerLabel.Location = new Point(47, 32);
            AddNewDHCP_ServerLabel.Name = "AddNewDHCP_ServerLabel";
            AddNewDHCP_ServerLabel.Size = new Size(163, 15);
            AddNewDHCP_ServerLabel.TabIndex = 0;
            AddNewDHCP_ServerLabel.Text = "Paste new DHCP Server name";
            // 
            // MikrotikAddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 430);
            Controls.Add(AddClientTable);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MikrotikAddClient";
            Text = "Mikrotik Client Add";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            AddClientTable.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label UploadSpeedLabel;
        private Label DownloadSpeedLabel;
        private TextBox DownloadSpeedBox;
        private Button print_btn;
        private RichTextBox clientInfoPrint;
        private Label Client_info;
        private Label description_label;
        private Label IPadress_label;
        private TextBox ipaddress_box;
        private TextBox description_box;
        private TabPage tabPage2;
        private TextBox UploadSpeedBox;
        private ComboBox DHCP_Value;
        private Label DHCP_ServerLabel;
        private TextBox MacAddressBox;
        private Label MacAddresLabel;
        private Button AddDHCP_ServerButton;
        private TextBox NewDHCP_ServerBox;
        private Label AddNewDHCP_ServerLabel;
        private ListBox DHCP_ServerList;
        private Button Copy_Button;
        private TextBox Update_Box;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button Edit_Button;
        private Button Clear_button;
        private Button GenerateMacButton;
        private Label Ip_Error;
    }
}