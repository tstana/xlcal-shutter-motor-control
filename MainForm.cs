using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace xlcal_shutter_motor_control
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSetShutterOpenPos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Position: " + Environment.NewLine + Environment.NewLine +
                "/1A" + spinboxShutterOpenPos.Value.ToString() + "R\r");
        }

        private void btnSetShutterClosedPos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closed Position: " + Environment.NewLine + Environment.NewLine +
                "/1A" + spinboxShutterClosedPos.Value.ToString() + "R\r");
        }

        private void btnStartStopControl_Click(object sender, EventArgs e)
        {
            if (btnStartStopControl.Text.Equals("Start"))
            {
                MessageBox.Show("Starting motor control for " +
                    spinboxOnOffTime.Value.ToString() + 
                    ((spinboxOnOffTime.Value > 1) ? " minutes" : " minute") + ".");
                btnStartStopControl.Text = "Stop";
            }
            else if (btnStartStopControl.Text.Equals("Stop")) {
                MessageBox.Show("Stopping motor control.");
                btnStartStopControl.Text = "Start";
            }
        }
    }
}
