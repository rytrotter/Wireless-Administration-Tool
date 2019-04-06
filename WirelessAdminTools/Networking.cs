using System;
using System.Net.NetworkInformation;
using NativeWifi;

namespace WifiAdminTools
{
    class Networking
    {
        public static WlanClient client = new WlanClient(); // Making this a method prevents too many sessions opening and causing errors

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
    }
}
