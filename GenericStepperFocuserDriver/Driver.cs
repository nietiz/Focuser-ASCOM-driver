//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Focuser driver for ABSOLUTE focuser  with generic stepper motor.
//
// Description:	started with a project which used an Arduino Micro and a unipolar/bipolar 
//              stepper motor driver (based on TI DRV8825) to control a focuser.
//              
// Implements:	ASCOM Focuser interface version: 1.0.0
// Author:		(NT) Tiziano Niero, tiziano.niero@gmail.com, www.tizianoniero.it
//
// This work is licensed under the Creative Commons Attribution-NonCommercial-ShareAlike 4.0 
// International License. 
// To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/4.0/ 
// or send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
//
// Edit Log:
//
// Date			Who	Vers	Description
// -----------	---	-----	-------------------------------------------------------
// 26-aug-2014	NT	6.0.0	Initial edit, created from ASCOM driver template
// --------------------------------------------------------------------------------
//


// This is used to define code in the template that is specific to one class implementation
// unused code canbe deleted and this definition removed.
#define Focuser

#define USE_ASCOM_SERIAL

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;

using ASCOM;
using ASCOM.Astrometry;
using ASCOM.Astrometry.AstroUtils;
using ASCOM.Utilities;
using ASCOM.DeviceInterface;
using System.Globalization;
using System.Collections;
using System.Windows.Forms;

namespace ASCOM.GenericStepper
{
    //
    // Your driver's DeviceID is ASCOM.GenericStepper.Focuser
    //
    // The Guid attribute sets the CLSID for ASCOM.GenericStepper.Focuser
    // The ClassInterface/None addribute prevents an empty interface called
    // _GenericStepper from being created and used as the [default] interface
    //
    // TODO Replace the not implemented exceptions with code to implement the function or
    // throw the appropriate ASCOM exception.
    //

    /// <summary>
    /// ASCOM Focuser Driver for GenericStepper.
    /// </summary>
    [Guid("4e025b46-82e3-42ce-831b-1cbd35f642cb")]
    [ClassInterface(ClassInterfaceType.None)]
    public class Focuser : IFocuserV2
    {
        /// <summary>
        /// ASCOM DeviceID (COM ProgID) for this driver.
        /// The DeviceID is used by ASCOM applications to load the driver at runtime.
        /// </summary>
        internal static string driverID = "ASCOM.GenericStepper.Focuser";

        /// <summary>
        /// Driver description that displays in the ASCOM Chooser.
        /// </summary>
        private static string driverDescription = "ASCOM Driver for GSFocuser";

        // --- Constants used for Profile persistence ---
        internal static string comPortProfileName = "COM Port";
        internal static string comPortDefault = "COM1";
        internal static string alwaysOnTopProfileName = "Always on top";
        internal static string alwaysOnTopDefault = "false";
        internal static string maxStepsProfileName = "Max Steps";
        internal static string maxStepsDefault = "8000";
        internal static string courseProfileName = "Course";
        internal static string courseDefault = "30"; // mm
        internal static string findZeroProfileName = "Find zero at connection";
        internal static string findZeroDefault = "true";
        internal static string restorePositionProfileName = "Restore last position";
        internal static string restorePositionDefault = "true";
        internal static string tempCompensationProfileName = "Temperature compensation";
        internal static string tempCompensationDefault = "true";
        internal static string tempCoefficientProfileName = "Temperature coefficient";
        internal static string tempCoefficientDefault = "0.0";
        internal static string fullStepsRevProfileName = "Fullsteps-revolution";
        internal static string fullStepsRevDefault = "200";
        internal static string microStepsStepProfileName = "Microsteps-step";
        internal static string microStepsStepDefault = "32";
        internal static string speedFastRpsProfileName = "Speed Fast RPS";
        internal static string speedFastRpsDefault = "5.0";
        internal static string speedSlowRpsProfileName = "Speed Slow RPS";
        internal static string speedSlowRpsDefault = "0.3";


        // --- Variables to hold the current device configuration ---

        // standard driver
        internal static string comPort;
        internal static bool alwaysOnTop;
        internal static int maxStep;
        internal static decimal course; // mm

