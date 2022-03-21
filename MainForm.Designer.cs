namespace xlcal_shutter_motor_control
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
            this.components = new System.ComponentModel.Container();
            this.timerMotorControl = new System.Windows.Forms.Timer(this.components);
            this.spbRotationAngle = new System.Windows.Forms.NumericUpDown();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.groupboxConfig = new System.Windows.Forms.GroupBox();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.btnStopMotor = new System.Windows.Forms.Button();
            this.btnSetZeroPos = new System.Windows.Forms.Button();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.labelComPortStatus = new System.Windows.Forms.Label();
            this.btnOpenClosePort = new System.Windows.Forms.Button();
            this.labelShutterStatus = new System.Windows.Forms.Label();
            this.btnStartStopControl = new System.Windows.Forms.Button();
            this.lblOnTime = new System.Windows.Forms.Label();
            this.spbOnTime = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupboxComms = new System.Windows.Forms.GroupBox();
            this.groupboxShutterCtrl = new System.Windows.Forms.GroupBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.lblOffTime = new System.Windows.Forms.Label();
            this.spbOffTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spbRotationAngle)).BeginInit();
            this.groupboxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbOnTime)).BeginInit();
            this.groupboxComms.SuspendLayout();
            this.groupboxShutterCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbOffTime)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMotorControl
            // 
            this.timerMotorControl.Interval = 1000;
            this.timerMotorControl.Tick += new System.EventHandler(this.timerShutterControl_Tick);
            // 
            // spbRotationAngle
            // 
            this.spbRotationAngle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spbRotationAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbRotationAngle.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spbRotationAngle.Location = new System.Drawing.Point(112, 28);
            this.spbRotationAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.spbRotationAngle.Name = "spbRotationAngle";
            this.spbRotationAngle.Size = new System.Drawing.Size(67, 26);
            this.spbRotationAngle.TabIndex = 8;
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRotateCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCW.Location = new System.Drawing.Point(185, 25);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(100, 31);
            this.btnRotateCW.TabIndex = 13;
            this.btnRotateCW.Text = "Rotate >>";
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.btnRotateCW_Click);
            // 
            // groupboxConfig
            // 
            this.groupboxConfig.Controls.Add(this.btnRotateCCW);
            this.groupboxConfig.Controls.Add(this.btnStopMotor);
            this.groupboxConfig.Controls.Add(this.btnSetZeroPos);
            this.groupboxConfig.Controls.Add(this.btnRotateCW);
            this.groupboxConfig.Controls.Add(this.spbRotationAngle);
            this.groupboxConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxConfig.Location = new System.Drawing.Point(13, 129);
            this.groupboxConfig.Name = "groupboxConfig";
            this.groupboxConfig.Size = new System.Drawing.Size(292, 161);
            this.groupboxConfig.TabIndex = 14;
            this.groupboxConfig.TabStop = false;
            this.groupboxConfig.Text = "Configure Motor Positions";
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRotateCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCCW.Location = new System.Drawing.Point(6, 25);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(100, 31);
            this.btnRotateCCW.TabIndex = 13;
            this.btnRotateCCW.Text = "<< Rotate";
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.btnRotateCCW_Click);
            // 
            // btnStopMotor
            // 
            this.btnStopMotor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStopMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMotor.Location = new System.Drawing.Point(95, 62);
            this.btnStopMotor.Name = "btnStopMotor";
            this.btnStopMotor.Size = new System.Drawing.Size(100, 31);
            this.btnStopMotor.TabIndex = 13;
            this.btnStopMotor.Text = "Stop";
            this.btnStopMotor.UseVisualStyleBackColor = true;
            this.btnStopMotor.Click += new System.EventHandler(this.btnStopMotor_Click);
            // 
            // btnSetZeroPos
            // 
            this.btnSetZeroPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetZeroPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetZeroPos.Location = new System.Drawing.Point(6, 124);
            this.btnSetZeroPos.Name = "btnSetZeroPos";
            this.btnSetZeroPos.Size = new System.Drawing.Size(279, 31);
            this.btnSetZeroPos.TabIndex = 13;
            this.btnSetZeroPos.Text = "Set zero (vertical) position";
            this.btnSetZeroPos.UseVisualStyleBackColor = true;
            this.btnSetZeroPos.Click += new System.EventHandler(this.btnSetZeroPos_Click);
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComPort.Location = new System.Drawing.Point(6, 37);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(82, 20);
            this.lblComPort.TabIndex = 15;
            this.lblComPort.Text = "COM Port:";
            this.lblComPort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbComPort
            // 
            this.cbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(94, 33);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(191, 28);
            this.cbComPort.TabIndex = 16;
            this.cbComPort.Click += new System.EventHandler(this.cbComPort_Click);
            // 
            // labelComPortStatus
            // 
            this.labelComPortStatus.BackColor = System.Drawing.Color.Red;
            this.labelComPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComPortStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelComPortStatus.Location = new System.Drawing.Point(6, 72);
            this.labelComPortStatus.Name = "labelComPortStatus";
            this.labelComPortStatus.Size = new System.Drawing.Size(155, 20);
            this.labelComPortStatus.TabIndex = 17;
            this.labelComPortStatus.Text = "Not connected";
            this.labelComPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenClosePort
            // 
            this.btnOpenClosePort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOpenClosePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenClosePort.Location = new System.Drawing.Point(167, 67);
            this.btnOpenClosePort.Name = "btnOpenClosePort";
            this.btnOpenClosePort.Size = new System.Drawing.Size(118, 30);
            this.btnOpenClosePort.TabIndex = 20;
            this.btnOpenClosePort.Text = "Open";
            this.btnOpenClosePort.UseVisualStyleBackColor = true;
            this.btnOpenClosePort.Click += new System.EventHandler(this.btnOpenClosePort_Click);
            // 
            // labelShutterStatus
            // 
            this.labelShutterStatus.AutoSize = true;
            this.labelShutterStatus.BackColor = System.Drawing.Color.Red;
            this.labelShutterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShutterStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelShutterStatus.Location = new System.Drawing.Point(67, 99);
            this.labelShutterStatus.Name = "labelShutterStatus";
            this.labelShutterStatus.Size = new System.Drawing.Size(44, 20);
            this.labelShutterStatus.TabIndex = 26;
            this.labelShutterStatus.Text = "OFF";
            // 
            // btnStartStopControl
            // 
            this.btnStartStopControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStartStopControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStopControl.Location = new System.Drawing.Point(170, 95);
            this.btnStartStopControl.Name = "btnStartStopControl";
            this.btnStartStopControl.Size = new System.Drawing.Size(89, 30);
            this.btnStartStopControl.TabIndex = 25;
            this.btnStartStopControl.Text = "Start";
            this.btnStartStopControl.UseVisualStyleBackColor = true;
            this.btnStartStopControl.Click += new System.EventHandler(this.btnStartStopControl_Click);
            // 
            // lblOnTime
            // 
            this.lblOnTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOnTime.AutoSize = true;
            this.lblOnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOnTime.Location = new System.Drawing.Point(6, 33);
            this.lblOnTime.Name = "lblOnTime";
            this.lblOnTime.Size = new System.Drawing.Size(96, 20);
            this.lblOnTime.TabIndex = 23;
            this.lblOnTime.Text = "Time ON (s):";
            // 
            // spbOnTime
            // 
            this.spbOnTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spbOnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbOnTime.Location = new System.Drawing.Point(170, 31);
            this.spbOnTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spbOnTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spbOnTime.Name = "spbOnTime";
            this.spbOnTime.Size = new System.Drawing.Size(89, 26);
            this.spbOnTime.TabIndex = 24;
            this.spbOnTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl1.Location = new System.Drawing.Point(6, 99);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 20);
            this.lbl1.TabIndex = 23;
            this.lbl1.Text = "Beam:";
            // 
            // groupboxComms
            // 
            this.groupboxComms.Controls.Add(this.btnOpenClosePort);
            this.groupboxComms.Controls.Add(this.lblComPort);
            this.groupboxComms.Controls.Add(this.cbComPort);
            this.groupboxComms.Controls.Add(this.labelComPortStatus);
            this.groupboxComms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxComms.Location = new System.Drawing.Point(13, 12);
            this.groupboxComms.Name = "groupboxComms";
            this.groupboxComms.Size = new System.Drawing.Size(292, 103);
            this.groupboxComms.TabIndex = 27;
            this.groupboxComms.TabStop = false;
            this.groupboxComms.Text = "Serial Port";
            // 
            // groupboxShutterCtrl
            // 
            this.groupboxShutterCtrl.BackColor = System.Drawing.SystemColors.Control;
            this.groupboxShutterCtrl.Controls.Add(this.lblOffTime);
            this.groupboxShutterCtrl.Controls.Add(this.lblOnTime);
            this.groupboxShutterCtrl.Controls.Add(this.labelShutterStatus);
            this.groupboxShutterCtrl.Controls.Add(this.spbOffTime);
            this.groupboxShutterCtrl.Controls.Add(this.spbOnTime);
            this.groupboxShutterCtrl.Controls.Add(this.btnStartStopControl);
            this.groupboxShutterCtrl.Controls.Add(this.lbl1);
            this.groupboxShutterCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxShutterCtrl.Location = new System.Drawing.Point(12, 304);
            this.groupboxShutterCtrl.Name = "groupboxShutterCtrl";
            this.groupboxShutterCtrl.Size = new System.Drawing.Size(292, 131);
            this.groupboxShutterCtrl.TabIndex = 28;
            this.groupboxShutterCtrl.TabStop = false;
            this.groupboxShutterCtrl.Text = "Calibration Beam";
            // 
            // lblOffTime
            // 
            this.lblOffTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOffTime.AutoSize = true;
            this.lblOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOffTime.Location = new System.Drawing.Point(6, 66);
            this.lblOffTime.Name = "lblOffTime";
            this.lblOffTime.Size = new System.Drawing.Size(105, 20);
            this.lblOffTime.TabIndex = 23;
            this.lblOffTime.Text = "Time OFF (s):";
            // 
            // spbOffTime
            // 
            this.spbOffTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spbOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbOffTime.Location = new System.Drawing.Point(170, 63);
            this.spbOffTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spbOffTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spbOffTime.Name = "spbOffTime";
            this.spbOffTime.Size = new System.Drawing.Size(89, 26);
            this.spbOffTime.TabIndex = 24;
            this.spbOffTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(322, 447);
            this.Controls.Add(this.groupboxComms);
            this.Controls.Add(this.groupboxConfig);
            this.Controls.Add(this.groupboxShutterCtrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Beam Calibration Motor Control";
            ((System.ComponentModel.ISupportInitialize)(this.spbRotationAngle)).EndInit();
            this.groupboxConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spbOnTime)).EndInit();
            this.groupboxComms.ResumeLayout(false);
            this.groupboxComms.PerformLayout();
            this.groupboxShutterCtrl.ResumeLayout(false);
            this.groupboxShutterCtrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbOffTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMotorControl;
        private System.Windows.Forms.NumericUpDown spbRotationAngle;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.GroupBox groupboxConfig;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label labelComPortStatus;
        private System.Windows.Forms.Button btnOpenClosePort;
        private System.Windows.Forms.Label labelShutterStatus;
        private System.Windows.Forms.Button btnStartStopControl;
        private System.Windows.Forms.Label lblOnTime;
        private System.Windows.Forms.NumericUpDown spbOnTime;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupboxComms;
        private System.Windows.Forms.GroupBox groupboxShutterCtrl;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Button btnStopMotor;
        private System.Windows.Forms.Button btnSetZeroPos;
        private System.Windows.Forms.Label lblOffTime;
        private System.Windows.Forms.NumericUpDown spbOffTime;
    }
}

