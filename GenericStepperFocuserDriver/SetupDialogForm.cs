// --------------------------------------------------------------------------------
//
// Author:		(NT) Tiziano Niero, tiziano.niero@gmail.com, www.tizianoniero.it
//
// This work is licensed under the Creative Commons Attribution-NonCommercial-ShareAlike 4.0 
// International License. 
// To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/4.0/ 
// or send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
//
// --------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ASCOM.Utilities;
using ASCOM.GenericStepper;

namespace ASCOM.GenericStepper
{
    [ComVisible(false)]					// Form not registered for COM!
    public partial class SetupDialogForm : Form
    {
        private readonly Focuser focuser;

        public SetupDialogForm(Focuser focuser)
        {
            InitializeComponent();

            this.focuser = focuser;

            // Initialise current values of user settings from the ASCOM Profile 
            Serial serial = new Serial();

            comboBoxComPort.Items.AddRange(serial.AvailableCOMPorts);

            // Initialise current values of user settings from the ASCOM Profile 

            // general settings
            comboBoxComPort.Text = Focuser.comPort;
            numericUpDownMaxStep.Value = Focuser.maxStep;
            numericUpDownFocuserCourse.Value = Focuser.course;
            CalcStepSize();

            // at connection
            radioButtonFindZero.Checked = Focuser.findZero;
            radioButtonForcelastPosition.Checked = !Focuser.findZero;
            checkBoxRestoreLastPosition.Checked = Focuser.restoreLastPosition;

            // motor settings
            comboBoxStepsRevolution.Text = Focuser.fullStepsRev.ToString();
            CalcDegreeStep();
            comboBoxMicrosteps.Text = Focuser.microStepsStep.ToString();
            numericUpDownSpeedFast.Value = Focuser.speedFastRps;
            numericUpDownSpeedSlow.Value = Focuser.speedSlowRps;

            // temperature
            checkBoxTemperatureCompensation.Checked = Focuser.temperatureCompensation;
            numericUpDownTemperatureMmCentigrade.Value = Focuser.temperatureCoefficient;

            // logging
            chkAlwaysOnTop.Checked = Focuser.alwaysOnTop;

        }




        private void cmdOK_Click(object sender, EventArgs e) // OK button event handler
        {
            // Place any validation constraint checks here

            Focuser.comPort = comboBoxComPort.Text; // Update the state variables with results from the dialogue
            Focuser.alwaysOnTop = chkAlwaysOnTop.Checked;
            Focuser.maxStep = (int)numericUpDownMaxStep.Value;
            Focuser.course = numericUpDownFocuserCourse.Value;
            Focuser.findZero = radioButtonFindZero.Checked;
            Focuser.restoreLastPosition = checkBoxRestoreLastPosition.Checked;
            Focuser.temperatureCompensation = checkBoxTemperatureCompensation.Checked;
            Focuser.temperatureCoefficient = numericUpDownTemperatureMmCentigrade.Value;
            int value;
            if (!int.TryParse(comboBoxStepsRevolution.Text, out value))
                value = 200;
            Focuser.fullStepsRev = value;
            if (!int.TryParse(comboBoxMicrosteps.Text, out value))
                value = 32;
            Focuser.speedFastRps = numericUpDownSpeedFast.Value;
            Focuser.speedSlowRps = numericUpDownSpeedSlow.Value;
        }

        private void cmdCancel_Click(object sender, EventArgs e) // Cancel button event handler
        {
            Close();
        }

        private void BrowseToAscom(object sender, EventArgs e) // Click on ASCOM logo event handler
        {
            try
            {
                System.Diagnostics.Process.Start("http://ascom-standards.org/");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }


        private void numericUpDownMaxStep_ValueChanged(object sender, EventArgs e)
        {
            CalcStepSize();
        }

        private void numericUpDownFocuserCourse_ValueChanged(object sender, EventArgs e)
        {
            CalcStepSize();
        }

        /// <summary>
        /// calculate the step size in µm and show it
        /// </summary>
        private void CalcStepSize()
        {

            decimal stepSize = numericUpDownFocuserCourse.Value * 1000 / numericUpDownMaxStep.Value;
            labelStepSize.Text = stepSize.ToString("F3");

        }

        private void CalcDegreeStep()
        {
            decimal steps;
            if (!decimal.TryParse(comboBoxStepsRevolution.Text, out steps))
                steps = 200;
            decimal stepAngle = 360m / steps;
            labelStepAngle.Text = stepAngle.ToString() + "°";
        }

        private void radioButtonFindZero_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxRestoreLastPosition.Enabled = radioButtonFindZero.Checked;
        }

        private void checkBoxTemperatureCompensation_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownTemperatureMmCentigrade.Enabled = checkBoxTemperatureCompensation.Checked;
            labelTempCoeffStepsCentigrade.Enabled = checkBoxTemperatureCompensation.Checked;
            labelT1.Enabled = checkBoxTemperatureCompensation.Checked;
            labelT2.Enabled = checkBoxTemperatureCompensation.Checked;
        }

        private void comboBoxStepsRevolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcDegreeStep();
        }
 

    }
}