        // ---  custom specific ---
        // behaviour at connection
        internal static bool findZero;
        internal static bool restoreLastPosition;
        // temperature management
        internal static bool temperatureCompensation;
        internal static decimal temperatureCoefficient; // mm/°C
        // motor settings
        internal static int fullStepsRev;
        internal static int microStepsStep;
        internal static decimal speedFastRps;
        internal static decimal speedSlowRps;

        /// <summary>
        /// Private variable to hold an ASCOM Utilities object
        /// </summary>
        private Util utilities;


        /// <summary>
        /// Private variable to hold the trace logger object (creates a diagnostic log file with information that you specify)
        /// </summary>
        private TraceLogger tl;

        /// <summary>
        /// Private variable to hold the serial port
        /// </summary>
#if USE_ASCOM_SERIAL
        private ASCOM.Utilities.Serial serialPort = null;
#else
        private System.IO.Ports.SerialPort serialPort = null;
#endif

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericStepper"/> class.
        /// Must be public for COM registration.
        /// </summary>
        public Focuser()
        {
            ReadProfile(); // Read device configuration from the ASCOM Profile store

            tl = new TraceLogger("", "GSFocuser");
            tl.Enabled = alwaysOnTop;
            tl.LogMessage("Focuser", "Starting initialisation");

            //connectedState = false; // Initialise connected to false
            utilities = new Util(); //Initialise util object

            //TODO: Implement your additional construction here
            tl.LogMessage("Focuser", "Completed initialisation");
        }


        //
        // PUBLIC COM INTERFACE IFocuserV2 IMPLEMENTATION
        //

        #region Common properties and methods.

        /// <summary>
        /// Displays the Setup Dialog form.
        /// If the user clicks the OK button to dismiss the form, then
        /// the new settings are saved, otherwise the old values are reloaded.
        /// THIS IS THE ONLY PLACE WHERE SHOWING USER INTERFACE IS ALLOWED!
        /// </summary>
        public void SetupDialog()
        {
            // consider only showing the setup dialog if not connected
            // or call a different dialog if connected
            if (IsConnected)
                MessageBox.Show("Focuser is already connected; if you make some changes you must disconnect and connect again to apply them.");

            using (SetupDialogForm setupForm = new SetupDialogForm(this))
            {
                var result = setupForm.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    WriteProfile(); // Persist device configuration values to the ASCOM Profile store
                }
            }
        }

        public ArrayList SupportedActions
        {
            get
            {
                tl.LogMessage("SupportedActions Get", "Returning empty arraylist");
                return new ArrayList();
            }
        }

        public string Action(string actionName, string actionParameters)
        {
            throw new ASCOM.ActionNotImplementedException("Action " + actionName + " is not implemented by this driver");
        }

        public void CommandBlind(string command, bool raw)
        {
            CheckConnected("CommandBlind");
            // Call CommandString and return as soon as it finishes
            this.CommandString(command, raw);
        }

        public bool CommandBool(string command, bool raw)
        {
            CheckConnected("CommandBool");
            string ret = CommandString(command, raw);
            // TODO decode the return string and return true or false
            // or
            throw new ASCOM.MethodNotImplementedException("CommandBool");
        }

        public string CommandString(string command, bool raw)
        {
            CheckConnected("CommandString");
            // it's a good idea to put all the low level communication with the device here,
            // then all communication calls this function
            // you need something to ensure that only one command is in progress at a time
#if USE_ASCOM_SERIAL
            serialPort.Transmit(command);
            string response = serialPort.ReceiveTerminated("\n");
            response = response.TrimEnd('\n');
            return response;
#else
            tl.LogMessage("COMMAND", command);
            serialPort.Write(command);
            string response = serialPort.ReadTo("\n");
            response = response.TrimEnd('\n');
            tl.LogMessage("RESPONSE", response);
            return response;
#endif
        }

        public void Dispose()
        {
            // Clean up the tracelogger and util objects
            tl.Enabled = false;
            tl.Dispose();
            tl = null;
            utilities.Dispose();
            utilities = null;
        }

