using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;


namespace xlcal_shutter_motor_control
{
    public partial class MainForm : Form
    {
        private const decimal NumMicrostepsPerStep = 256;
        private const decimal NumMotorStepsPerRevolution =
            400 * NumMicrostepsPerStep;
        private const decimal NumEncoderPulsesPerRevolution = 1600;

        private SerialPort port;
        private bool motorZeroPosFound = false;
        private bool beamOn = false;
        private decimal beamOffTime = 0;
        private decimal beamOnTime = 0;
        private decimal seconds = 0;
 
        public MainForm()
        {
            InitializeComponent();

            port = new SerialPort();
            port.BaudRate = 9600;

            tooltip.SetToolTip(btnOpenClosePort, "Open COM port connection @" +
                " 9600 baud.");
            tooltip.SetToolTip(cbComPort, "Select COM port.");
            tooltip.SetToolTip(spbRotationAngle, "Rotation angle in degrees.");
            tooltip.SetToolTip(btnRotateCCW, "Rotate counter-clockwise.");
            tooltip.SetToolTip(btnRotateCW, "Rotate clockwise.");
            tooltip.SetToolTip(btnStopMotor, "Stop motor rotation.");
            tooltip.SetToolTip(btnSetZeroPos, "Horizontal position found: " +
                " set as motor's zero position.");

            // Upon power-up, the motor will think it's at zero position, even
            // though it likely won't be. Due to the "features" of the
            // EZStepper motor driver, we can only make positive (clockwise
            // with our setup) movements. Thus, the CCW button needs to be
            // disabled until a positive movement has been made.
            btnRotateCCW.Enabled = false;
        }

        private void cbComPort_Click(object sender, EventArgs e)
        {
            cbComPort.Items.Clear();

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
                cbComPort.Items.Add(port);

            if (cbComPort.Items.Count > 0)
                cbComPort.SelectedIndex = 0;
        }

