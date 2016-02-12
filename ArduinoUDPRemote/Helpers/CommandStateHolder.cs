using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoUDPRemote.Helpers
{
    public class CommandStateHolder
    {
        private ResolutionValuesEnum _broadcastResolution;

        private Dictionary<Keys, int> _keyStates;
        private List<Keys> _keysToWatch = new List<Keys>()
        {
            Keys.W,
            Keys.S,
            Keys.A,
            Keys.D,
            Keys.Space,

            Keys.Q,
            Keys.E
        };

        private Socket sock;
        private IPAddress parsedIP;
        private IPEndPoint endPoint;
        
        public ResolutionValuesEnum BroadcastResolution
        {
            get
            {
                return _broadcastResolution;
            }

            set
            {
                _broadcastResolution = value;
            }
        }

        public CommandStateHolder(string ip, int port, ResolutionValuesEnum resolution)
        {
            UpdateIPAndPort(ip, port);
            BroadcastResolution = resolution;

            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            
            _keyStates = new Dictionary<Keys, int>();

            InitializeKeyStates(_keyStates, false, _keysToWatch);
        }

        public void UpdateIPAndPort(string ip, int port)
        {
            parsedIP = IPAddress.Parse(ip);
            endPoint = new IPEndPoint(parsedIP, port);
        }

        public void SetState(Keys key, bool isPressed)
        {
            _keyStates[key] = isPressed ? 1 : 0;
        }

        public string GetState()
        {
            StringBuilder sb = new StringBuilder(_keysToWatch.Count);

            foreach (var key in _keysToWatch)
            {
                sb.Append(_keyStates[key]);
            }

            return sb.ToString();
        }

        public string SendData()
        {
            string currentState = GetState();

            byte[] sendBuf = Encoding.ASCII.GetBytes(currentState);
            sock.SendTo(sendBuf, endPoint);

            return currentState;
        }

        private void InitializeKeyStates(Dictionary<Keys, int> _keyStates, bool defaultVal, List<Keys> keys)
        {
            int initVal = defaultVal ? 1 : 0;

            foreach (var key in keys)
            {
                _keyStates.Add(key, initVal);
            }
        }
    }
}
