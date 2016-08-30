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
            this.btn_startVideo = new System.Windows.Forms.Button();
            this.streamHolder = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_resolution320 = new System.Windows.Forms.Button();
            this.btn_resolution640 = new System.Windows.Forms.Button();
            this.btn_resolution176 = new System.Windows.Forms.Button();
            this.btn_lightOn = new System.Windows.Forms.Button();
            this.btn_lightOff = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cameraBack = new System.Windows.Forms.Button();
            this.btn_cameraFront = new System.Windows.Forms.Button();
            this.btn_resolution1280 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_udpPacketsPerSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accelerationTimeInMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_speedLimiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamHolder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(243, 37);
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
            this.labelIP.Location = new System.Drawing.Point(13, 23);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 2;
            this.labelIP.Text = "IP";
            // 
            // tbIP1
            // 
            this.tbIP1.Location = new System.Drawing.Point(13, 39);
            this.tbIP1.MaxLength = 3;
            this.tbIP1.Name = "tbIP1";
            this.tbIP1.Size = new System.Drawing.Size(33, 20);
            this.tbIP1.TabIndex = 1;
            // 
            // tbIP2
            // 
            this.tbIP2.Location = new System.Drawing.Point(52, 39);
            this.tbIP2.MaxLength = 3;
            this.tbIP2.Name = "tbIP2";
            this.tbIP2.Size = new System.Drawing.Size(33, 20);
            this.tbIP2.TabIndex = 2;
            // 
            // tbIP3
            // 
            this.tbIP3.Location = new System.Drawing.Point(91, 39);
            this.tbIP3.MaxLength = 3;
            this.tbIP3.Name = "tbIP3";
            this.tbIP3.Size = new System.Drawing.Size(33, 20);
            this.tbIP3.TabIndex = 3;
            // 
            // tbIP4
            // 
            this.tbIP4.Location = new System.Drawing.Point(130, 39);
            this.tbIP4.MaxLength = 3;
            this.tbIP4.Name = "tbIP4";
            this.tbIP4.Size = new System.Drawing.Size(33, 20);
            this.tbIP4.TabIndex = 4;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(176, 39);
            this.tbPort.MaxLength = 5;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(45, 20);
            this.tbPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(49, 103);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 13);
            this.speedLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UDP packets per sec";
            // 
            // cmdLabel
            // 
            this.cmdLabel.AutoSize = true;
            this.cmdLabel.Location = new System.Drawing.Point(13, 126);
            this.cmdLabel.Name = "cmdLabel";
            this.cmdLabel.Size = new System.Drawing.Size(31, 13);
            this.cmdLabel.TabIndex = 4;
            this.cmdLabel.Text = "Cmd:";
            // 
            // cmdSentLabel
            // 
            this.cmdSentLabel.AutoSize = true;
            this.cmdSentLabel.Location = new System.Drawing.Point(50, 126);
            this.cmdSentLabel.Name = "cmdSentLabel";
            this.cmdSentLabel.Size = new System.Drawing.Size(0, 13);
            this.cmdSentLabel.TabIndex = 5;
            // 
            // updateUDPPacketsButton
            // 
            this.updateUDPPacketsButton.Location = new System.Drawing.Point(72, 68);
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
            this.tb_udpPacketsPerSec.Location = new System.Drawing.Point(16, 70);
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
            this.label4.Location = new System.Drawing.Point(188, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Acceleration time (ms)";
            // 
            // updateAccelerationTime
            // 
            this.updateAccelerationTime.Location = new System.Drawing.Point(249, 68);
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
            this.tb_accelerationTimeInMs.Location = new System.Drawing.Point(191, 70);
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
            this.check_Acceleration.Location = new System.Drawing.Point(191, 23);
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
            this.label5.Location = new System.Drawing.Point(188, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max speed (1-16)";
            // 
            // btn_maxSpeed
            // 
            this.btn_maxSpeed.Location = new System.Drawing.Point(266, 121);
            this.btn_maxSpeed.Name = "btn_maxSpeed";
            this.btn_maxSpeed.Size = new System.Drawing.Size(35, 23);
            this.btn_maxSpeed.TabIndex = 8;
            this.btn_maxSpeed.Text = "Max";
            this.btn_maxSpeed.UseVisualStyleBackColor = true;
            this.btn_maxSpeed.Click += new System.EventHandler(this.btn_maxSpeed_Click);
            // 
            // tb_speedLimiter
            // 
            this.tb_speedLimiter.Location = new System.Drawing.Point(229, 122);
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
            this.btn_minSpeed.Location = new System.Drawing.Point(191, 121);
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
            this.check_headLights.Location = new System.Drawing.Point(16, 23);
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
            this.check_stopLights.Location = new System.Drawing.Point(94, 23);
            this.check_stopLights.Name = "check_stopLights";
            this.check_stopLights.Size = new System.Drawing.Size(72, 17);
            this.check_stopLights.TabIndex = 10;
            this.check_stopLights.Text = "Stoplights";
            this.check_stopLights.UseVisualStyleBackColor = true;
            this.check_stopLights.CheckedChanged += new System.EventHandler(this.check_stopLights_CheckedChanged);
            // 
            // btn_startVideo
            // 
            this.btn_startVideo.Location = new System.Drawing.Point(205, 36);
            this.btn_startVideo.Name = "btn_startVideo";
            this.btn_startVideo.Size = new System.Drawing.Size(41, 23);
            this.btn_startVideo.TabIndex = 11;
            this.btn_startVideo.Text = "Start";
            this.btn_startVideo.UseVisualStyleBackColor = true;
            this.btn_startVideo.Click += new System.EventHandler(this.btn_startVideo_Click);
            // 
            // streamHolder
            // 
            this.streamHolder.Location = new System.Drawing.Point(12, 271);
            this.streamHolder.Name = "streamHolder";
            this.streamHolder.Size = new System.Drawing.Size(640, 360);
            this.streamHolder.TabIndex = 12;
            this.streamHolder.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIP1);
            this.groupBox1.Controls.Add(this.toggleButton);
            this.groupBox1.Controls.Add(this.tbIP2);
            this.groupBox1.Controls.Add(this.tbIP3);
            this.groupBox1.Controls.Add(this.tbIP4);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.labelIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btn_startVideo);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 71);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video stream";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stream url";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_headLights);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.updateUDPPacketsButton);
            this.groupBox3.Controls.Add(this.tb_udpPacketsPerSec);
            this.groupBox3.Controls.Add(this.cmdSentLabel);
            this.groupBox3.Controls.Add(this.check_Acceleration);
            this.groupBox3.Controls.Add(this.cmdLabel);
            this.groupBox3.Controls.Add(this.speedLabel);
            this.groupBox3.Controls.Add(this.check_stopLights);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_speedLimiter);
            this.groupBox3.Controls.Add(this.btn_minSpeed);
            this.groupBox3.Controls.Add(this.tb_accelerationTimeInMs);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_maxSpeed);
            this.groupBox3.Controls.Add(this.updateAccelerationTime);
            this.groupBox3.Location = new System.Drawing.Point(341, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 156);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            // 
            // btn_resolution320
            // 
            this.btn_resolution320.Location = new System.Drawing.Point(81, 41);
            this.btn_resolution320.Name = "btn_resolution320";
            this.btn_resolution320.Size = new System.Drawing.Size(66, 23);
            this.btn_resolution320.TabIndex = 16;
            this.btn_resolution320.Text = "320x240";
            this.btn_resolution320.UseVisualStyleBackColor = true;
            this.btn_resolution320.Click += new System.EventHandler(this.btn_resolution320_Click);
            // 
            // btn_resolution640
            // 
            this.btn_resolution640.Location = new System.Drawing.Point(148, 41);
            this.btn_resolution640.Name = "btn_resolution640";
            this.btn_resolution640.Size = new System.Drawing.Size(66, 23);
            this.btn_resolution640.TabIndex = 17;
            this.btn_resolution640.Text = "640x360";
            this.btn_resolution640.UseVisualStyleBackColor = true;
            this.btn_resolution640.Click += new System.EventHandler(this.btn_resolution640_Click);
            // 
            // btn_resolution176
            // 
            this.btn_resolution176.Location = new System.Drawing.Point(14, 41);
            this.btn_resolution176.Name = "btn_resolution176";
            this.btn_resolution176.Size = new System.Drawing.Size(66, 23);
            this.btn_resolution176.TabIndex = 19;
            this.btn_resolution176.Text = "176x144";
            this.btn_resolution176.UseVisualStyleBackColor = true;
            this.btn_resolution176.Click += new System.EventHandler(this.btn_resolution176_Click);
            // 
            // btn_lightOn
            // 
            this.btn_lightOn.Location = new System.Drawing.Point(303, 41);
            this.btn_lightOn.Name = "btn_lightOn";
            this.btn_lightOn.Size = new System.Drawing.Size(33, 23);
            this.btn_lightOn.TabIndex = 20;
            this.btn_lightOn.Text = "On";
            this.btn_lightOn.UseVisualStyleBackColor = true;
            this.btn_lightOn.Click += new System.EventHandler(this.btn_lightOn_Click);
            // 
            // btn_lightOff
            // 
            this.btn_lightOff.Location = new System.Drawing.Point(336, 41);
            this.btn_lightOff.Name = "btn_lightOff";
            this.btn_lightOff.Size = new System.Drawing.Size(33, 23);
            this.btn_lightOff.TabIndex = 21;
            this.btn_lightOff.Text = "Off";
            this.btn_lightOff.UseVisualStyleBackColor = true;
            this.btn_lightOff.Click += new System.EventHandler(this.btn_lightOff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Resolution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Light";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btn_cameraBack);
            this.groupBox4.Controls.Add(this.btn_cameraFront);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btn_resolution320);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_resolution640);
            this.groupBox4.Controls.Add(this.btn_lightOff);
            this.groupBox4.Controls.Add(this.btn_resolution1280);
            this.groupBox4.Controls.Add(this.btn_lightOn);
            this.groupBox4.Controls.Add(this.btn_resolution176);
            this.groupBox4.Location = new System.Drawing.Point(12, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(495, 81);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video controls";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Camera";
            // 
            // btn_cameraBack
            // 
            this.btn_cameraBack.Location = new System.Drawing.Point(441, 41);
            this.btn_cameraBack.Name = "btn_cameraBack";
            this.btn_cameraBack.Size = new System.Drawing.Size(40, 23);
            this.btn_cameraBack.TabIndex = 24;
            this.btn_cameraBack.Text = "Back";
            this.btn_cameraBack.UseVisualStyleBackColor = true;
            this.btn_cameraBack.Click += new System.EventHandler(this.btn_cameraBack_Click);
            // 
            // btn_cameraFront
            // 
            this.btn_cameraFront.Location = new System.Drawing.Point(401, 41);
            this.btn_cameraFront.Name = "btn_cameraFront";
            this.btn_cameraFront.Size = new System.Drawing.Size(40, 23);
            this.btn_cameraFront.TabIndex = 23;
            this.btn_cameraFront.Text = "Front";
            this.btn_cameraFront.UseVisualStyleBackColor = true;
            this.btn_cameraFront.Click += new System.EventHandler(this.btn_cameraFront_Click);
            // 
            // btn_resolution1280
            // 
            this.btn_resolution1280.Location = new System.Drawing.Point(215, 41);
            this.btn_resolution1280.Name = "btn_resolution1280";
            this.btn_resolution1280.Size = new System.Drawing.Size(66, 23);
            this.btn_resolution1280.TabIndex = 18;
            this.btn_resolution1280.Text = "1280x720";
            this.btn_resolution1280.UseVisualStyleBackColor = true;
            this.btn_resolution1280.Click += new System.EventHandler(this.btn_resolution1280_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 643);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.streamHolder);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "WiFi Car Remote";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tb_udpPacketsPerSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accelerationTimeInMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_speedLimiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamHolder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_startVideo;
        private System.Windows.Forms.PictureBox streamHolder;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_resolution320;
        private System.Windows.Forms.Button btn_resolution640;
        private System.Windows.Forms.Button btn_resolution176;
        private System.Windows.Forms.Button btn_lightOn;
        private System.Windows.Forms.Button btn_lightOff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cameraBack;
        private System.Windows.Forms.Button btn_cameraFront;
        private System.Windows.Forms.Button btn_resolution1280;
    }
}

