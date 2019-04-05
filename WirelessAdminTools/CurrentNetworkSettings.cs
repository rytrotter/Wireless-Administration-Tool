using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using NativeWifi;
using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace WifiAdminTools
{
    class CurrentNetworkSettings
    {
        // A super high tech way of checking if computer is currently connected to internet
        public static bool IsConnected()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://www.google.com"))
                {
                    return true;
                }
            } 
            catch
            {
                return false;
            }
        }

        public static string ReturnNetworkName()
        {
            string connectedNetwork = string.Empty;
            try
            {
                foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
                {
                    Wlan.Dot11Ssid ssid = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid;
                    connectedNetwork = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
                }
            }
            catch
            {
                if (string.IsNullOrEmpty(connectedNetwork))
                {
                    connectedNetwork = "Not Connected";
                }
            }

            return connectedNetwork;
        }

        public static string ReturnCurrentIPv4()
        { 

            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var ipAddr in wlanInterface.NetworkInterface.GetIPProperties().UnicastAddresses)
                {
                    if (ipAddr.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ipAddr.Address.ToString();
                    }
                }
            }

            return SocketError.NotConnected.ToString();
        }

        public static string ReturnCurrentIPv6()
        {

            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var ipAddr in wlanInterface.NetworkInterface.GetIPProperties().UnicastAddresses)
                {
                    if (ipAddr.Address.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        return ipAddr.Address.ToString();
                    }
                }
            }

            return SocketError.NotConnected.ToString();
        }

        public static string ReturnIPv4Netmask()
        {
            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var ipAddr in wlanInterface.NetworkInterface.GetIPProperties().UnicastAddresses)
                {
                    if (ipAddr.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ipAddr.IPv4Mask.ToString();
                    }
                }
            }
            return SocketError.NotConnected.ToString();
        }

        public static string ReturnCurrentGateway()
        {
            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var ipAddr in wlanInterface.NetworkInterface.GetIPProperties().GatewayAddresses)
                {
                    return ipAddr.Address.ToString();
                }
            }
            return SocketError.NotConnected.ToString();
        }

        public static void RenewAdapter()
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo
            {
                FileName = "ipconfig",
                Arguments = "/renew",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process proc = Process.Start(procStartInfo);
            proc.WaitForExit();
        }

        public static List<string> ReturnDNSServers()
        {
            List<string> dnsServerAddresses = new List<string>();

            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var dnsAddr in wlanInterface.NetworkInterface.GetIPProperties().DnsAddresses)
                {
                    if (string.IsNullOrWhiteSpace(dnsAddr.ToString()))
                    {
                        dnsServerAddresses.Add(SocketError.NotConnected.ToString());
                    }
                    else
                    {
                        dnsServerAddresses.Add(dnsAddr.ToString());
                    }
                }
            }
            return dnsServerAddresses;
        }

        public static string ReturnMacAddress()
        {
            string macAddress = string.Empty;
            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                macAddress = string.Join(":", (from i in wlanInterface.NetworkInterface.GetPhysicalAddress().GetAddressBytes() select i.ToString("X2")).ToArray());
            }

            return macAddress;
        }

    }
}