        public bool Connected
        {
            get
            {
                tl.LogMessage("Connected Get", IsConnected.ToString());
                return IsConnected;
            }
            set
            {
                tl.LogMessage("Connected Set", value.ToString());
                if (value == IsConnected)
                    return;

                if (value)
                {
                    tl.LogMessage("Connected Set", "Connecting to port " + comPort);
                    // open the serial com port
#if USE_ASCOM_SERIAL
                    serialPort = new Serial();
                    serialPort.DataBits = 8;
                    serialPort.Parity = SerialParity.None;
                    serialPort.Speed = SerialSpeed.ps9600;
                    serialPort.StopBits = SerialStopBits.One;
                    serialPort.DTREnable = true;
                    serialPort.RTSEnable = true;
                    //serialPort.ReceiveTimeoutMs = 2000;
                    serialPort.PortName = comPort;
                    serialPort.Connected = true;
#else
                    serialPort = new System.IO.Ports.SerialPort();
                    serialPort.DataBits = 8;
                    serialPort.Parity = System.IO.Ports.Parity.None;
                    serialPort.BaudRate = 115200;
                    serialPort.StopBits = System.IO.Ports.StopBits.One;
                    serialPort.ReadTimeout = 2000;
                    serialPort.PortName = comPort;
                    serialPort.Open();
#endif

                    // check if connected to the right device

                    string focuserName;
                    try
                    {
                        focuserName = Name;
                    }
                    catch (Exception)
                    {
                        tl.LogMessage("Connected Set", "Focuser device is not responding on " + comPort);
#if USE_ASCOM_SERIAL
                        serialPort.Connected = false;
#else
                        serialPort.Close();
#endif
                        serialPort.Dispose();
                        serialPort = null;
                        throw new ASCOM.NotConnectedException("Focuser device is not responding on " + comPort);
                    }
                    if (focuserName != "GenericStepperFocuser")
                    {
                        tl.LogMessage("Connected Set", string.Format("Unknown device: {0}", focuserName));
#if USE_ASCOM_SERIAL
                        serialPort.Connected = false;
#else
                        serialPort.Close();
#endif
                        serialPort.Dispose();
                        serialPort = null;
                        throw new ASCOM.NotConnectedException(string.Format("Unknown device: {0}", focuserName));
                    }
                }
                else
                {
                    try
                    {
                        tl.LogMessage("Connected Set", "Disconnecting from port " + comPort);
                        // TODO disconnect from the device
#if USE_ASCOM_SERIAL
                    serialPort.Connected = false;
#else
                        serialPort.Close();
#endif

                    }
                    finally
                    {
                        serialPort.Dispose();
                        serialPort = null;
                    }
                }
            }
        }

        public string Description
        {
            // TODO customise this device description
            get
            {
                tl.LogMessage("Description Get", driverDescription);
                return driverDescription;
            }
        }

        public string DriverInfo
        {
            get
            {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                // TODO customise this driver description
                string driverInfo = "Driver for absolute focuser which uses a stepper motor. Version: " + String.Format(CultureInfo.InvariantCulture, "{0}.{1}", version.Major, version.Minor);
                tl.LogMessage("DriverInfo Get", driverInfo);
                return driverInfo;
            }
        }

        public string DriverVersion
        {
            get
            {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                string driverVersion = String.Format(CultureInfo.InvariantCulture, "{0}.{1}", version.Major, version.Minor);
                tl.LogMessage("DriverVersion Get", driverVersion);
                return driverVersion;
            }
        }

        public short InterfaceVersion
        {
            // set by the driver wizard
            get
            {
                tl.LogMessage("InterfaceVersion Get", "2");
                return Convert.ToInt16("2");
            }
        }

        public string Name
        {
            get
            {
                return CommandString("N\n", true); ;
            }
        }

        #endregion

        #region IFocuser Implementation

        //private int focuserPosition = 0; // Class level variable to hold the current focuser position
        //private const int focuserSteps = 100000;




        public bool Absolute
        {
            get
            {
                tl.LogMessage("Absolute Get", true.ToString());
                return true; // This is an absolute focuser
            }
        }

        public void Halt()
        {
            tl.LogMessage("Halt", true.ToString());
            CommandBlind("H\n", true);
        }

        public bool IsMoving
        {
            get
            {
                string response = CommandString("m\n", true);
                bool value = response == "1";
                tl.LogMessage("IsMoving Get", value.ToString());
                return value;
            }
        }

