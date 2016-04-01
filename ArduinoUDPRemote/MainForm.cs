using System;
using System.Timers;
using System.Windows.Forms;
using ArduinoUDPRemote.Helpers;

namespace ArduinoUDPRemote
{
    public partial class MainForm : Form
    {
        private const string BROADCAST_IP = "192.168.0.103";
        private const int BROADCAST_PORT = 9999;
        private const int BROADCAST_PER_SEC = 25;
        private const int ACCELERATION_TIME_MS = 2000;

        private bool isRunning;

        private CommandStateHolder cmd;
        private System.Timers.Timer timer;

        public MainForm()
        {
            InitializeComponent();

            cmd = new CommandStateHolder(BROADCAST_IP, BROADCAST_PORT, BROADCAST_PER_SEC, ACCELERATION_TIME_MS);

            timer = GetNewTimer(1000 / BROADCAST_PER_SEC);

            tb_udpPacketsPerSec.Value = BROADCAST_PER_SEC;
            tb_accelerationTimeInMs.Value = ACCELERATION_TIME_MS;

            timer.Enabled = false;
            isRunning = false;

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
    }
}
