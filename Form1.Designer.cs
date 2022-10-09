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
            this.description_box = new System.Windows.Forms.TextBox();
            this.ipaddress_box = new System.Windows.Forms.TextBox();
            this.IPadress_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(30, 104);
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(282, 23);
            this.description_box.TabIndex = 0;
            // 
            // ipaddress_box
            // 
            this.ipaddress_box.Location = new System.Drawing.Point(30, 50);
            this.ipaddress_box.Name = "ipaddress_box";
            this.ipaddress_box.Size = new System.Drawing.Size(282, 23);
            this.ipaddress_box.TabIndex = 0;
            // 
            // IPadress_label
            // 
            this.IPadress_label.AutoSize = true;
            this.IPadress_label.Location = new System.Drawing.Point(30, 32);
            this.IPadress_label.Name = "IPadress_label";
            this.IPadress_label.Size = new System.Drawing.Size(81, 15);
            this.IPadress_label.TabIndex = 1;
            this.IPadress_label.Text = "Put IP address";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(30, 86);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(119, 15);
            this.description_label.TabIndex = 1;
            this.description_label.Text = "Put client description";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem1
            // 
            this.programToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeProgramToolStripMenuItem});
            this.programToolStripMenuItem1.Name = "programToolStripMenuItem1";
            this.programToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem1.Text = "Program";
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeProgramToolStripMenuItem.Text = "Close Program";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.IPadress_label);
            this.Controls.Add(this.ipaddress_box);
            this.Controls.Add(this.description_box);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox description_box;
        private TextBox ipaddress_box;
        private Label IPadress_label;
        private Label description_label;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem1;
        private ToolStripMenuItem closeProgramToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}