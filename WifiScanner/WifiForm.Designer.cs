namespace WirelessAdminTools
{
    partial class WifiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader rootColumnHeader;
            this.ssidGroupBox = new System.Windows.Forms.GroupBox();
            this.networkListView = new System.Windows.Forms.ListView();
            this.ssidHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.securityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.strengthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssidScanButton = new System.Windows.Forms.Button();
            this.currentNetworkGroupBox = new System.Windows.Forms.GroupBox();
            this.ipv6LableBox = new System.Windows.Forms.Label();
            this.ipv6PromptLabelBox = new System.Windows.Forms.Label();
            this.ipv4LableBox = new System.Windows.Forms.Label();
            this.ipv4PromptLabelBox = new System.Windows.Forms.Label();
            this.networkNameLabelBox = new System.Windows.Forms.Label();
            this.connectedNetNameLabelBox = new System.Windows.Forms.Label();
            this.connectionStatePicBox = new System.Windows.Forms.PictureBox();
            this.connectionStateLabelBox = new System.Windows.Forms.Label();
            this.reloadNetInfoButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableNetworksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentNetworkInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rootColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssidGroupBox.SuspendLayout();
            this.currentNetworkGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStatePicBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootColumnHeader
            // 
            rootColumnHeader.Text = "";
            rootColumnHeader.Width = 1;
            // 
            // ssidGroupBox
            // 
            this.ssidGroupBox.Controls.Add(this.networkListView);
            this.ssidGroupBox.Location = new System.Drawing.Point(12, 44);
            this.ssidGroupBox.Name = "ssidGroupBox";
            this.ssidGroupBox.Size = new System.Drawing.Size(361, 460);
            this.ssidGroupBox.TabIndex = 0;
            this.ssidGroupBox.TabStop = false;
            this.ssidGroupBox.Text = "Scanned Networks";
            // 
            // networkListView
            // 
            this.networkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            rootColumnHeader,
            this.ssidHeader,
            this.securityHeader,
            this.strengthHeader});
            this.networkListView.FullRowSelect = true;
            this.networkListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.networkListView.HideSelection = false;
            this.networkListView.LabelWrap = false;
            this.networkListView.Location = new System.Drawing.Point(6, 21);
            this.networkListView.MultiSelect = false;
            this.networkListView.Name = "networkListView";
            this.networkListView.Scrollable = false;
            this.networkListView.Size = new System.Drawing.Size(349, 433);
            this.networkListView.TabIndex = 0;
            this.networkListView.UseCompatibleStateImageBehavior = false;
            this.networkListView.View = System.Windows.Forms.View.Details;
            // 
            // ssidHeader
            // 
            this.ssidHeader.Text = "SSID:";
            this.ssidHeader.Width = 143;
            // 
            // securityHeader
            // 
            this.securityHeader.Text = "Security:";
            this.securityHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // strengthHeader
            // 
            this.strengthHeader.Text = "Strength:";
            this.strengthHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ssidScanButton
            // 
            this.ssidScanButton.Location = new System.Drawing.Point(12, 510);
            this.ssidScanButton.Name = "ssidScanButton";
            this.ssidScanButton.Size = new System.Drawing.Size(144, 31);
            this.ssidScanButton.TabIndex = 1;
            this.ssidScanButton.Text = "Rescan Networks";
            this.ssidScanButton.UseVisualStyleBackColor = true;
            this.ssidScanButton.Click += new System.EventHandler(this.ssidScanButton_Click);
            // 
            // currentNetworkGroupBox
            // 
            this.currentNetworkGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.currentNetworkGroupBox.Controls.Add(this.ipv6LableBox);
            this.currentNetworkGroupBox.Controls.Add(this.ipv6PromptLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.ipv4LableBox);
            this.currentNetworkGroupBox.Controls.Add(this.ipv4PromptLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.networkNameLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.connectedNetNameLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.connectionStatePicBox);
            this.currentNetworkGroupBox.Controls.Add(this.connectionStateLabelBox);
            this.currentNetworkGroupBox.Location = new System.Drawing.Point(675, 44);
            this.currentNetworkGroupBox.Name = "currentNetworkGroupBox";
            this.currentNetworkGroupBox.Size = new System.Drawing.Size(376, 460);
            this.currentNetworkGroupBox.TabIndex = 2;
            this.currentNetworkGroupBox.TabStop = false;
            this.currentNetworkGroupBox.Text = "Current Network Settings";
            // 
            // ipv6LableBox
            // 
            this.ipv6LableBox.AutoSize = true;
            this.ipv6LableBox.Location = new System.Drawing.Point(147, 141);
            this.ipv6LableBox.Name = "ipv6LableBox";
            this.ipv6LableBox.Size = new System.Drawing.Size(82, 17);
            this.ipv6LableBox.TabIndex = 8;
            this.ipv6LableBox.Text = "placeholder";
            // 
            // ipv6PromptLabelBox
            // 
            this.ipv6PromptLabelBox.AutoSize = true;
            this.ipv6PromptLabelBox.Location = new System.Drawing.Point(40, 141);
            this.ipv6PromptLabelBox.Name = "ipv6PromptLabelBox";
            this.ipv6PromptLabelBox.Size = new System.Drawing.Size(90, 17);
            this.ipv6PromptLabelBox.TabIndex = 7;
            this.ipv6PromptLabelBox.Text = "Current IPv6:";
            // 
            // ipv4LableBox
            // 
            this.ipv4LableBox.AutoSize = true;
            this.ipv4LableBox.Location = new System.Drawing.Point(147, 124);
            this.ipv4LableBox.Name = "ipv4LableBox";
            this.ipv4LableBox.Size = new System.Drawing.Size(82, 17);
            this.ipv4LableBox.TabIndex = 6;
            this.ipv4LableBox.Text = "placeholder";
            // 
            // ipv4PromptLabelBox
            // 
            this.ipv4PromptLabelBox.AutoSize = true;
            this.ipv4PromptLabelBox.Location = new System.Drawing.Point(40, 124);
            this.ipv4PromptLabelBox.Name = "ipv4PromptLabelBox";
            this.ipv4PromptLabelBox.Size = new System.Drawing.Size(90, 17);
            this.ipv4PromptLabelBox.TabIndex = 5;
            this.ipv4PromptLabelBox.Text = "Current IPv4:";
            // 
            // networkNameLabelBox
            // 
            this.networkNameLabelBox.AutoSize = true;
            this.networkNameLabelBox.Location = new System.Drawing.Point(147, 95);
            this.networkNameLabelBox.Name = "networkNameLabelBox";
            this.networkNameLabelBox.Size = new System.Drawing.Size(82, 17);
            this.networkNameLabelBox.TabIndex = 4;
            this.networkNameLabelBox.Text = "placeholder";
            // 
            // connectedNetNameLabelBox
            // 
            this.connectedNetNameLabelBox.AutoSize = true;
            this.connectedNetNameLabelBox.Location = new System.Drawing.Point(6, 95);
            this.connectedNetNameLabelBox.Name = "connectedNetNameLabelBox";
            this.connectedNetNameLabelBox.Size = new System.Drawing.Size(135, 17);
            this.connectedNetNameLabelBox.TabIndex = 3;
            this.connectedNetNameLabelBox.Text = "Connected Network:";
            // 
            // connectionStatePicBox
            // 
            this.connectionStatePicBox.Location = new System.Drawing.Point(136, 27);
            this.connectionStatePicBox.Name = "connectionStatePicBox";
            this.connectionStatePicBox.Size = new System.Drawing.Size(30, 30);
            this.connectionStatePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.connectionStatePicBox.TabIndex = 2;
            this.connectionStatePicBox.TabStop = false;
            // 
            // connectionStateLabelBox
            // 
            this.connectionStateLabelBox.AutoSize = true;
            this.connectionStateLabelBox.Location = new System.Drawing.Point(6, 35);
            this.connectionStateLabelBox.Name = "connectionStateLabelBox";
            this.connectionStateLabelBox.Size = new System.Drawing.Size(124, 17);
            this.connectionStateLabelBox.TabIndex = 1;
            this.connectionStateLabelBox.Text = "Connection State: ";
            // 
            // reloadNetInfoButton
            // 
            this.reloadNetInfoButton.Location = new System.Drawing.Point(675, 510);
            this.reloadNetInfoButton.Name = "reloadNetInfoButton";
            this.reloadNetInfoButton.Size = new System.Drawing.Size(376, 31);
            this.reloadNetInfoButton.TabIndex = 3;
            this.reloadNetInfoButton.Text = "Refresh Network Information";
            this.reloadNetInfoButton.UseVisualStyleBackColor = true;
            this.reloadNetInfoButton.Click += new System.EventHandler(this.reloadNetInfoButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.fileToolStripMenuItem.Text = "   File   ";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availableNetworksToolStripMenuItem,
            this.currentNetworkInformationToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.refreshToolStripMenuItem.Text = "Refresh...";
            // 
            // availableNetworksToolStripMenuItem
            // 
            this.availableNetworksToolStripMenuItem.Name = "availableNetworksToolStripMenuItem";
            this.availableNetworksToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.availableNetworksToolStripMenuItem.Text = "Available Networks";
            this.availableNetworksToolStripMenuItem.Click += new System.EventHandler(this.availableNetworksToolStripMenuItem_Click);
            // 
            // currentNetworkInformationToolStripMenuItem
            // 
            this.currentNetworkInformationToolStripMenuItem.Name = "currentNetworkInformationToolStripMenuItem";
            this.currentNetworkInformationToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.currentNetworkInformationToolStripMenuItem.Text = "Current Network Information";
            this.currentNetworkInformationToolStripMenuItem.Click += new System.EventHandler(this.currentNetworkInformationToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.aboutToolStripMenuItem.Text = "   About    ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // WifiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 553);
            this.Controls.Add(this.reloadNetInfoButton);
            this.Controls.Add(this.currentNetworkGroupBox);
            this.Controls.Add(this.ssidScanButton);
            this.Controls.Add(this.ssidGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WifiForm";
            this.Text = "Wireless Admin Tools";
            this.ssidGroupBox.ResumeLayout(false);
            this.currentNetworkGroupBox.ResumeLayout(false);
            this.currentNetworkGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStatePicBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ssidGroupBox;
        private System.Windows.Forms.Button ssidScanButton;
        private System.Windows.Forms.ListView networkListView;
        private System.Windows.Forms.ColumnHeader ssidHeader;
        private System.Windows.Forms.ColumnHeader securityHeader;
        private System.Windows.Forms.ColumnHeader strengthHeader;
        private System.Windows.Forms.GroupBox currentNetworkGroupBox;
        private System.Windows.Forms.Label connectionStateLabelBox;
        private System.Windows.Forms.PictureBox connectionStatePicBox;
        private System.Windows.Forms.Label networkNameLabelBox;
        private System.Windows.Forms.Label connectedNetNameLabelBox;
        private System.Windows.Forms.Label ipv4LableBox;
        private System.Windows.Forms.Label ipv4PromptLabelBox;
        private System.Windows.Forms.Label ipv6LableBox;
        private System.Windows.Forms.Label ipv6PromptLabelBox;
        private System.Windows.Forms.Button reloadNetInfoButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableNetworksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentNetworkInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

