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
            this.timerShutterControl = new System.Windows.Forms.Timer(this.components);
            this.lblShutterClosedPos = new System.Windows.Forms.Label();
            this.btnSetShutterClosedPos = new System.Windows.Forms.Button();
            this.spinboxShutterOpenPos = new System.Windows.Forms.NumericUpDown();
            this.btnSetShutterOpenPos = new System.Windows.Forms.Button();
            this.spinboxShutterClosedPos = new System.Windows.Forms.NumericUpDown();
            this.lblShutterOpenPos = new System.Windows.Forms.Label();
            this.groupboxConfig = new System.Windows.Forms.GroupBox();
            this.checkboxShutterOpenPosFound = new System.Windows.Forms.CheckBox();
            this.checkboxShutterClosedPosFound = new System.Windows.Forms.CheckBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.labelComPortStatus = new System.Windows.Forms.Label();
            this.labelShutterStatus = new System.Windows.Forms.Label();
            this.btnOpenClosePort = new System.Windows.Forms.Button();
            this.btnStartStopControl = new System.Windows.Forms.Button();
            this.lblOnOffTime = new System.Windows.Forms.Label();
            this.spinboxOnOffTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxShutterOpenPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxShutterClosedPos)).BeginInit();
            this.groupboxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxOnOffTime)).BeginInit();
            this.SuspendLayout();
            // 
            // timerShutterControl
            // 
            this.timerShutterControl.Interval = 1000;
            this.timerShutterControl.Tick += new System.EventHandler(this.timerShutterControl_Tick);
            // 
            // lblShutterClosedPos
            // 
            this.lblShutterClosedPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShutterClosedPos.AutoSize = true;
            this.lblShutterClosedPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblShutterClosedPos.Location = new System.Drawing.Point(6, 87);
            this.lblShutterClosedPos.Name = "lblShutterClosedPos";
            this.lblShutterClosedPos.Size = new System.Drawing.Size(150, 20);
            this.lblShutterClosedPos.TabIndex = 5;
            this.lblShutterClosedPos.Text = "Shutter Closed Pos:";
            // 
            // btnSetShutterClosedPos
            // 
            this.btnSetShutterClosedPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetShutterClosedPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetShutterClosedPos.Location = new System.Drawing.Point(377, 82);
            this.btnSetShutterClosedPos.Name = "btnSetShutterClosedPos";
            this.btnSetShutterClosedPos.Size = new System.Drawing.Size(118, 31);
            this.btnSetShutterClosedPos.TabIndex = 12;
            this.btnSetShutterClosedPos.Text = "Set";
            this.btnSetShutterClosedPos.UseVisualStyleBackColor = true;
            this.btnSetShutterClosedPos.Click += new System.EventHandler(this.btnSetShutterClosedPos_Click);
            // 
            // spinboxShutterOpenPos
            // 
            this.spinboxShutterOpenPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spinboxShutterOpenPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinboxShutterOpenPos.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinboxShutterOpenPos.Location = new System.Drawing.Point(162, 38);
            this.spinboxShutterOpenPos.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.spinboxShutterOpenPos.Name = "spinboxShutterOpenPos";
            this.spinboxShutterOpenPos.Size = new System.Drawing.Size(120, 26);
            this.spinboxShutterOpenPos.TabIndex = 8;
            // 
            // btnSetShutterOpenPos
            // 
            this.btnSetShutterOpenPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetShutterOpenPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetShutterOpenPos.Location = new System.Drawing.Point(377, 36);
            this.btnSetShutterOpenPos.Name = "btnSetShutterOpenPos";
            this.btnSetShutterOpenPos.Size = new System.Drawing.Size(118, 31);
            this.btnSetShutterOpenPos.TabIndex = 13;
            this.btnSetShutterOpenPos.Text = "Set";
            this.btnSetShutterOpenPos.UseVisualStyleBackColor = true;
            this.btnSetShutterOpenPos.Click += new System.EventHandler(this.btnSetShutterOpenPos_Click);
            // 
            // spinboxShutterClosedPos
            // 
            this.spinboxShutterClosedPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spinboxShutterClosedPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinboxShutterClosedPos.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinboxShutterClosedPos.Location = new System.Drawing.Point(162, 85);
            this.spinboxShutterClosedPos.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.spinboxShutterClosedPos.Name = "spinboxShutterClosedPos";
            this.spinboxShutterClosedPos.Size = new System.Drawing.Size(120, 26);
            this.spinboxShutterClosedPos.TabIndex = 9;
            // 
            // lblShutterOpenPos
            // 
            this.lblShutterOpenPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShutterOpenPos.AutoSize = true;
            this.lblShutterOpenPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShutterOpenPos.Location = new System.Drawing.Point(6, 41);
            this.lblShutterOpenPos.Name = "lblShutterOpenPos";
            this.lblShutterOpenPos.Size = new System.Drawing.Size(140, 20);
            this.lblShutterOpenPos.TabIndex = 6;
            this.lblShutterOpenPos.Text = "Shutter Open Pos:";
            // 
            // groupboxConfig
            // 
            this.groupboxConfig.Controls.Add(this.checkboxShutterClosedPosFound);
            this.groupboxConfig.Controls.Add(this.checkboxShutterOpenPosFound);
            this.groupboxConfig.Controls.Add(this.lblShutterOpenPos);
            this.groupboxConfig.Controls.Add(this.lblShutterClosedPos);
            this.groupboxConfig.Controls.Add(this.spinboxShutterClosedPos);
            this.groupboxConfig.Controls.Add(this.btnSetShutterOpenPos);
            this.groupboxConfig.Controls.Add(this.btnSetShutterClosedPos);
            this.groupboxConfig.Controls.Add(this.spinboxShutterOpenPos);
            this.groupboxConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxConfig.Location = new System.Drawing.Point(13, 100);
            this.groupboxConfig.Name = "groupboxConfig";
            this.groupboxConfig.Size = new System.Drawing.Size(508, 134);
            this.groupboxConfig.TabIndex = 14;
            this.groupboxConfig.TabStop = false;
            this.groupboxConfig.Text = "Configure Motor Positions";
            // 
            // checkboxShutterOpenPosFound
            // 
            this.checkboxShutterOpenPosFound.AutoSize = true;
            this.checkboxShutterOpenPosFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxShutterOpenPosFound.Location = new System.Drawing.Point(288, 40);
            this.checkboxShutterOpenPosFound.Name = "checkboxShutterOpenPosFound";
            this.checkboxShutterOpenPosFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkboxShutterOpenPosFound.Size = new System.Drawing.Size(74, 24);
            this.checkboxShutterOpenPosFound.TabIndex = 14;
            this.checkboxShutterOpenPosFound.Text = "Found";
            this.checkboxShutterOpenPosFound.UseVisualStyleBackColor = true;
            // 
            // checkboxShutterClosedPosFound
            // 
            this.checkboxShutterClosedPosFound.AutoSize = true;
            this.checkboxShutterClosedPosFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxShutterClosedPosFound.Location = new System.Drawing.Point(288, 86);
            this.checkboxShutterClosedPosFound.Name = "checkboxShutterClosedPosFound";
            this.checkboxShutterClosedPosFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkboxShutterClosedPosFound.Size = new System.Drawing.Size(74, 24);
            this.checkboxShutterClosedPosFound.TabIndex = 14;
            this.checkboxShutterClosedPosFound.Text = "Found";
            this.checkboxShutterClosedPosFound.UseVisualStyleBackColor = true;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComPort.Location = new System.Drawing.Point(9, 17);
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
            this.cbComPort.Location = new System.Drawing.Point(111, 13);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(124, 28);
            this.cbComPort.TabIndex = 16;
            this.cbComPort.Click += new System.EventHandler(this.cbComPort_Click);
            // 
            // labelComPortStatus
            // 
            this.labelComPortStatus.AutoSize = true;
            this.labelComPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComPortStatus.Location = new System.Drawing.Point(241, 17);
            this.labelComPortStatus.Name = "labelComPortStatus";
            this.labelComPortStatus.Size = new System.Drawing.Size(151, 20);
            this.labelComPortStatus.TabIndex = 17;
            this.labelComPortStatus.Text = "labelComPortStatus";
            // 
            // labelShutterStatus
            // 
            this.labelShutterStatus.AutoSize = true;
            this.labelShutterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShutterStatus.Location = new System.Drawing.Point(241, 63);
            this.labelShutterStatus.Name = "labelShutterStatus";
            this.labelShutterStatus.Size = new System.Drawing.Size(142, 20);
            this.labelShutterStatus.TabIndex = 22;
            this.labelShutterStatus.Text = "labelShutterStatus";
            // 
            // btnOpenClosePort
            // 
            this.btnOpenClosePort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOpenClosePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenClosePort.Location = new System.Drawing.Point(403, 12);
            this.btnOpenClosePort.Name = "btnOpenClosePort";
            this.btnOpenClosePort.Size = new System.Drawing.Size(118, 30);
            this.btnOpenClosePort.TabIndex = 20;
            this.btnOpenClosePort.Text = "Open";
            this.btnOpenClosePort.UseVisualStyleBackColor = true;
            this.btnOpenClosePort.Click += new System.EventHandler(this.btnOpenClosePort_Click);
            // 
            // btnStartStopControl
            // 
            this.btnStartStopControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStartStopControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStopControl.Location = new System.Drawing.Point(403, 58);
            this.btnStartStopControl.Name = "btnStartStopControl";
            this.btnStartStopControl.Size = new System.Drawing.Size(118, 30);
            this.btnStartStopControl.TabIndex = 21;
            this.btnStartStopControl.Text = "Start";
            this.btnStartStopControl.UseVisualStyleBackColor = true;
            this.btnStartStopControl.Click += new System.EventHandler(this.btnStartStopControl_Click);
            // 
            // lblOnOffTime
            // 
            this.lblOnOffTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOnOffTime.AutoSize = true;
            this.lblOnOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOnOffTime.Location = new System.Drawing.Point(9, 63);
            this.lblOnOffTime.Name = "lblOnOffTime";
            this.lblOnOffTime.Size = new System.Drawing.Size(98, 20);
            this.lblOnOffTime.TabIndex = 18;
            this.lblOnOffTime.Text = "Time On/Off:";
            // 
            // spinboxOnOffTime
            // 
            this.spinboxOnOffTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spinboxOnOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinboxOnOffTime.Location = new System.Drawing.Point(111, 60);
            this.spinboxOnOffTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spinboxOnOffTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinboxOnOffTime.Name = "spinboxOnOffTime";
            this.spinboxOnOffTime.Size = new System.Drawing.Size(124, 26);
            this.spinboxOnOffTime.TabIndex = 19;
            this.spinboxOnOffTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(533, 246);
            this.Controls.Add(this.labelShutterStatus);
            this.Controls.Add(this.btnOpenClosePort);
            this.Controls.Add(this.btnStartStopControl);
            this.Controls.Add(this.lblOnOffTime);
            this.Controls.Add(this.spinboxOnOffTime);
            this.Controls.Add(this.labelComPortStatus);
            this.Controls.Add(this.cbComPort);
            this.Controls.Add(this.lblComPort);
            this.Controls.Add(this.groupboxConfig);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Shutter Motor Control";
            ((System.ComponentModel.ISupportInitialize)(this.spinboxShutterOpenPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxShutterClosedPos)).EndInit();
            this.groupboxConfig.ResumeLayout(false);
            this.groupboxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxOnOffTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerShutterControl;
        private System.Windows.Forms.Label lblShutterClosedPos;
        private System.Windows.Forms.Button btnSetShutterClosedPos;
        private System.Windows.Forms.NumericUpDown spinboxShutterOpenPos;
        private System.Windows.Forms.Button btnSetShutterOpenPos;
        private System.Windows.Forms.NumericUpDown spinboxShutterClosedPos;
        private System.Windows.Forms.Label lblShutterOpenPos;
        private System.Windows.Forms.GroupBox groupboxConfig;
        private System.Windows.Forms.CheckBox checkboxShutterClosedPosFound;
        private System.Windows.Forms.CheckBox checkboxShutterOpenPosFound;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label labelComPortStatus;
        private System.Windows.Forms.Label labelShutterStatus;
        private System.Windows.Forms.Button btnOpenClosePort;
        private System.Windows.Forms.Button btnStartStopControl;
        private System.Windows.Forms.Label lblOnOffTime;
        private System.Windows.Forms.NumericUpDown spinboxOnOffTime;
    }
}