        private void btnOpenClosePort_Click(object sender, EventArgs e)
        {
            // Exit early from function if port is open
            if (port.IsOpen)
            {
                if (timerMotorControl.Enabled)
                {
                    MessageBox.Show("Please stop motor control before " +
                        "closing serial port!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                port.Close();
                labelComPortStatus.Text = "Not connected";
                labelComPortStatus.BackColor = Color.Red;
                btnOpenClosePort.Text = "Open";
                tooltip.SetToolTip(btnOpenClosePort, "Open COM port " +
                    "connection @ 9600 baud.");
                return;
            }

            // Try to open port if not already open
            try
            {
                port.PortName = cbComPort.Text;
                port.Open();
                labelComPortStatus.Text = "9600 baud";
                labelComPortStatus.BackColor = Color.DarkGreen;
                btnOpenClosePort.Text = "Close";
                tooltip.SetToolTip(btnOpenClosePort, "Close COM port " +
                    "connection.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unable to open port! " +
                    "Could it already be open in another app?",
                    "Unauthorized Access Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message,
                    "Unexpected Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Send some commands to ensure the motor works:
            // - Set number of microsteps per step ("/1j...")
            // - Set velocity in microsteps per sec. ("/1V...")
            // - Set the encoder conversion ratio ("/1aE...")
            port.Write("/1j" + NumMicrostepsPerStep.ToString() + "R\r");
            Thread.Sleep(500);
            port.Write("/1V" + "4000" + "R\r");
            Thread.Sleep(500);
            port.Write("/1aE" +
                ((NumMotorStepsPerRevolution / NumEncoderPulsesPerRevolution) * 1000).ToString() +
                "R\r");
            Thread.Sleep(500);
        }

        private uint ToEncoderPos(decimal angle)
        {
            return (uint)(NumEncoderPulsesPerRevolution * angle / 360);
        }

        private void btnRotateCW_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("Please connect to motor driver board first!",
                    "Serial port not open",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            port.Write("/1P" + ToEncoderPos(spbRotationAngle.Value).ToString()
                + "R\r");

            if (!btnRotateCCW.Enabled)
                btnRotateCCW.Enabled = true;
        }

        private void btnRotateCCW_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("Please connect to motor driver board first!",
                    "Serial port not open",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            port.Write("/1D" + ToEncoderPos(spbRotationAngle.Value).ToString()
                + "R\r");
        }

        private void btnStopMotor_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("Please connect to motor driver board first!",
                    "Serial port not open",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            port.Write("/1TR\r");
        }

        private void btnSetZeroPos_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("Please connect to motor driver board first!",
                    "Serial port not open",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            port.Write("/1z0R\r");

            motorZeroPosFound = true;
        }

        private void btnStartStopControl_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("Please connect to motor driver board first!",
                    "Serial port not open",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!motorZeroPosFound)
            {
                MessageBox.Show("You haven't found the motor's zero " +
                    "position yet. Please bring the beam cover vertical " +
                    "using the controls above and click the \"Set zero " +
                    "position (vertical)\" button.",
                    "Zero position not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!timerMotorControl.Enabled)
            {
                btnStartStopControl.Text = "Stop";
                beamOffTime = spbOffTimeMins.Value * 60 + spbOffTimeSec.Value;
                seconds = 0;
                timerMotorControl.Enabled = true;
            }
            else
            {
                btnStartStopControl.Text = "Start";
                timerMotorControl.Enabled = false;
                pbarTimeElapsed.Value = 0;
            }
        }

        private void timerShutterControl_Tick(object sender, EventArgs e)
        {
            ++seconds;

            if (!beamOn)
            {
                pbarTimeElapsed.Value =
                    (int)(100 * ((double)seconds / (double)beamOffTime));

                if (seconds == beamOffTime)
                {
                    port.Write("/1P" + ToEncoderPos(90).ToString() + "R\r");
                    beamOn = true;
                    labelShutterStatus.Text = "ON";
                    labelShutterStatus.BackColor = Color.DarkGreen;
                    beamOnTime = spbOnTimeMins.Value * 60 + spbOnTimeSec.Value;
                    seconds = 0;
                }
            }
            else
            {
                pbarTimeElapsed.Value =
                    (int)(100 * ((double)seconds / (double)beamOnTime));

                if (seconds == beamOnTime)
                {
                    port.Write("/1D" + ToEncoderPos(90).ToString() + "R\r");
                    beamOn = false;
                    labelShutterStatus.Text = "OFF";
                    labelShutterStatus.BackColor = Color.Red;
                    beamOffTime = spbOffTimeMins.Value * 60 + spbOffTimeSec.Value;
                    seconds = 0;
                }
            }
        }

        private void spbOffTimeSec_ValueChanged(object sender, EventArgs e)
        {
            if ((spbOffTimeMins.Value == 0) && (spbOffTimeSec.Value < 10))
            {
                MessageBox.Show("Beam cover OFF time cannot be less than 10 s," +
                    " to account for the beam cover rotation time.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                spbOffTimeSec.Value = 10;
            }
        }

        private void spbOnTimeSec_ValueChanged(object sender, EventArgs e)
        {
            if ((spbOnTimeMins.Value == 0) && (spbOnTimeSec.Value < 10))
            {
                MessageBox.Show("Beam cover ON time cannot be less than 10 s," +
                    " to account for the beam cover rotation time.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                spbOnTimeSec.Value = 10;
            }
        }

        private void spbOffTimeMins_ValueChanged(object sender, EventArgs e)
        {
            if ((spbOffTimeSec.Value < 10) && (spbOffTimeMins.Value < 1))
            {
                MessageBox.Show("Beam cover OFF time cannot be less than 10 s," +
                    " to account for the beam cover rotation time.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                spbOffTimeMins.Value = 1;
            }
        }

        private void spbOnTimeMins_ValueChanged(object sender, EventArgs e)
        {
            if ((spbOnTimeSec.Value < 10) && (spbOnTimeMins.Value < 1))
            {
                MessageBox.Show("Beam cover ON time cannot be less than 10 s," +
                    " to account for the beam cover rotation time.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                spbOnTimeMins.Value = 1;
            }
        }
    }
}
