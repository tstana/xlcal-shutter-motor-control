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

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

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
            /* Handle open port and exit from function */
            if (port.IsOpen)
            {
                port.Close();
                labelComPortStatus.Text = "NoConn";
                labelComPortStatus.BackColor = Color.Red;
                btnOpenClosePort.Text = "Open";
                return;
            }

            try
            {
                port.PortName = cbComPort.Text;
                port.Open();
                labelComPortStatus.Text = "9600 baud";
                labelComPortStatus.BackColor = Color.DarkGreen;
                btnOpenClosePort.Text = "Close";
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

        private void btnSetShutterOpenPos_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("Please connect to motor driver board first!",
                    "Serial port not open",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            port.Write("/1A" + spinboxShutterOpenPos.Value.ToString() + "R\r");
        }

        private void btnSetShutterClosedPos_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("Please connect to motor driver board first!",
                    "Serial port not open",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            port.Write("/1A" + spinboxShutterClosedPos.Value.ToString() + "R\r");
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
                timerShutterControl.Interval = (int)spinboxOnOffTime.Value * 60000;
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
                btnSetShutterClosedPos_Click(sender, e);
                shutterOpen = false;
                labelShutterStatus.Text = "OFF";
                labelShutterStatus.BackColor = Color.Red;
            }
            else
            {
                btnSetShutterOpenPos_Click(sender, e);
                shutterOpen = true;
                labelShutterStatus.Text = "ON";
                labelShutterStatus.BackColor = Color.DarkGreen;
            }
        }
    }
}
