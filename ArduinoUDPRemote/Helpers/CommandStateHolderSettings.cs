using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoUDPRemote.Helpers
{
    public class CommandStateHolderSettings
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public int UDPPacketsPerSecond { get; set; }
        public bool Acceleration { get; set; }
        public int AccelerationTime { get; set; }

        public int MaxSpeed { get; set; }
        public bool FrontLightsState { get; set; }
        public bool RearLigthsState { get; set; }
    }
}
