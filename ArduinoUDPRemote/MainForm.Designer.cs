namespace ArduinoUDPRemote
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toggleButton = new System.Windows.Forms.Button();
            this.labelIP = new System.Windows.Forms.Label();
            this.tbIP1 = new System.Windows.Forms.TextBox();
            this.tbIP2 = new System.Windows.Forms.TextBox();
            this.tbIP3 = new System.Windows.Forms.TextBox();
            this.tbIP4 = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdLabel = new System.Windows.Forms.Label();
            this.cmdSentLabel = new System.Windows.Forms.Label();
            this.updateUDPPacketsButton = new System.Windows.Forms.Button();
            this.tb_udpPacketsPerSec = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.updateAccelerationTime = new System.Windows.Forms.Button();
            this.tb_accelerationTimeInMs = new System.Windows.Forms.NumericUpDown();
            this.check_Acceleration = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_maxSpeed = new System.Windows.Forms.Button();
            this.tb_speedLimiter = new System.Windows.Forms.NumericUpDown();
            this.btn_minSpeed = new System.Windows.Forms.Button();
            this.check_headLights = new System.Windows.Forms.CheckBox();
            this.check_stopLights = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_udpPacketsPerSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accelerationTimeInMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_speedLimiter)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(242, 23);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(55, 23);
            this.toggleButton.TabIndex = 6;
            this.toggleButton.Text = "Start";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 9);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 2;
            this.labelIP.Text = "IP";
            // 
            // tbIP1
            // 
            this.tbIP1.Location = new System.Drawing.Point(12, 25);
            this.tbIP1.MaxLength = 3;
            this.tbIP1.Name = "tbIP1";
            this.tbIP1.Size = new System.Drawing.Size(33, 20);
            this.tbIP1.TabIndex = 1;
            // 
            // tbIP2
            // 
            this.tbIP2.Location = new System.Drawing.Point(51, 25);
            this.tbIP2.MaxLength = 3;
            this.tbIP2.Name = "tbIP2";
            this.tbIP2.Size = new System.Drawing.Size(33, 20);
            this.tbIP2.TabIndex = 2;
            // 
            // tbIP3
            // 
            this.tbIP3.Location = new System.Drawing.Point(90, 25);
            this.tbIP3.MaxLength = 3;
            this.tbIP3.Name = "tbIP3";
            this.tbIP3.Size = new System.Drawing.Size(33, 20);
            this.tbIP3.TabIndex = 3;
            // 
            // tbIP4
            // 
            this.tbIP4.Location = new System.Drawing.Point(129, 25);
            this.tbIP4.MaxLength = 3;
            this.tbIP4.Name = "tbIP4";
            this.tbIP4.Size = new System.Drawing.Size(33, 20);
            this.tbIP4.TabIndex = 4;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(175, 25);
            this.tbPort.MaxLength = 5;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(45, 20);
            this.tbPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(45, 150);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 13);
            this.speedLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UDP packets per sec";
            // 
            // cmdLabel
            // 
            this.cmdLabel.AutoSize = true;
            this.cmdLabel.Location = new System.Drawing.Point(9, 173);
            this.cmdLabel.Name = "cmdLabel";
            this.cmdLabel.Size = new System.Drawing.Size(31, 13);
            this.cmdLabel.TabIndex = 4;
            this.cmdLabel.Text = "Cmd:";
            // 
            // cmdSentLabel
            // 
            this.cmdSentLabel.AutoSize = true;
            this.cmdSentLabel.Location = new System.Drawing.Point(46, 173);
            this.cmdSentLabel.Name = "cmdSentLabel";
            this.cmdSentLabel.Size = new System.Drawing.Size(0, 13);
            this.cmdSentLabel.TabIndex = 5;
            // 
            // updateUDPPacketsButton
            // 
            this.updateUDPPacketsButton.Location = new System.Drawing.Point(68, 110);
            this.updateUDPPacketsButton.Name = "updateUDPPacketsButton";
            this.updateUDPPacketsButton.Size = new System.Drawing.Size(52, 23);
            this.updateUDPPacketsButton.TabIndex = 8;
            this.updateUDPPacketsButton.Text = "Update";
            this.updateUDPPacketsButton.UseVisualStyleBackColor = true;
            this.updateUDPPacketsButton.Click += new System.EventHandler(this.updateUDPPacketsButton_Click);
            // 
            // tb_udpPacketsPerSec
            // 
            this.tb_udpPacketsPerSec.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tb_udpPacketsPerSec.Location = new System.Drawing.Point(12, 112);
            this.tb_udpPacketsPerSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_udpPacketsPerSec.Name = "tb_udpPacketsPerSec";
            this.tb_udpPacketsPerSec.Size = new System.Drawing.Size(50, 20);
            this.tb_udpPacketsPerSec.TabIndex = 9;
            this.tb_udpPacketsPerSec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Acceleration time (ms)";
            // 
            // updateAccelerationTime
            // 
            this.updateAccelerationTime.Location = new System.Drawing.Point(245, 110);
            this.updateAccelerationTime.Name = "updateAccelerationTime";
            this.updateAccelerationTime.Size = new System.Drawing.Size(52, 23);
            this.updateAccelerationTime.TabIndex = 8;
            this.updateAccelerationTime.Text = "Update";
            this.updateAccelerationTime.UseVisualStyleBackColor = true;
            this.updateAccelerationTime.Click += new System.EventHandler(this.updateAccelerationTime_Click);
            // 
            // tb_accelerationTimeInMs
            // 
            this.tb_accelerationTimeInMs.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.tb_accelerationTimeInMs.Location = new System.Drawing.Point(187, 112);
            this.tb_accelerationTimeInMs.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tb_accelerationTimeInMs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_accelerationTimeInMs.Name = "tb_accelerationTimeInMs";
            this.tb_accelerationTimeInMs.Size = new System.Drawing.Size(50, 20);
            this.tb_accelerationTimeInMs.TabIndex = 9;
            this.tb_accelerationTimeInMs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // check_Acceleration
            // 
            this.check_Acceleration.AutoSize = true;
            this.check_Acceleration.Location = new System.Drawing.Point(187, 65);
            this.check_Acceleration.Name = "check_Acceleration";
            this.check_Acceleration.Size = new System.Drawing.Size(85, 17);
            this.check_Acceleration.TabIndex = 10;
            this.check_Acceleration.Text = "Acceleration";
            this.check_Acceleration.UseVisualStyleBackColor = true;
            this.check_Acceleration.CheckedChanged += new System.EventHandler(this.check_Acceleration_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max speed (1-16)";
            // 
            // btn_maxSpeed
            // 
            this.btn_maxSpeed.Location = new System.Drawing.Point(262, 168);
            this.btn_maxSpeed.Name = "btn_maxSpeed";
            this.btn_maxSpeed.Size = new System.Drawing.Size(35, 23);
            this.btn_maxSpeed.TabIndex = 8;
            this.btn_maxSpeed.Text = "Max";
            this.btn_maxSpeed.UseVisualStyleBackColor = true;
            this.btn_maxSpeed.Click += new System.EventHandler(this.btn_maxSpeed_Click);
            // 
            // tb_speedLimiter
            // 
            this.tb_speedLimiter.Location = new System.Drawing.Point(225, 169);
            this.tb_speedLimiter.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tb_speedLimiter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_speedLimiter.Name = "tb_speedLimiter";
            this.tb_speedLimiter.Size = new System.Drawing.Size(34, 20);
            this.tb_speedLimiter.TabIndex = 9;
            this.tb_speedLimiter.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tb_speedLimiter.ValueChanged += new System.EventHandler(this.tb_speedLimiter_ValueChanged);
            // 
            // btn_minSpeed
            // 
            this.btn_minSpeed.Location = new System.Drawing.Point(187, 168);
            this.btn_minSpeed.Name = "btn_minSpeed";
            this.btn_minSpeed.Size = new System.Drawing.Size(35, 23);
            this.btn_minSpeed.TabIndex = 8;
            this.btn_minSpeed.Text = "Min";
            this.btn_minSpeed.UseVisualStyleBackColor = true;
            this.btn_minSpeed.Click += new System.EventHandler(this.btn_minSpeed_Click);
            // 
            // check_headLights
            // 
            this.check_headLights.AutoSize = true;
            this.check_headLights.Location = new System.Drawing.Point(12, 65);
            this.check_headLights.Name = "check_headLights";
            this.check_headLights.Size = new System.Drawing.Size(76, 17);
            this.check_headLights.TabIndex = 10;
            this.check_headLights.Text = "Headlights";
            this.check_headLights.UseVisualStyleBackColor = true;
            this.check_headLights.CheckedChanged += new System.EventHandler(this.check_headLights_CheckedChanged);
            // 
            // check_stopLights
            // 
            this.check_stopLights.AutoSize = true;
            this.check_stopLights.Location = new System.Drawing.Point(90, 65);
            this.check_stopLights.Name = "check_stopLights";
            this.check_stopLights.Size = new System.Drawing.Size(72, 17);
            this.check_stopLights.TabIndex = 10;
            this.check_stopLights.Text = "Stoplights";
            this.check_stopLights.UseVisualStyleBackColor = true;
            this.check_stopLights.CheckedChanged += new System.EventHandler(this.check_stopLights_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 204);
            this.Controls.Add(this.check_stopLights);
            this.Controls.Add(this.check_headLights);
            this.Controls.Add(this.check_Acceleration);
            this.Controls.Add(this.tb_speedLimiter);
            this.Controls.Add(this.tb_accelerationTimeInMs);
            this.Controls.Add(this.btn_minSpeed);
            this.Controls.Add(this.btn_maxSpeed);
            this.Controls.Add(this.updateAccelerationTime);
            this.Controls.Add(this.tb_udpPacketsPerSec);
            this.Controls.Add(this.updateUDPPacketsButton);
            this.Controls.Add(this.cmdSentLabel);
            this.Controls.Add(this.cmdLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP4);
            this.Controls.Add(this.tbIP3);
            this.Controls.Add(this.tbIP2);
            this.Controls.Add(this.tbIP1);
            this.Controls.Add(this.toggleButton);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "WiFi Car Remote";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tb_udpPacketsPerSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accelerationTimeInMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_speedLimiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox tbIP1;
        private System.Windows.Forms.TextBox tbIP2;
        private System.Windows.Forms.TextBox tbIP3;
        private System.Windows.Forms.TextBox tbIP4;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cmdLabel;
        private System.Windows.Forms.Label cmdSentLabel;
        private System.Windows.Forms.Button updateUDPPacketsButton;
        private System.Windows.Forms.NumericUpDown tb_udpPacketsPerSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tb_accelerationTimeInMs;
        private System.Windows.Forms.Button updateAccelerationTime;
        private System.Windows.Forms.CheckBox check_Acceleration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_maxSpeed;
        private System.Windows.Forms.NumericUpDown tb_speedLimiter;
        private System.Windows.Forms.Button btn_minSpeed;
        private System.Windows.Forms.CheckBox check_headLights;
        private System.Windows.Forms.CheckBox check_stopLights;
    }
}

