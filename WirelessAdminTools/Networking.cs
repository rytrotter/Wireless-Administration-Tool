using System;
using System.Net;
using System.Net.NetworkInformation;
using NativeWifi;
using SimpleWifi;

namespace WifiAdminTools
{
    class Networking
    {
        public static WlanClient client = new WlanClient(); // Making this a method prevents too many sessions opening and causing errors

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

        public class ScannedNetworkInfo
        {
            public string SSID { get; set; }
            public string SecurityType { get; set; }
            public string SignalStrength { get; set; }
        }

        public static bool pingAddress(string addressToPing)
        {
            bool addressPingable = false;
            Ping ping = null;

            try
            {
                ping = new Ping();
                PingReply pingReply = ping.Send(addressToPing);
                addressPingable = pingReply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard exception and return false
            }
            finally
            {
                if (ping != null)
                {
                    ping.Dispose();
                }
            }
            return addressPingable;
        }

        public static void ForgetCurrentNetwork()
        {
            foreach (WlanClient.WlanInterface wlanInterface in Networking.client.Interfaces)
            {
                if (wlanInterface.InterfaceState == Wlan.WlanInterfaceState.Connected)
                {
                    wlanInterface.DeleteProfile(wlanInterface.CurrentConnection.profileName.ToString());
                }
            }
        }

        public static void ConnectToNetwork(string networkToConnectTo)
        {
            
        }
    }
}
