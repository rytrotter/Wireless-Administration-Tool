using System.Linq;
using System.Collections.Generic;
using System.Text;
using NativeWifi;

namespace WifiAdminTools
{
    class ScanForNetworks
    {

        public static List<Networking.ScannedNetworkInfo> GatherScannedNetworkInfo()
        {
            List<Networking.ScannedNetworkInfo> listOfNetworks = new List<Networking.ScannedNetworkInfo>();
            
            // Gathers interfaces to use
            foreach ( WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces )
            {
                Wlan.WlanAvailableNetwork[] scannedNetworks = wlanInterface.GetAvailableNetworkList(Wlan.WlanGetAvailableNetworkFlags.IncludeAllManualHiddenProfiles);
                // Goes through each networkIndex it sees to parse information
                foreach (Wlan.WlanAvailableNetwork networkIndex in scannedNetworks)
                {
                    Networking.ScannedNetworkInfo networkInfo = new Networking.ScannedNetworkInfo();
                    Wlan.Dot11Ssid ssid = networkIndex.dot11Ssid;
                    string networkName = "";

                    networkName = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);

                    if ( string.IsNullOrEmpty(networkName) )
                    {
                        networkName = "*Hidden Network*";
                    }
                    else if ( networkName == CurrentNetworkSettings.ReturnNetworkName() )
                    {
                        // Prevents your current connected network from showing in the available network list
                        continue;
                    }
                    else
                    {
                        networkName = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
                    }

                    string networkSecurity = networkIndex.dot11DefaultCipherAlgorithm.ToString();
                    string networkSignalStrength = networkIndex.wlanSignalQuality.ToString() + "%";

                    listOfNetworks.Add(new Networking.ScannedNetworkInfo
                        {
                            SSID = networkName,
                            SecurityType = networkSecurity,
                            SignalStrength = networkSignalStrength
                        });
                }
                
            }

            listOfNetworks = listOfNetworks.OrderByDescending(s => s.SignalStrength).ToList();
            return listOfNetworks;
        }
    }
}
