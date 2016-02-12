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
            this.resolutionSlider = new System.Windows.Forms.TrackBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.resolutionSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(148, 130);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(75, 23);
            this.toggleButton.TabIndex = 0;
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
            // resolutionSlider
            // 
            this.resolutionSlider.Location = new System.Drawing.Point(12, 79);
            this.resolutionSlider.Name = "resolutionSlider";
            this.resolutionSlider.Size = new System.Drawing.Size(211, 45);
            this.resolutionSlider.TabIndex = 3;
            this.resolutionSlider.ValueChanged += new System.EventHandler(this.resolutionSlider_ValueChanged);
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
            this.tbIP2.TabIndex = 1;
            // 
            // tbIP3
            // 
            this.tbIP3.Location = new System.Drawing.Point(87, 25);
            this.tbIP3.MaxLength = 3;
            this.tbIP3.Name = "tbIP3";
            this.tbIP3.Size = new System.Drawing.Size(33, 20);
            this.tbIP3.TabIndex = 1;
            // 
            // tbIP4
            // 
            this.tbIP4.Location = new System.Drawing.Point(126, 25);
            this.tbIP4.MaxLength = 3;
            this.tbIP4.Name = "tbIP4";
            this.tbIP4.Size = new System.Drawing.Size(33, 20);
            this.tbIP4.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(178, 25);
            this.tbPort.MaxLength = 3;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(45, 20);
            this.tbPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(48, 127);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 13);
            this.speedLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UDP packets sent per second";
            // 
            // cmdLabel
            // 
            this.cmdLabel.AutoSize = true;
            this.cmdLabel.Location = new System.Drawing.Point(12, 150);
            this.cmdLabel.Name = "cmdLabel";
            this.cmdLabel.Size = new System.Drawing.Size(31, 13);
            this.cmdLabel.TabIndex = 4;
            this.cmdLabel.Text = "Cmd:";
            // 
            // cmdSentLabel
            // 
            this.cmdSentLabel.AutoSize = true;
            this.cmdSentLabel.Location = new System.Drawing.Point(49, 150);
            this.cmdSentLabel.Name = "cmdSentLabel";
            this.cmdSentLabel.Size = new System.Drawing.Size(0, 13);
            this.cmdSentLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 175);
            this.Controls.Add(this.cmdSentLabel);
            this.Controls.Add(this.cmdLabel);
            this.Controls.Add(this.resolutionSlider);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.label1);
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
            this.Text = "RC Remote";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.resolutionSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TrackBar resolutionSlider;
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
    }
}

