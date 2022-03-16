using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace xlcal_shutter_motor_control
{
    public partial class MainForm : Form
    {
        private SerialPort port;
        private bool shutterOpen = false;

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
            /* Exit early from function if port is open: */
            if (port.IsOpen)
            {
                if (timerShutterControl.Enabled)
                {
                    MessageBox.Show("Please stop shutter control before " +
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

            /* Try to open port if not already open: */
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
        }

        private void btnRotateCW_Click(object sender, EventArgs e)
        {

        }

        private void btnRotateCCW_Click(object sender, EventArgs e)
        {

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

            port.Write("/1TR");
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

            port.Write("/1z0R");
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

            if (!timerShutterControl.Enabled)
            {
                btnStartStopControl.Text = "Stop";
                timerShutterControl.Interval = (int)spbOnOffTime.Value * 60000;
                timerShutterControl.Enabled = true;
            }
            else
            {
                btnStartStopControl.Text = "Start";
                timerShutterControl.Enabled = false;
            }
        }

        private void timerShutterControl_Tick(object sender, EventArgs e)
        {
            if (shutterOpen)
            {
                shutterOpen = false;
                labelShutterStatus.Text = "OFF";
                labelShutterStatus.BackColor = Color.Red;
            }
            else
            {
                shutterOpen = true;
                labelShutterStatus.Text = "ON";
                labelShutterStatus.BackColor = Color.DarkGreen;
            }
        }
    }
}
