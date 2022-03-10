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
            this.lblShutterOpenPos = new System.Windows.Forms.Label();
            this.lblShutterClosedPos = new System.Windows.Forms.Label();
            this.lblOnOffTime = new System.Windows.Forms.Label();
            this.spinboxShutterOpenPos = new System.Windows.Forms.NumericUpDown();
            this.spinboxShutterClosedPos = new System.Windows.Forms.NumericUpDown();
            this.spinboxOnOffTime = new System.Windows.Forms.NumericUpDown();
            this.btnSetShutterOpenPos = new System.Windows.Forms.Button();
            this.btnSetShutterClosedPos = new System.Windows.Forms.Button();
            this.btnStartStopControl = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerShutterControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spinboxShutterOpenPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxShutterClosedPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxOnOffTime)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShutterOpenPos
            // 
            this.lblShutterOpenPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShutterOpenPos.AutoSize = true;
            this.lblShutterOpenPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShutterOpenPos.Location = new System.Drawing.Point(3, 34);
            this.lblShutterOpenPos.Name = "lblShutterOpenPos";
            this.lblShutterOpenPos.Size = new System.Drawing.Size(140, 20);
            this.lblShutterOpenPos.TabIndex = 0;
            this.lblShutterOpenPos.Text = "Shutter Open Pos:";
            // 
            // lblShutterClosedPos
            // 
            this.lblShutterClosedPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShutterClosedPos.AutoSize = true;
            this.lblShutterClosedPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblShutterClosedPos.Location = new System.Drawing.Point(3, 123);
            this.lblShutterClosedPos.Name = "lblShutterClosedPos";
            this.lblShutterClosedPos.Size = new System.Drawing.Size(150, 20);
            this.lblShutterClosedPos.TabIndex = 0;
            this.lblShutterClosedPos.Text = "Shutter Closed Pos:";
            // 
            // lblOnOffTime
            // 
            this.lblOnOffTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOnOffTime.AutoSize = true;
            this.lblOnOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOnOffTime.Location = new System.Drawing.Point(3, 213);
            this.lblOnOffTime.Name = "lblOnOffTime";
            this.lblOnOffTime.Size = new System.Drawing.Size(98, 20);
            this.lblOnOffTime.TabIndex = 1;
            this.lblOnOffTime.Text = "Time On/Off:";
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
            this.spinboxShutterOpenPos.Location = new System.Drawing.Point(172, 31);
            this.spinboxShutterOpenPos.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.spinboxShutterOpenPos.Name = "spinboxShutterOpenPos";
            this.spinboxShutterOpenPos.Size = new System.Drawing.Size(120, 26);
            this.spinboxShutterOpenPos.TabIndex = 2;
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
            this.spinboxShutterClosedPos.Location = new System.Drawing.Point(172, 120);
            this.spinboxShutterClosedPos.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.spinboxShutterClosedPos.Name = "spinboxShutterClosedPos";
            this.spinboxShutterClosedPos.Size = new System.Drawing.Size(120, 26);
            this.spinboxShutterClosedPos.TabIndex = 2;
            // 
            // spinboxOnOffTime
            // 
            this.spinboxOnOffTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spinboxOnOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinboxOnOffTime.Location = new System.Drawing.Point(172, 210);
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
            this.spinboxOnOffTime.Size = new System.Drawing.Size(120, 26);
            this.spinboxOnOffTime.TabIndex = 3;
            this.spinboxOnOffTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSetShutterOpenPos
            // 
            this.btnSetShutterOpenPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetShutterOpenPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetShutterOpenPos.Location = new System.Drawing.Point(341, 29);
            this.btnSetShutterOpenPos.Name = "btnSetShutterOpenPos";
            this.btnSetShutterOpenPos.Size = new System.Drawing.Size(165, 31);
            this.btnSetShutterOpenPos.TabIndex = 4;
            this.btnSetShutterOpenPos.Text = "Set";
            this.btnSetShutterOpenPos.UseVisualStyleBackColor = true;
            this.btnSetShutterOpenPos.Click += new System.EventHandler(this.btnSetShutterOpenPos_Click);
            // 
            // btnSetShutterClosedPos
            // 
            this.btnSetShutterClosedPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetShutterClosedPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetShutterClosedPos.Location = new System.Drawing.Point(341, 118);
            this.btnSetShutterClosedPos.Name = "btnSetShutterClosedPos";
            this.btnSetShutterClosedPos.Size = new System.Drawing.Size(165, 31);
            this.btnSetShutterClosedPos.TabIndex = 4;
            this.btnSetShutterClosedPos.Text = "Set";
            this.btnSetShutterClosedPos.UseVisualStyleBackColor = true;
            this.btnSetShutterClosedPos.Click += new System.EventHandler(this.btnSetShutterClosedPos_Click);
            // 
            // btnStartStopControl
            // 
            this.btnStartStopControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStartStopControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStopControl.Location = new System.Drawing.Point(341, 208);
            this.btnStartStopControl.Name = "btnStartStopControl";
            this.btnStartStopControl.Size = new System.Drawing.Size(165, 30);
            this.btnStartStopControl.TabIndex = 4;
            this.btnStartStopControl.Text = "Start";
            this.btnStartStopControl.UseVisualStyleBackColor = true;
            this.btnStartStopControl.Click += new System.EventHandler(this.btnStartStopControl_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblShutterClosedPos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStartStopControl, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOnOffTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSetShutterClosedPos, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.spinboxShutterOpenPos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSetShutterOpenPos, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.spinboxShutterClosedPos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.spinboxOnOffTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblShutterOpenPos, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 268);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // timerShutterControl
            // 
            this.timerShutterControl.Interval = 1000;
            this.timerShutterControl.Tick += new System.EventHandler(this.timerShutterControl_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Shutter Motor Control";
            ((System.ComponentModel.ISupportInitialize)(this.spinboxShutterOpenPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxShutterClosedPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinboxOnOffTime)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShutterOpenPos;
        private System.Windows.Forms.Label lblShutterClosedPos;
        private System.Windows.Forms.Label lblOnOffTime;
        private System.Windows.Forms.NumericUpDown spinboxShutterOpenPos;
        private System.Windows.Forms.NumericUpDown spinboxShutterClosedPos;
        private System.Windows.Forms.NumericUpDown spinboxOnOffTime;
        private System.Windows.Forms.Button btnSetShutterOpenPos;
        private System.Windows.Forms.Button btnSetShutterClosedPos;
        private System.Windows.Forms.Button btnStartStopControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timerShutterControl;
    }
}

