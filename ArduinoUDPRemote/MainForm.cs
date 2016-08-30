using System;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using ArduinoUDPRemote.Helpers;
using ArduinoUDPRemote.StreamHelpers;
using MjpegProcessor;

namespace ArduinoUDPRemote
{
    public partial class MainForm : Form
    {
        private const string BROADCAST_IP = "192.168.0.103";
        private const int BROADCAST_PORT = 9999;
        private const int BROADCAST_PER_SEC = 25;
        private const int ACCELERATION_TIME_MS = 2000;
        private const bool ACCELERATION_ENABLED = true;
        private const int DEFAULT_MAX_SPEED = 16;

        private const bool DEFAULT_HEADLIGHTS_STATUS = false;
        private const bool DEFAULT_REARLIGHTS_STATUS = false;

        private bool isRunning;

        private CommandStateHolder cmd;
        private System.Timers.Timer timer;

        private StreamCommander streamCmd;
        private const string STEAM_BASE_URI = "http://10.10.67.198:8080";

        public MainForm()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            InitializeComponent();

            CommandStateHolderSettings cmdSettings = new CommandStateHolderSettings()
            {
                IpAddress = BROADCAST_IP,
                Port = BROADCAST_PORT,
                UDPPacketsPerSecond = BROADCAST_PER_SEC,
                AccelerationTime = ACCELERATION_TIME_MS,
                Acceleration = ACCELERATION_ENABLED,
                MaxSpeed = DEFAULT_MAX_SPEED,
                FrontLightsState = DEFAULT_HEADLIGHTS_STATUS,
                RearLigthsState = DEFAULT_REARLIGHTS_STATUS
            };

            cmd = new CommandStateHolder(cmdSettings);

            timer = GetNewTimer(1000 / BROADCAST_PER_SEC);

            tb_udpPacketsPerSec.Value = BROADCAST_PER_SEC;
            tb_accelerationTimeInMs.Value = ACCELERATION_TIME_MS;
            check_Acceleration.Checked = ACCELERATION_ENABLED;

            timer.Enabled = false;
            isRunning = false;

            streamCmd = new StreamCommander(STEAM_BASE_URI);
            streamCmd.Decoder.FrameReady += mjpeg_FrameReady;

            streamHolder.SizeMode = PictureBoxSizeMode.StretchImage;

            InitGUI();
        }

        private System.Timers.Timer GetNewTimer(int timesPerSec)
        {
            if (timer != null) timer.Dispose();

            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(SendData);
            timer.Interval = 1000 / timesPerSec;

            speedLabel.Text = string.Format("{0} sent/s", timer.Interval);

            return timer;
        }

        private void InitGUI()
        {
            string[] IPParts = BROADCAST_IP.Split('.');

            if (IPParts.Length == 4)
            {
                tbIP1.Text = IPParts[0];
                tbIP2.Text = IPParts[1];
                tbIP3.Text = IPParts[2];
                tbIP4.Text = IPParts[3];
            }

            tbPort.Text = BROADCAST_PORT.ToString();

            tb_udpPacketsPerSec.Value = BROADCAST_PER_SEC;

            ToggleGUI(!isRunning);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            cmd.SetState(e.KeyData, true);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            cmd.SetState(e.KeyData, false);
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Enabled = false;
                ToggleGUI(true);
            }
            else
            {
                int[] ip = new int[4];
                int port = 0;

                bool parseSuccess =
                    int.TryParse(tbIP1.Text, out ip[0]) &&
                    int.TryParse(tbIP2.Text, out ip[1]) &&
                    int.TryParse(tbIP3.Text, out ip[2]) &&
                    int.TryParse(tbIP4.Text, out ip[3]) &&
                    int.TryParse(tbPort.Text, out port);

                if (parseSuccess)
                {
                    string fullIP = string.Join(".", ip);

                    cmd.UpdateIPAndPort(fullIP, port);
                }

                timer.Enabled = true;
                ToggleGUI(false);
            }

            isRunning = !isRunning;
        }

        private void ToggleGUI(bool enabled)
        {
            tbPort.Enabled = enabled;
            tbIP1.Enabled = enabled;
            tbIP2.Enabled = enabled;
            tbIP3.Enabled = enabled;
            tbIP4.Enabled = enabled;

            if (enabled)
            {
                toggleButton.Text = "Start";
            }
            else
            {
                toggleButton.Text = "Stop";
            }

            labelIP.Focus();
        }

        private void SendData(object sender, ElapsedEventArgs e)
        {
            string sentData = cmd.SendData();

            try
            {
                Invoke((MethodInvoker)delegate
                {
                    cmdSentLabel.Text = sentData; // runs on UI thread
                    check_headLights.Checked = cmd.FrontLigthsState;
                    check_stopLights.Checked = cmd.RearLigthsState;
                });
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Could not update UI, MainForm was disposed already");
            }
        }

        private void updateUDPPacketsButton_Click(object sender, EventArgs e)
        {
            cmd.BroadcastResolution = (int)tb_udpPacketsPerSec.Value;
            timer = GetNewTimer(1000 / cmd.BroadcastResolution);

            if (isRunning)
            {
                timer.Start();
            }
        }

        private void updateAccelerationTime_Click(object sender, EventArgs e)
        {
            cmd.AccelerationTime = (int)tb_accelerationTimeInMs.Value;
        }

        private void check_Acceleration_CheckedChanged(object sender, EventArgs e)
        {
            cmd.AccelerationEnabled = check_Acceleration.Checked;
        }

        private void tb_speedLimiter_ValueChanged(object sender, EventArgs e)
        {
            cmd.MaxSpeed = (int)tb_speedLimiter.Value;
        }

        private void btn_minSpeed_Click(object sender, EventArgs e)
        {
            tb_speedLimiter.Value = 1;
        }

        private void btn_maxSpeed_Click(object sender, EventArgs e)
        {
            tb_speedLimiter.Value = 16;
        }

        private void check_headLights_CheckedChanged(object sender, EventArgs e)
        {
            cmd.FrontLigthsState = check_headLights.Checked;
        }

        private void check_stopLights_CheckedChanged(object sender, EventArgs e)
        {
            cmd.RearLigthsState = check_stopLights.Checked;
        }

        private void btn_startVideo_Click(object sender, EventArgs e)
        {
            streamCmd.Start();
        }

        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            streamHolder.Image = streamCmd.LatestFrame();
            streamHolder.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            streamHolder.Height = streamHolder.Height * 2;
            streamHolder.Width = streamHolder.Width * 2;

            streamHolder.Update();
        }

        private void btn_resolution176_Click(object sender, EventArgs e)
        {
            streamCmd.SetResolution("176x144");
        }

        private void btn_resolution320_Click(object sender, EventArgs e)
        {
            streamCmd.SetResolution("320x240");
        }

        private void btn_resolution640_Click(object sender, EventArgs e)
        {
            streamCmd.SetResolution("640x360");
        }

        private void btn_resolution1280_Click(object sender, EventArgs e)
        {
            streamCmd.SetResolution("1280x720");
        }

        private void btn_lightOn_Click(object sender, EventArgs e)
        {
            streamCmd.ToggleLight(true);
        }

        private void btn_lightOff_Click(object sender, EventArgs e)
        {
            streamCmd.ToggleLight(false);
        }

        private void btn_cameraFront_Click(object sender, EventArgs e)
        {
            streamCmd.ToggleFrontCamera(true);
        }

        private void btn_cameraBack_Click(object sender, EventArgs e)
        {
            streamCmd.ToggleFrontCamera(false);
        }
    }
}
