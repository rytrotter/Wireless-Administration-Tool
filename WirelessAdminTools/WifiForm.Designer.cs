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
            this.forgetNetworkButton = new System.Windows.Forms.Button();
            this.interfaceNameLabelBox = new System.Windows.Forms.Label();
            this.interfaceNamePromptLabelBox = new System.Windows.Forms.Label();
            this.connectedNetworkSecurityLabelBox = new System.Windows.Forms.Label();
            this.currentNetworkSecurityPromptLabelBox = new System.Windows.Forms.Label();
            this.ipv6GroupBox = new System.Windows.Forms.GroupBox();
            this.ipv6PromptLabelBox = new System.Windows.Forms.Label();
            this.ipv6LableBox = new System.Windows.Forms.Label();
            this.ipv4GroupBox = new System.Windows.Forms.GroupBox();
            this.macAddressLabel = new System.Windows.Forms.Label();
            this.macAddressPromptLabel = new System.Windows.Forms.Label();
            this.dnsServersGroupBox = new System.Windows.Forms.GroupBox();
            this.dnsServersListBox = new System.Windows.Forms.ListBox();
            this.openGatewayButton = new System.Windows.Forms.Button();
            this.ipv4PromptLabelBox = new System.Windows.Forms.Label();
            this.ipv4NetmaskPromptLabelBox = new System.Windows.Forms.Label();
            this.ipv4NetmaskLabelBox = new System.Windows.Forms.Label();
            this.ipv4LableBox = new System.Windows.Forms.Label();
            this.gatewayPromptLabelBox = new System.Windows.Forms.Label();
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
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentNetworkNetworkListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatewayListBox = new System.Windows.Forms.ListBox();
            rootColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssidGroupBox.SuspendLayout();
            this.currentNetworkGroupBox.SuspendLayout();
            this.ipv6GroupBox.SuspendLayout();
            this.ipv4GroupBox.SuspendLayout();
            this.dnsServersGroupBox.SuspendLayout();
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
            this.ssidGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.networkListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkListView.FullRowSelect = true;
            this.networkListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.networkListView.HideSelection = false;
            this.networkListView.LabelWrap = false;
            this.networkListView.Location = new System.Drawing.Point(6, 21);
            this.networkListView.MultiSelect = false;
            this.networkListView.Name = "networkListView";
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
            this.strengthHeader.Width = 58;
            // 
            // ssidScanButton
            // 
            this.ssidScanButton.Location = new System.Drawing.Point(12, 510);
            this.ssidScanButton.Name = "ssidScanButton";
            this.ssidScanButton.Size = new System.Drawing.Size(144, 31);
            this.ssidScanButton.TabIndex = 1;
            this.ssidScanButton.Text = "Rescan Networks";
            this.ssidScanButton.UseVisualStyleBackColor = true;
            this.ssidScanButton.Click += new System.EventHandler(this.SsidScanButton_Click);
            // 
            // currentNetworkGroupBox
            // 
            this.currentNetworkGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.currentNetworkGroupBox.Controls.Add(this.forgetNetworkButton);
            this.currentNetworkGroupBox.Controls.Add(this.interfaceNameLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.interfaceNamePromptLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.connectedNetworkSecurityLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.currentNetworkSecurityPromptLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.ipv6GroupBox);
            this.currentNetworkGroupBox.Controls.Add(this.ipv4GroupBox);
            this.currentNetworkGroupBox.Controls.Add(this.networkNameLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.connectedNetNameLabelBox);
            this.currentNetworkGroupBox.Controls.Add(this.connectionStatePicBox);
            this.currentNetworkGroupBox.Controls.Add(this.connectionStateLabelBox);
            this.currentNetworkGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentNetworkGroupBox.Location = new System.Drawing.Point(648, 44);
            this.currentNetworkGroupBox.Name = "currentNetworkGroupBox";
            this.currentNetworkGroupBox.Size = new System.Drawing.Size(403, 460);
            this.currentNetworkGroupBox.TabIndex = 2;
            this.currentNetworkGroupBox.TabStop = false;
            this.currentNetworkGroupBox.Text = "Current Network Settings";
            // 
            // forgetNetworkButton
            // 
            this.forgetNetworkButton.Location = new System.Drawing.Point(204, 406);
            this.forgetNetworkButton.Name = "forgetNetworkButton";
            this.forgetNetworkButton.Size = new System.Drawing.Size(192, 48);
            this.forgetNetworkButton.TabIndex = 20;
            this.forgetNetworkButton.Text = "Forget Network";
            this.forgetNetworkButton.UseVisualStyleBackColor = true;
            this.forgetNetworkButton.Click += new System.EventHandler(this.ForgetNetworkButton_Click);
            // 
            // interfaceNameLabelBox
            // 
            this.interfaceNameLabelBox.AutoSize = true;
            this.interfaceNameLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfaceNameLabelBox.Location = new System.Drawing.Point(57, 50);
            this.interfaceNameLabelBox.Name = "interfaceNameLabelBox";
            this.interfaceNameLabelBox.Size = new System.Drawing.Size(102, 17);
            this.interfaceNameLabelBox.TabIndex = 18;
            this.interfaceNameLabelBox.Text = "interface name";
            // 
            // interfaceNamePromptLabelBox
            // 
            this.interfaceNamePromptLabelBox.AutoSize = true;
            this.interfaceNamePromptLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfaceNamePromptLabelBox.Location = new System.Drawing.Point(6, 33);
            this.interfaceNamePromptLabelBox.Name = "interfaceNamePromptLabelBox";
            this.interfaceNamePromptLabelBox.Size = new System.Drawing.Size(123, 17);
            this.interfaceNamePromptLabelBox.TabIndex = 17;
            this.interfaceNamePromptLabelBox.Text = "Interface Name:";
            // 
            // connectedNetworkSecurityLabelBox
            // 
            this.connectedNetworkSecurityLabelBox.AutoSize = true;
            this.connectedNetworkSecurityLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedNetworkSecurityLabelBox.Location = new System.Drawing.Point(271, 104);
            this.connectedNetworkSecurityLabelBox.Name = "connectedNetworkSecurityLabelBox";
            this.connectedNetworkSecurityLabelBox.Size = new System.Drawing.Size(88, 17);
            this.connectedNetworkSecurityLabelBox.TabIndex = 16;
            this.connectedNetworkSecurityLabelBox.Text = "security type";
            // 
            // currentNetworkSecurityPromptLabelBox
            // 
            this.currentNetworkSecurityPromptLabelBox.AutoSize = true;
            this.currentNetworkSecurityPromptLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentNetworkSecurityPromptLabelBox.Location = new System.Drawing.Point(220, 87);
            this.currentNetworkSecurityPromptLabelBox.Name = "currentNetworkSecurityPromptLabelBox";
            this.currentNetworkSecurityPromptLabelBox.Size = new System.Drawing.Size(113, 17);
            this.currentNetworkSecurityPromptLabelBox.TabIndex = 15;
            this.currentNetworkSecurityPromptLabelBox.Text = "Security Type:";
            // 
            // ipv6GroupBox
            // 
            this.ipv6GroupBox.Controls.Add(this.ipv6PromptLabelBox);
            this.ipv6GroupBox.Controls.Add(this.ipv6LableBox);
            this.ipv6GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipv6GroupBox.Location = new System.Drawing.Point(6, 335);
            this.ipv6GroupBox.Name = "ipv6GroupBox";
            this.ipv6GroupBox.Size = new System.Drawing.Size(391, 65);
            this.ipv6GroupBox.TabIndex = 14;
            this.ipv6GroupBox.TabStop = false;
            this.ipv6GroupBox.Text = "IPv6 Information";
            // 
            // ipv6PromptLabelBox
            // 
            this.ipv6PromptLabelBox.AutoSize = true;
            this.ipv6PromptLabelBox.Location = new System.Drawing.Point(20, 29);
            this.ipv6PromptLabelBox.Name = "ipv6PromptLabelBox";
            this.ipv6PromptLabelBox.Size = new System.Drawing.Size(108, 17);
            this.ipv6PromptLabelBox.TabIndex = 7;
            this.ipv6PromptLabelBox.Text = "IPv6 Address:";
            // 
            // ipv6LableBox
            // 
            this.ipv6LableBox.AutoSize = true;
            this.ipv6LableBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipv6LableBox.Location = new System.Drawing.Point(134, 29);
            this.ipv6LableBox.Name = "ipv6LableBox";
            this.ipv6LableBox.Size = new System.Drawing.Size(89, 17);
            this.ipv6LableBox.TabIndex = 8;
            this.ipv6LableBox.Text = "ipv6 address";
            // 
            // ipv4GroupBox
            // 
            this.ipv4GroupBox.Controls.Add(this.gatewayListBox);
            this.ipv4GroupBox.Controls.Add(this.macAddressLabel);
            this.ipv4GroupBox.Controls.Add(this.macAddressPromptLabel);
            this.ipv4GroupBox.Controls.Add(this.dnsServersGroupBox);
            this.ipv4GroupBox.Controls.Add(this.openGatewayButton);
            this.ipv4GroupBox.Controls.Add(this.ipv4PromptLabelBox);
            this.ipv4GroupBox.Controls.Add(this.ipv4NetmaskPromptLabelBox);
            this.ipv4GroupBox.Controls.Add(this.ipv4NetmaskLabelBox);
            this.ipv4GroupBox.Controls.Add(this.ipv4LableBox);
            this.ipv4GroupBox.Controls.Add(this.gatewayPromptLabelBox);
            this.ipv4GroupBox.Location = new System.Drawing.Point(6, 134);
            this.ipv4GroupBox.Name = "ipv4GroupBox";
            this.ipv4GroupBox.Size = new System.Drawing.Size(391, 195);
            this.ipv4GroupBox.TabIndex = 13;
            this.ipv4GroupBox.TabStop = false;
            this.ipv4GroupBox.Text = "IPv4 Information";
            // 
            // macAddressLabel
            // 
            this.macAddressLabel.AutoSize = true;
            this.macAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macAddressLabel.Location = new System.Drawing.Point(226, 46);
            this.macAddressLabel.Name = "macAddressLabel";
            this.macAddressLabel.Size = new System.Drawing.Size(89, 17);
            this.macAddressLabel.TabIndex = 16;
            this.macAddressLabel.Text = "mac address";
            // 
            // macAddressPromptLabel
            // 
            this.macAddressPromptLabel.AutoSize = true;
            this.macAddressPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macAddressPromptLabel.Location = new System.Drawing.Point(214, 29);
            this.macAddressPromptLabel.Name = "macAddressPromptLabel";
            this.macAddressPromptLabel.Size = new System.Drawing.Size(109, 17);
            this.macAddressPromptLabel.TabIndex = 15;
            this.macAddressPromptLabel.Text = "MAC Address:";
            // 
            // dnsServersGroupBox
            // 
            this.dnsServersGroupBox.Controls.Add(this.dnsServersListBox);
            this.dnsServersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsServersGroupBox.Location = new System.Drawing.Point(229, 76);
            this.dnsServersGroupBox.Name = "dnsServersGroupBox";
            this.dnsServersGroupBox.Size = new System.Drawing.Size(149, 103);
            this.dnsServersGroupBox.TabIndex = 14;
            this.dnsServersGroupBox.TabStop = false;
            this.dnsServersGroupBox.Text = "DNS Servers";
            // 
            // dnsServersListBox
            // 
            this.dnsServersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsServersListBox.FormattingEnabled = true;
            this.dnsServersListBox.ItemHeight = 16;
            this.dnsServersListBox.Location = new System.Drawing.Point(6, 29);
            this.dnsServersListBox.Name = "dnsServersListBox";
            this.dnsServersListBox.Size = new System.Drawing.Size(137, 68);
            this.dnsServersListBox.TabIndex = 13;
            this.dnsServersListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DnsServersListBox_MouseDoubleClick);
            // 
            // openGatewayButton
            // 
            this.openGatewayButton.BackgroundImage = global::WirelessAdminTools.Properties.Resources.GoToNewPage_Icon;
            this.openGatewayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openGatewayButton.Location = new System.Drawing.Point(165, 82);
            this.openGatewayButton.Name = "openGatewayButton";
            this.openGatewayButton.Size = new System.Drawing.Size(23, 23);
            this.openGatewayButton.TabIndex = 5;
            this.openGatewayButton.UseVisualStyleBackColor = true;
            this.openGatewayButton.Click += new System.EventHandler(this.OpenGatewayButton_Click);
            // 
            // ipv4PromptLabelBox
            // 
            this.ipv4PromptLabelBox.AutoSize = true;
            this.ipv4PromptLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipv4PromptLabelBox.Location = new System.Drawing.Point(20, 29);
            this.ipv4PromptLabelBox.Name = "ipv4PromptLabelBox";
            this.ipv4PromptLabelBox.Size = new System.Drawing.Size(108, 17);
            this.ipv4PromptLabelBox.TabIndex = 5;
            this.ipv4PromptLabelBox.Text = "IPv4 Address:";
            // 
            // ipv4NetmaskPromptLabelBox
            // 
            this.ipv4NetmaskPromptLabelBox.AutoSize = true;
            this.ipv4NetmaskPromptLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipv4NetmaskPromptLabelBox.Location = new System.Drawing.Point(20, 141);
            this.ipv4NetmaskPromptLabelBox.Name = "ipv4NetmaskPromptLabelBox";
            this.ipv4NetmaskPromptLabelBox.Size = new System.Drawing.Size(111, 17);
            this.ipv4NetmaskPromptLabelBox.TabIndex = 9;
            this.ipv4NetmaskPromptLabelBox.Text = "IPv4 Netmask:";
            // 
            // ipv4NetmaskLabelBox
            // 
            this.ipv4NetmaskLabelBox.AutoSize = true;
            this.ipv4NetmaskLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipv4NetmaskLabelBox.Location = new System.Drawing.Point(36, 161);
            this.ipv4NetmaskLabelBox.Name = "ipv4NetmaskLabelBox";
            this.ipv4NetmaskLabelBox.Size = new System.Drawing.Size(91, 17);
            this.ipv4NetmaskLabelBox.TabIndex = 10;
            this.ipv4NetmaskLabelBox.Text = "ipv4 netmask";
            // 
            // ipv4LableBox
            // 
            this.ipv4LableBox.AutoSize = true;
            this.ipv4LableBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipv4LableBox.Location = new System.Drawing.Point(35, 46);
            this.ipv4LableBox.Name = "ipv4LableBox";
            this.ipv4LableBox.Size = new System.Drawing.Size(89, 17);
            this.ipv4LableBox.TabIndex = 6;
            this.ipv4LableBox.Text = "ipv4 address";
            // 
            // gatewayPromptLabelBox
            // 
            this.gatewayPromptLabelBox.AutoSize = true;
            this.gatewayPromptLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatewayPromptLabelBox.Location = new System.Drawing.Point(20, 85);
            this.gatewayPromptLabelBox.Name = "gatewayPromptLabelBox";
            this.gatewayPromptLabelBox.Size = new System.Drawing.Size(139, 17);
            this.gatewayPromptLabelBox.TabIndex = 11;
            this.gatewayPromptLabelBox.Text = "Gateway Address:";
            // 
            // networkNameLabelBox
            // 
            this.networkNameLabelBox.AutoSize = true;
            this.networkNameLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkNameLabelBox.Location = new System.Drawing.Point(57, 104);
            this.networkNameLabelBox.Name = "networkNameLabelBox";
            this.networkNameLabelBox.Size = new System.Drawing.Size(96, 17);
            this.networkNameLabelBox.TabIndex = 4;
            this.networkNameLabelBox.Text = "network name";
            // 
            // connectedNetNameLabelBox
            // 
            this.connectedNetNameLabelBox.AutoSize = true;
            this.connectedNetNameLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedNetNameLabelBox.Location = new System.Drawing.Point(6, 87);
            this.connectedNetNameLabelBox.Name = "connectedNetNameLabelBox";
            this.connectedNetNameLabelBox.Size = new System.Drawing.Size(153, 17);
            this.connectedNetNameLabelBox.TabIndex = 3;
            this.connectedNetNameLabelBox.Text = "Connected Network:";
            // 
            // connectionStatePicBox
            // 
            this.connectionStatePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectionStatePicBox.Location = new System.Drawing.Point(367, 20);
            this.connectionStatePicBox.Name = "connectionStatePicBox";
            this.connectionStatePicBox.Size = new System.Drawing.Size(30, 30);
            this.connectionStatePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.connectionStatePicBox.TabIndex = 2;
            this.connectionStatePicBox.TabStop = false;
            // 
            // connectionStateLabelBox
            // 
            this.connectionStateLabelBox.AutoSize = true;
            this.connectionStateLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionStateLabelBox.Location = new System.Drawing.Point(220, 33);
            this.connectionStateLabelBox.Name = "connectionStateLabelBox";
            this.connectionStateLabelBox.Size = new System.Drawing.Size(142, 17);
            this.connectionStateLabelBox.TabIndex = 1;
            this.connectionStateLabelBox.Text = "Connection State: ";
            // 
            // reloadNetInfoButton
            // 
            this.reloadNetInfoButton.Location = new System.Drawing.Point(648, 510);
            this.reloadNetInfoButton.Name = "reloadNetInfoButton";
            this.reloadNetInfoButton.Size = new System.Drawing.Size(403, 31);
            this.reloadNetInfoButton.TabIndex = 3;
            this.reloadNetInfoButton.Text = "Refresh Network Information";
            this.reloadNetInfoButton.UseVisualStyleBackColor = true;
            this.reloadNetInfoButton.Click += new System.EventHandler(this.ReloadNetInfoButton_Click);
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
            this.currentNetworkInformationToolStripMenuItem,
            this.currentNetworkNetworkListToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.refreshToolStripMenuItem.Text = "Refresh...";
            // 
            // availableNetworksToolStripMenuItem
            // 
            this.availableNetworksToolStripMenuItem.Name = "availableNetworksToolStripMenuItem";
            this.availableNetworksToolStripMenuItem.Size = new System.Drawing.Size(455, 26);
            this.availableNetworksToolStripMenuItem.Text = "Available Networks";
            this.availableNetworksToolStripMenuItem.Click += new System.EventHandler(this.AvailableNetworksToolStripMenuItem_Click);
            // 
            // currentNetworkInformationToolStripMenuItem
            // 
            this.currentNetworkInformationToolStripMenuItem.Name = "currentNetworkInformationToolStripMenuItem";
            this.currentNetworkInformationToolStripMenuItem.Size = new System.Drawing.Size(455, 26);
            this.currentNetworkInformationToolStripMenuItem.Text = "Current Network Information";
            this.currentNetworkInformationToolStripMenuItem.Click += new System.EventHandler(this.CurrentNetworkInformationToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerToolStripMenuItem,
            this.thisProjectToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.aboutToolStripMenuItem.Text = "   About    ";
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.DeveloperToolStripMenuItem_Click);
            // 
            // thisProjectToolStripMenuItem
            // 
            this.thisProjectToolStripMenuItem.Name = "thisProjectToolStripMenuItem";
            this.thisProjectToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.thisProjectToolStripMenuItem.Text = "This Project";
            this.thisProjectToolStripMenuItem.Click += new System.EventHandler(this.ThisProjectToolStripMenuItem_Click);
            // 
            // currentNetworkNetworkListToolStripMenuItem
            // 
            this.currentNetworkNetworkListToolStripMenuItem.Name = "currentNetworkNetworkListToolStripMenuItem";
            this.currentNetworkNetworkListToolStripMenuItem.Size = new System.Drawing.Size(455, 26);
            this.currentNetworkNetworkListToolStripMenuItem.Text = "Current Network Information and Available Network List";
            this.currentNetworkNetworkListToolStripMenuItem.Click += new System.EventHandler(this.CurrentNetworkNetworkListToolStripMenuItem_Click);
            // 
            // gatewayListBox
            // 
            this.gatewayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatewayListBox.FormattingEnabled = true;
            this.gatewayListBox.ItemHeight = 16;
            this.gatewayListBox.Location = new System.Drawing.Point(38, 105);
            this.gatewayListBox.Name = "gatewayListBox";
            this.gatewayListBox.Size = new System.Drawing.Size(115, 20);
            this.gatewayListBox.TabIndex = 13;
            this.gatewayListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GatewayListBox_MouseDoubleClick);
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
            this.ipv6GroupBox.ResumeLayout(false);
            this.ipv6GroupBox.PerformLayout();
            this.ipv4GroupBox.ResumeLayout(false);
            this.ipv4GroupBox.PerformLayout();
            this.dnsServersGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Label ipv4NetmaskLabelBox;
        private System.Windows.Forms.Label ipv4NetmaskPromptLabelBox;
        private System.Windows.Forms.Label gatewayPromptLabelBox;
        private System.Windows.Forms.GroupBox ipv6GroupBox;
        private System.Windows.Forms.GroupBox ipv4GroupBox;
        private System.Windows.Forms.Button openGatewayButton;
        private System.Windows.Forms.GroupBox dnsServersGroupBox;
        private System.Windows.Forms.ListBox dnsServersListBox;
        private System.Windows.Forms.Label macAddressLabel;
        private System.Windows.Forms.Label macAddressPromptLabel;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisProjectToolStripMenuItem;
        private System.Windows.Forms.Label connectedNetworkSecurityLabelBox;
        private System.Windows.Forms.Label currentNetworkSecurityPromptLabelBox;
        private System.Windows.Forms.Label interfaceNameLabelBox;
        private System.Windows.Forms.Label interfaceNamePromptLabelBox;
        private System.Windows.Forms.Button forgetNetworkButton;
        private System.Windows.Forms.ToolStripMenuItem currentNetworkNetworkListToolStripMenuItem;
        private System.Windows.Forms.ListBox gatewayListBox;
    }
}

