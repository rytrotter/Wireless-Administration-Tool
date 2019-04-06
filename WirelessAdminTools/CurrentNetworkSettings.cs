using NativeWifi;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;


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

        public static string ReturnInterfaceName()
        {
            string interfaceName = string.Empty;
            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                interfaceName = wlanInterface.InterfaceName.ToString();
            }
            return interfaceName;
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
                    connectedNetwork = SocketError.NotConnected.ToString();
                }
            }

            return connectedNetwork;
        }

        public static string ReturnNetworkSecurityType()
        {
            string securityType = string.Empty;
            try
            {
                foreach (WlanClient.WlanInterface wlaninterface in Networking.client.Interfaces)
                {
                    securityType = wlaninterface.CurrentConnection.wlanSecurityAttributes.dot11CipherAlgorithm.ToString();
                }
            }
            catch
            {
                securityType = SocketError.NotConnected.ToString();
            }
            return securityType;
        }

        public static string ReturnCurrentIPv4()
        {
            string ipv4Address = string.Empty;

            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var ipAddr in wlanInterface.NetworkInterface.GetIPProperties().UnicastAddresses)
                {
                    if (ipAddr.Address.AddressFamily == AddressFamily.InterNetwork && IsConnected() == true)
                    {
                        ipv4Address = ipAddr.Address.ToString();
                    }
                    else
                    {
                        ipv4Address = SocketError.NotConnected.ToString();
                    }
                }
            }

            return ipv4Address;
        }

        public static string ReturnCurrentIPv6()
        {
            string ipv6Address = string.Empty;

            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var ipAddr in wlanInterface.NetworkInterface.GetIPProperties().UnicastAddresses)
                {
                    if (ipAddr.Address.AddressFamily == AddressFamily.InterNetworkV6 && IsConnected() == true)
                    {
                        ipv6Address = ipAddr.Address.ToString();
                    }
                    else
                    {
                        ipv6Address = SocketError.NotConnected.ToString();
                    }
                }
            }

            return ipv6Address;
        }

        public static string ReturnIPv4Netmask()
        {
            string ipv4Netmask = string.Empty;

            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var ipAddr in wlanInterface.NetworkInterface.GetIPProperties().UnicastAddresses)
                {
                    if (ipAddr.Address.AddressFamily == AddressFamily.InterNetwork && IsConnected() == true)
                    {
                        ipv4Netmask = ipAddr.IPv4Mask.ToString();
                    }
                    else
                    {
                        ipv4Netmask = SocketError.NotConnected.ToString();
                    }
                }
            }
            return ipv4Netmask;
        }

        public static string ReturnCurrentGateway()
        {
            string gateway = string.Empty;

            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var ipAddr in wlanInterface.NetworkInterface.GetIPProperties().GatewayAddresses)
                {
                    if (ipAddr.Address.AddressFamily == AddressFamily.InterNetwork && IsConnected() == true)
                    {
                        gateway = ipAddr.Address.ToString();
                    }
                    else
                    {
                        gateway = SocketError.NotConnected.ToString();
                    }
                }
            }
            return gateway;
        }

        public static List<string> ReturnDNSServers()
        {
            List<string> dnsServerAddresses = new List<string>();

            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                foreach (var dnsAddr in wlanInterface.NetworkInterface.GetIPProperties().DnsAddresses)
                {
                    if (CurrentNetworkSettings.IsConnected() == false)
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