        public bool Link
        {
            get
            {
                tl.LogMessage("Link Get", this.Connected.ToString());
                return this.Connected; // Direct function to the connected method, the Link method is just here for backwards compatibility
            }
            set
            {
                tl.LogMessage("Link Set", value.ToString());
                this.Connected = value; // Direct function to the connected method, the Link method is just here for backwards compatibility
            }
        }

        public int MaxIncrement
        {
            get
            {
                tl.LogMessage("MaxIncrement Get", maxStep.ToString());
                return maxStep; // Maximum change in one move
            }
        }

        public int MaxStep
        {
            get
            {
                tl.LogMessage("MaxStep Get", maxStep.ToString());
                return maxStep; // Maximum extent of the focuser
            }
        }

        public void Move(int Position)
        {
            tl.LogMessage("Move", Position.ToString());
            CommandBlind("M" + Position.ToString() + "\n", true);
        }

        public int Position
        {
            get
            {
                // Return the focuser position
                string s = CommandString("P\n", true);
                int position;
                int.TryParse(s, out position);
                return position;
            }
        }

        public double StepSize
        {
            get
            {
                // step size in microns
                return (double)(course * 1000m / (decimal)maxStep);
            }
        }

        public bool TempComp
        {
            get
            {
                string s = CommandString("tG\n", true);
                return s == "1";
            }
            set
            {
                string s;
                if (value)
                    s = CommandString("tS\n", true);
                else
                    s = CommandString("ts\n", true);

            }
        }

        public bool TempCompAvailable
        {
            get
            {
                string s = CommandString("tA\n", true);
                return s == "1";
            }
        }

        public double Temperature
        {
            get
            {
                // temperature is text formatted as an integer value, °C x 10
                string s = CommandString("T\n", true);
                int temperature;
                int.TryParse(s, out temperature);
                //Debug.WriteLine(temperature);
                return Math.Round((double)temperature / 10.0, 1, MidpointRounding.AwayFromZero);
            }
        }

        #endregion

        #region Private properties and methods
        // here are some useful properties and methods that can be used as required
        // to help with driver development

        #region ASCOM Registration

        // Register or unregister driver for ASCOM. This is harmless if already
        // registered or unregistered. 
        //
        /// <summary>
        /// Register or unregister the driver with the ASCOM Platform.
        /// This is harmless if the driver is already registered/unregistered.
        /// </summary>
        /// <param name="bRegister">If <c>true</c>, registers the driver, otherwise unregisters it.</param>
        private static void RegUnregASCOM(bool bRegister)
        {
            using (var P = new ASCOM.Utilities.Profile())
            {
                P.DeviceType = "Focuser";
                if (bRegister)
                {
                    P.Register(driverID, driverDescription);
                }
                else
                {
                    P.Unregister(driverID);
                }
            }
        }

        /// <summary>
        /// This function registers the driver with the ASCOM Chooser and
        /// is called automatically whenever this class is registered for COM Interop.
        /// </summary>
        /// <param name="t">Type of the class being registered, not used.</param>
        /// <remarks>
        /// This method typically runs in two distinct situations:
        /// <list type="numbered">
        /// <item>
        /// In Visual Studio, when the project is successfully built.
        /// For this to work correctly, the option <c>Register for COM Interop</c>
        /// must be enabled in the project settings.
        /// </item>
        /// <item>During setup, when the installer registers the assembly for COM Interop.</item>
        /// </list>
        /// This technique should mean that it is never necessary to manually register a driver with ASCOM.
        /// </remarks>
        [ComRegisterFunction]
        public static void RegisterASCOM(Type t)
        {
            RegUnregASCOM(true);
        }

        /// <summary>
        /// This function unregisters the driver from the ASCOM Chooser and
        /// is called automatically whenever this class is unregistered from COM Interop.
        /// </summary>
        /// <param name="t">Type of the class being registered, not used.</param>
        /// <remarks>
        /// This method typically runs in two distinct situations:
        /// <list type="numbered">
        /// <item>
        /// In Visual Studio, when the project is cleaned or prior to rebuilding.
        /// For this to work correctly, the option <c>Register for COM Interop</c>
        /// must be enabled in the project settings.
        /// </item>
        /// <item>During uninstall, when the installer unregisters the assembly from COM Interop.</item>
        /// </list>
        /// This technique should mean that it is never necessary to manually unregister a driver from ASCOM.
        /// </remarks>
        [ComUnregisterFunction]
        public static void UnregisterASCOM(Type t)
        {
            RegUnregASCOM(false);
        }

