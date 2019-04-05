using System;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace WirelessAdminTools
{
    public partial class WifiForm : Form
    {
        public WifiForm()
        {
            InitializeComponent();

            // Load available networks on startup
            LoadUpdateScannedNetworkList();

            // Load current network information on startup
            RefreshCurrentNetworkInformation();
        }

        private void SsidScanButton_Click(object sender, EventArgs e)
        {
            LoadUpdateScannedNetworkList();
        }

        private void ReloadNetInfoButton_Click(object sender, EventArgs e)
        {
            RefreshCurrentNetworkInformation();
        }

        private void NetworkListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshCurrentNetworkInformation()
        {
            UpdateConnectionState();
            ShowCurrentConnectedNetwork();
            ShowCurrentIPv4Address();
            ShowCurrentGatewayAddress();
            ShowCurrentIPv4Netmask();
            ShowCurrentIPv6Address();
            LoadUpdateDNSServers();
            LoadMacAddress();
        }

        private void LoadUpdateScannedNetworkList()
        {
            networkListView.Items.Clear();

            for (int i = 0; i < WifiAdminTools.ScanForNetworks.GatherScannedNetworkInfo().Count; i++)
            {
                var networkList = WifiAdminTools.ScanForNetworks.GatherScannedNetworkInfo();

                ListViewItem networkListViewRow = new ListViewItem();
                ListViewItem.ListViewSubItem networkName = new ListViewItem.ListViewSubItem(networkListViewRow, networkList[i].SSID);
                ListViewItem.ListViewSubItem networkSec = new ListViewItem.ListViewSubItem(networkListViewRow, networkList[i].SecurityType);
                ListViewItem.ListViewSubItem networkStrength = new ListViewItem.ListViewSubItem(networkListViewRow, networkList[i].SignalStrength);

                if (networkList != null)
                {
                    networkListViewRow.SubItems.Add(networkName);
                    networkListViewRow.SubItems.Add(networkSec);
                    networkListViewRow.SubItems.Add(networkStrength);
                    networkListView.Items.Add(networkListViewRow);
                }
                else
                {
                    networkListView.Items.Add("There are no networks available to show.");
                }
            }
        }

        private void UpdateConnectionState()
        {
            string path = "..\\..\\Assets\\";   
            if (WifiAdminTools.CurrentNetworkSettings.IsConnected() == true)
            {
                connectionStatePicBox.ImageLocation = path + "greenCheckMark.png";
            }
            else
            {
                connectionStatePicBox.ImageLocation = path + "redXMark.png";
            }
        }

        private void ShowCurrentConnectedNetwork()
        {
            networkNameLabelBox.Text = WifiAdminTools.CurrentNetworkSettings.ReturnNetworkName();
        }

        private void ShowCurrentIPv4Address()
        {
            ipv4LableBox.Text = WifiAdminTools.CurrentNetworkSettings.ReturnCurrentIPv4();
        }

        private void ShowCurrentGatewayAddress()
        {
            gatewayLabelBox.Text = WifiAdminTools.CurrentNetworkSettings.ReturnCurrentGateway();
        }

        private void ShowCurrentIPv4Netmask()
        {
          ipv4NetmaskLabelBox.Text = WifiAdminTools.CurrentNetworkSettings.ReturnIPv4Netmask();
        }

        private void ShowCurrentIPv6Address()
        {
            ipv6LableBox.Text = WifiAdminTools.CurrentNetworkSettings.ReturnCurrentIPv6();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void AvailableNetworksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUpdateScannedNetworkList();

        }

        private void CurrentNetworkInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshCurrentNetworkInformation();
        }

        private void OpenGatewayButton_Click(object sender, EventArgs e)
        {
            string gatewayAddress = WifiAdminTools.CurrentNetworkSettings.ReturnCurrentGateway();
            try
            {
                    System.Diagnostics.Process.Start(gatewayAddress);
            }
            catch
            {
                MessageBox.Show(
                        "An error occured when trying to connect to the gateway address: " + gatewayAddress + "\nPlease try again later.",
                        "Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void RenewButton_Click(object sender, EventArgs e)
        {
            WifiAdminTools.CurrentNetworkSettings.RenewAdapter();
            MessageBox.Show(
                "IP address has been renewed.",
                "IP Address Renewed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void LoadUpdateDNSServers()
        {
            foreach ( string dnsAddress in WifiAdminTools.CurrentNetworkSettings.ReturnDNSServers())
            {
                dnsServersListBox.Items.Add(dnsAddress);
            }
        }

        private void LoadMacAddress()
        {
            macAddressLabel.Text = WifiAdminTools.CurrentNetworkSettings.ReturnMacAddress();
        }

        private void DeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Developed by Ryan Trotter\n\nVisit developer's Github page?",
                "About",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.github.com/rytrotter");
            }
        }

        private void ThisProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
             "Visit this project's Github page?",
             "About",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Information) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/rytrotter/Wireless-Administration-Tool");
            }
        }
    }
}
