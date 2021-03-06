﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private const Keys MOVE_FORWARD_KEY = Keys.W;
        private const Keys MOVE_BACKWARDS_KEY = Keys.S;
        private const Keys TURN_LEFT_KEY = Keys.A;
        private const Keys TURN_RIGHT_KEY = Keys.D;
        private const Keys HORN_KEY = Keys.Space;
        private const Keys FRONT_LIGHTS_KEY = Keys.Q;
        private const Keys REAR_LIGHTS_KEY = Keys.E;

        private int _moveForwardCounter = 0;
        private int _moveBackwardsCounter = 0;

        public bool FrontLigthsState { get; set; }
        public bool RearLigthsState { get; set; }

        private List<Keys> _keysToWatch;
        private Dictionary<Keys, int> _keyStates;

        private Socket sock;
        private IPAddress parsedIP;
        private IPEndPoint endPoint;

        public int BroadcastResolution { get; set; }
        public int AccelerationTime { get; set; }
        public bool AccelerationEnabled { get; set; }
        public int MaxSpeed { get; internal set; }

        // means that the car should accelerate fully in *value* sent UDP packets time
        public int AccelerationStepCount
        {
            get
            {
                return AccelerationTime / (1000 / BroadcastResolution);
            }
        }

        public CommandStateHolder(CommandStateHolderSettings init)
        {
            UpdateIPAndPort(init.IpAddress, init.Port);
            BroadcastResolution = init.UDPPacketsPerSecond;
            AccelerationTime = init.AccelerationTime;
            AccelerationEnabled = init.Acceleration;
            MaxSpeed = init.MaxSpeed;
            FrontLigthsState = init.FrontLightsState;
            RearLigthsState = init.RearLigthsState;
            
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            _keyStates = new Dictionary<Keys, int>();
            _keysToWatch = new List<Keys>();

            _keysToWatch.Add(MOVE_FORWARD_KEY);
            _keysToWatch.Add(MOVE_BACKWARDS_KEY);
            _keysToWatch.Add(TURN_LEFT_KEY);
            _keysToWatch.Add(TURN_RIGHT_KEY);
            _keysToWatch.Add(HORN_KEY);
            _keysToWatch.Add(FRONT_LIGHTS_KEY);
            _keysToWatch.Add(REAR_LIGHTS_KEY);

            InitializeKeyStates(_keyStates, _keysToWatch);
        }

        public void UpdateIPAndPort(string ip, int port)
        {
            parsedIP = IPAddress.Parse(ip);
            endPoint = new IPEndPoint(parsedIP, port);
        }

        public void SetState(Keys key, bool isPressed)
        {
            if (key == FRONT_LIGHTS_KEY)
            {
                if (isPressed) FrontLigthsState = !FrontLigthsState;
            }
            else if (key == REAR_LIGHTS_KEY)
            {
                if (isPressed) RearLigthsState = !RearLigthsState;
            }
            else
            {
                _keyStates[key] = isPressed ? 1 : 0;
            }
        }

        public string GetState()
        {
            StringBuilder sb = new StringBuilder(_keysToWatch.Count);

            foreach (var key in _keysToWatch)
            {
                if (key == MOVE_FORWARD_KEY || key == MOVE_BACKWARDS_KEY)
                {
                    sb.Append(GetStateForAcceleratingKey(key));
                }
                else if (key == FRONT_LIGHTS_KEY)
                {
                    sb.Append(FrontLigthsState ? 1 : 0);
                }
                else if (key == REAR_LIGHTS_KEY)
                {
                    sb.Append(RearLigthsState ? 1 : 0);
                }
                else
                {
                    sb.Append(_keyStates[key]);
                }
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

        private void InitializeKeyStates(Dictionary<Keys, int> _keyStates, List<Keys> keys)
        {
            int initVal = 0;

            foreach (var key in keys)
            {
                _keyStates.Add(key, initVal);
            }
        }

        private string GetStateForAcceleratingKey(Keys key)
        {
            if (key == MOVE_FORWARD_KEY)
            {
                if (_keyStates[key] == 0) // if key is not pressed
                {
                    _moveForwardCounter = 0;
                    return "0"; // return min value
                }
                else // if key is pressed
                {
                    if (AccelerationEnabled)
                    {
                        _moveForwardCounter++;

                        int speed = _moveForwardCounter.Map(0, AccelerationStepCount, 0, 15);
                        speed = speed < MaxSpeed ? speed : MaxSpeed;
                        string state = speed.ToString("X");
                        return state;
                    }
                    else
                    {
                        return "F"; // return max value
                    }
                }
            }
            else if (key == MOVE_BACKWARDS_KEY)
            {
                if (_keyStates[key] == 0)
                {
                    _moveBackwardsCounter = 0;
                    return "0";
                }
                else
                {
                    if (AccelerationEnabled)
                    {
                        _moveBackwardsCounter++;

                        int speed = _moveBackwardsCounter.Map(0, AccelerationStepCount, 0, 15);
                        speed = speed < MaxSpeed ? speed : MaxSpeed;
                        string state = speed.ToString("X");
                        return state;
                    }
                    else
                    {
                        return "F";
                    }
                }
            }
            else
            {
                return "0";
            }
        }
    }
}