        #endregion

        /// <summary>
        /// Returns true if there is a valid connection to the driver hardware
        /// </summary>
        private bool IsConnected
        {
            get
            {
                if (serialPort == null)
                    return false;
#if USE_ASCOM_SERIAL
                return serialPort.Connected;
#else
                return serialPort.IsOpen;
#endif
            }
        }

        /// <summary>
        /// Use this function to throw an exception if we aren't connected to the hardware
        /// </summary>
        /// <param name="message"></param>
        private void CheckConnected(string message)
        {
            if (!IsConnected)
            {
                throw new ASCOM.NotConnectedException(message);
            }
        }

        /// <summary>
        /// Read the device configuration from the ASCOM Profile store
        /// </summary>
        internal void ReadProfile()
        {
            using (Profile profile = new Profile())
            {
                profile.DeviceType = "Focuser";
                alwaysOnTop = Convert.ToBoolean(profile.GetValue(driverID, alwaysOnTopProfileName, string.Empty, alwaysOnTopDefault));
                comPort = profile.GetValue(driverID, comPortProfileName, string.Empty, comPortDefault);
                maxStep = Convert.ToInt32(profile.GetValue(driverID, maxStepsProfileName, string.Empty, maxStepsDefault));
                course = Convert.ToDecimal(profile.GetValue(driverID, courseProfileName, string.Empty, courseDefault), CultureInfo.InvariantCulture);
                findZero = Convert.ToBoolean(profile.GetValue(driverID, findZeroProfileName, string.Empty, findZeroDefault));
                restoreLastPosition = Convert.ToBoolean(profile.GetValue(driverID, restorePositionProfileName, string.Empty, restorePositionDefault));
                temperatureCompensation = Convert.ToBoolean(profile.GetValue(driverID, tempCompensationProfileName, string.Empty, tempCompensationDefault));
                temperatureCoefficient = Convert.ToDecimal(profile.GetValue(driverID, tempCoefficientProfileName, string.Empty, tempCoefficientDefault), CultureInfo.InvariantCulture);
                fullStepsRev = Convert.ToInt32(profile.GetValue(driverID, fullStepsRevProfileName, string.Empty, fullStepsRevDefault));
                microStepsStep = Convert.ToInt32(profile.GetValue(driverID, microStepsStepProfileName, string.Empty, microStepsStepDefault));
                speedFastRps = Convert.ToDecimal(profile.GetValue(driverID, speedFastRpsProfileName, string.Empty, speedFastRpsDefault), CultureInfo.InvariantCulture);
                speedSlowRps = Convert.ToDecimal(profile.GetValue(driverID, speedSlowRpsProfileName, string.Empty, speedSlowRpsDefault), CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Write the device configuration to the  ASCOM  Profile store
        /// </summary>
        internal void WriteProfile()
        {
            using (Profile profile = new Profile())
            {
                profile.DeviceType = "Focuser";
                profile.WriteValue(driverID, alwaysOnTopProfileName, alwaysOnTop.ToString());
                profile.WriteValue(driverID, comPortProfileName, comPort);
                profile.WriteValue(driverID, maxStepsProfileName, maxStep.ToString());
                profile.WriteValue(driverID, courseProfileName, course.ToString(CultureInfo.InvariantCulture));
                profile.WriteValue(driverID, findZeroProfileName, findZero.ToString());
                profile.WriteValue(driverID, restorePositionProfileName, restoreLastPosition.ToString());
                profile.WriteValue(driverID, tempCompensationProfileName, temperatureCompensation.ToString());
                profile.WriteValue(driverID, tempCoefficientProfileName, temperatureCoefficient.ToString(CultureInfo.InvariantCulture));
                profile.WriteValue(driverID, fullStepsRevProfileName, fullStepsRev.ToString());
                profile.WriteValue(driverID, microStepsStepProfileName, microStepsStep.ToString());
                profile.WriteValue(driverID, speedFastRpsProfileName, speedFastRps.ToString(CultureInfo.InvariantCulture));
                profile.WriteValue(driverID, speedSlowRpsProfileName, speedSlowRps.ToString(CultureInfo.InvariantCulture));
            }
        }

        #endregion

    }
}
