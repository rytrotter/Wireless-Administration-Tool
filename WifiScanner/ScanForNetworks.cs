using System;
using System.Collections.Generic;
using System.Text;
using NativeWifi;

namespace WifiAdminTools
{
    class ScanForNetworks
    {

        public static List<Networking.NetworkInfo> GatherScannedNetworkInfo()
        {
            List<Networking.NetworkInfo> listOfNetworks = new List<Networking.NetworkInfo>();
            
            // Gathers interfaces to use
            foreach ( WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces )
            {
                Wlan.WlanAvailableNetwork[] scannedNetworks = wlanInterface.GetAvailableNetworkList(Wlan.WlanGetAvailableNetworkFlags.IncludeAllManualHiddenProfiles);
                // Goes through each networkIndex it sees to parse information
                foreach (Wlan.WlanAvailableNetwork networkIndex in scannedNetworks)
                {
                    Networking.NetworkInfo networkInfo = new Networking.NetworkInfo();
                    Wlan.Dot11Ssid ssid = networkIndex.dot11Ssid;
                    string networkName = "";

                    if ( string.IsNullOrEmpty(Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength) ) || Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength) == " ")
                    {
                        networkName = "*Hidden Network*";
                    }
                    else
                    {
                        networkName = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
                    }

                    string networkSecurity = networkIndex.dot11DefaultCipherAlgorithm.ToString();
                    string networkSignalStrength = networkIndex.wlanSignalQuality.ToString();

                    listOfNetworks.Add(new Networking.NetworkInfo
                        {
                            SSID = networkName,
                            SecurityType = networkSecurity,
                            SignalStrength = networkSignalStrength
                        });
                }
                
            }
            
            return listOfNetworks;
        }
    }
}
