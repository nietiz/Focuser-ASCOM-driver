using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ASCOM.GenericStepper
{
    public partial class Form1 : Form
    {

        private ASCOM.DriverAccess.Focuser driver;

        public Form1()
        {
            InitializeComponent();
            SetUIState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
                driver.Connected = false;

            Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DriverId = ASCOM.DriverAccess.Focuser.Choose(Properties.Settings.Default.DriverId);
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                timer1.Enabled = false;
                driver.Connected = false;
            }
            else
            {
                string focuserID = Properties.Settings.Default.DriverId;
                driver = new ASCOM.DriverAccess.Focuser(focuserID);
                driver.Connected = true;
                timer1.Enabled = true;
                string s = driver.CommandString("MICROSTEPS_GET\n", true);
                Debug.WriteLine(s);
                //int microSteps;
                //int.TryParse(s, microSteps);
                comboBox1.Text = s;

                //StartFocuserApp();
            }
            SetUIState();
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
        }

        private bool IsConnected
        {
            get
            {
                return ((this.driver != null) && (driver.Connected == true));
            }
        }

        private void StartFocuserApp()
        {
            try
            {


                Process process = Process.Start(@"G:\development\ASTRONOMIA - PROGETTAZIONE\micro focuser for BP steeltrack\GenericStepperFocuser\GenericStepperFocuser\bin\Debug\GenericStepperFocuser.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot start focuser: " + ex.Message);
            }

        }

        private void buttonMoveTo_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                driver.CommandString("SPEED0\n", true);
                driver.Move((int)numericUpDownPosition.Value);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                labelPosition.Text = driver.Position.ToString();
            }
        }

        private void buttonIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsConnected)
            {
                string s = driver.CommandString("SPEED0\n", true);
                Debug.WriteLine(s);
                driver.Move(0);
            }
        }

        private void buttonIn_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsConnected)
                driver.Halt();

        }

        private void buttonOut_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsConnected)
            {
                string s = driver.CommandString("SPEED0\n", true);
                Debug.WriteLine(s);
                driver.Move(driver.MaxStep);
            }
        }

        private void buttonOut_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsConnected)
                driver.Halt();
        }
       private void buttonInSlow_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsConnected)
            {
                string s = driver.CommandString("SPEED2\n", true);
                Debug.WriteLine(s);
                driver.Move(0);
            }
        }

        private void buttonInSlow_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsConnected)
                driver.Halt();
        }

        private void buttonOutSlow_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsConnected)
            {
                string s = driver.CommandString("SPEED2\n", true);
                Debug.WriteLine(s);
                driver.Move(driver.MaxStep);
            }
        }

        private void buttonOutSlow_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsConnected)
                driver.Halt();
        }


        private void buttonMicroSteps_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                string s = driver.CommandString("MICROSTEPS_SET" + comboBox1.Text + "\n", true);
                Debug.WriteLine(s);
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                driver.CommandString("ZERO\n", true);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (IsConnected)
                driver.Halt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGoToZero_Click(object sender, EventArgs e)
        {

        }

     }
}
