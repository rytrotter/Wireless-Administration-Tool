using System;
using System.Collections.Generic;
using System.Text;
using NativeWifi;

namespace WifiAdminTools
{
    class Networking
    {
        public static WlanClient client = new WlanClient(); // Making this a method prevents too many sessions opening and causing errors

        public class NetworkInfo
        {
            public string SSID { get; set; }
            public string SecurityType { get; set; }
            public string SignalStrength { get; set; }
        }
    }
}
