namespace ASCOM.GenericStepper
{
    partial class SetupDialogForm
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
            this.numericUpDownMaxStep = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFocuserCourse = new System.Windows.Forms.NumericUpDown();
            this.labelStepSize = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelT2 = new System.Windows.Forms.Label();
            this.checkBoxTemperatureCompensation = new System.Windows.Forms.CheckBox();
            this.numericUpDownTemperatureMmCentigrade = new System.Windows.Forms.NumericUpDown();
            this.labelT1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picASCOM = new System.Windows.Forms.PictureBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedSlow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeedFast = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMicrosteps = new System.Windows.Forms.ComboBox();
            this.comboBoxStepsRevolution = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStepAngle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonForcelastPosition = new System.Windows.Forms.RadioButton();
            this.radioButtonFindZero = new System.Windows.Forms.RadioButton();
            this.checkBoxRestoreLastPosition = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelTempCoeffStepsCentigrade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFocuserCourse)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperatureMmCentigrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedSlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedFast)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownMaxStep
            // 
            this.numericUpDownMaxStep.Location = new System.Drawing.Point(118, 51);
            this.numericUpDownMaxStep.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDownMaxStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxStep.Name = "numericUpDownMaxStep";
            this.numericUpDownMaxStep.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownMaxStep.TabIndex = 3;
            this.numericUpDownMaxStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMaxStep.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericUpDownMaxStep.ValueChanged += new System.EventHandler(this.numericUpDownMaxStep_ValueChanged);
            // 
            // numericUpDownFocuserCourse
            // 
            this.numericUpDownFocuserCourse.DecimalPlaces = 1;
            this.numericUpDownFocuserCourse.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownFocuserCourse.Location = new System.Drawing.Point(118, 83);
            this.numericUpDownFocuserCourse.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            65536});
            this.numericUpDownFocuserCourse.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownFocuserCourse.Name = "numericUpDownFocuserCourse";
            this.numericUpDownFocuserCourse.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownFocuserCourse.TabIndex = 4;
            this.numericUpDownFocuserCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownFocuserCourse.Value = new decimal(new int[] {
            300,
            0,
            0,
            65536});
            this.numericUpDownFocuserCourse.ValueChanged += new System.EventHandler(this.numericUpDownFocuserCourse_ValueChanged);
            // 
            // labelStepSize
            // 
            this.labelStepSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStepSize.Location = new System.Drawing.Point(118, 116);
            this.labelStepSize.Name = "labelStepSize";
            this.labelStepSize.Size = new System.Drawing.Size(69, 20);
            this.labelStepSize.TabIndex = 19;
            this.labelStepSize.Text = "4.3";
            this.labelStepSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(118, 19);
            this.comboBoxComPort.MaxDropDownItems = 16;
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(69, 21);
            this.comboBoxComPort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Step size (µm):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTempCoeffStepsCentigrade);
            this.groupBox2.Controls.Add(this.labelT2);
            this.groupBox2.Controls.Add(this.checkBoxTemperatureCompensation);
            this.groupBox2.Controls.Add(this.numericUpDownTemperatureMmCentigrade);
            this.groupBox2.Controls.Add(this.labelT1);
            this.groupBox2.Location = new System.Drawing.Point(235, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 121);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature";
            // 
            // labelT2
            // 
            this.labelT2.AutoSize = true;
            this.labelT2.Enabled = false;
            this.labelT2.Location = new System.Drawing.Point(6, 90);
            this.labelT2.Name = "labelT2";
            this.labelT2.Size = new System.Drawing.Size(120, 13);
            this.labelT2.TabIndex = 16;
            this.labelT2.Text = "Temp. coeff. (steps/°C):";
            // 
            // checkBoxTemperatureCompensation
            // 
            this.checkBoxTemperatureCompensation.AutoSize = true;
            this.checkBoxTemperatureCompensation.Location = new System.Drawing.Point(9, 21);
            this.checkBoxTemperatureCompensation.Name = "checkBoxTemperatureCompensation";
            this.checkBoxTemperatureCompensation.Size = new System.Drawing.Size(187, 17);
            this.checkBoxTemperatureCompensation.TabIndex = 5;
            this.checkBoxTemperatureCompensation.Text = "Enable temperature compensation";
            this.checkBoxTemperatureCompensation.UseVisualStyleBackColor = true;
            this.checkBoxTemperatureCompensation.CheckedChanged += new System.EventHandler(this.checkBoxTemperatureCompensation_CheckedChanged);
            // 
            // numericUpDownTemperatureMmCentigrade
            // 
            this.numericUpDownTemperatureMmCentigrade.DecimalPlaces = 3;
            this.numericUpDownTemperatureMmCentigrade.Enabled = false;
            this.numericUpDownTemperatureMmCentigrade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownTemperatureMmCentigrade.Location = new System.Drawing.Point(127, 51);
            this.numericUpDownTemperatureMmCentigrade.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownTemperatureMmCentigrade.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDownTemperatureMmCentigrade.Name = "numericUpDownTemperatureMmCentigrade";
            this.numericUpDownTemperatureMmCentigrade.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownTemperatureMmCentigrade.TabIndex = 6;
            this.numericUpDownTemperatureMmCentigrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTemperatureMmCentigrade.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelT1
            // 
            this.labelT1.AutoSize = true;
            this.labelT1.Enabled = false;
            this.labelT1.Location = new System.Drawing.Point(6, 53);
            this.labelT1.Name = "labelT1";
            this.labelT1.Size = new System.Drawing.Size(111, 13);
            this.labelT1.TabIndex = 11;
            this.labelT1.Text = "Temp. coeff. (mm/°C):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Focuser course (mm):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Max steps:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAlwaysOnTop);
            this.groupBox1.Controls.Add(this.numericUpDownMaxStep);
            this.groupBox1.Controls.Add(this.numericUpDownFocuserCourse);
            this.groupBox1.Controls.Add(this.labelStepSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxComPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 166);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General settings";
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(13, 143);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.chkAlwaysOnTop.TabIndex = 20;
            this.chkAlwaysOnTop.Text = "Always on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Comm Port:";
            // 
            // picASCOM
            // 
            this.picASCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picASCOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picASCOM.Image = global::ASCOM.GenericStepper.Properties.Resources.ASCOM;
            this.picASCOM.Location = new System.Drawing.Point(284, 308);
            this.picASCOM.Name = "picASCOM";
            this.picASCOM.Size = new System.Drawing.Size(48, 56);
            this.picASCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picASCOM.TabIndex = 18;
            this.picASCOM.TabStop = false;
            this.picASCOM.Click += new System.EventHandler(this.BrowseToAscom);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(378, 338);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(59, 25);
            this.cmdCancel.TabIndex = 17;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(378, 308);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(59, 24);
            this.cmdOK.TabIndex = 16;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numericUpDownSpeedSlow);
            this.groupBox3.Controls.Add(this.numericUpDownSpeedFast);
            this.groupBox3.Controls.Add(this.comboBoxMicrosteps);
            this.groupBox3.Controls.Add(this.comboBoxStepsRevolution);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.labelStepAngle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 177);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Speed slow (RPS):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Speed fast (RPS):";
            // 
            // numericUpDownSpeedSlow
            // 
            this.numericUpDownSpeedSlow.DecimalPlaces = 1;
            this.numericUpDownSpeedSlow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSpeedSlow.Location = new System.Drawing.Point(118, 145);
            this.numericUpDownSpeedSlow.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSpeedSlow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSpeedSlow.Name = "numericUpDownSpeedSlow";
            this.numericUpDownSpeedSlow.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownSpeedSlow.TabIndex = 22;
            this.numericUpDownSpeedSlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSpeedSlow.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // numericUpDownSpeedFast
            // 
            this.numericUpDownSpeedFast.DecimalPlaces = 1;
            this.numericUpDownSpeedFast.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSpeedFast.Location = new System.Drawing.Point(118, 116);
            this.numericUpDownSpeedFast.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSpeedFast.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSpeedFast.Name = "numericUpDownSpeedFast";
            this.numericUpDownSpeedFast.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownSpeedFast.TabIndex = 22;
            this.numericUpDownSpeedFast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSpeedFast.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // comboBoxMicrosteps
            // 
            this.comboBoxMicrosteps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMicrosteps.FormattingEnabled = true;
            this.comboBoxMicrosteps.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.comboBoxMicrosteps.Location = new System.Drawing.Point(118, 83);
            this.comboBoxMicrosteps.Name = "comboBoxMicrosteps";
            this.comboBoxMicrosteps.Size = new System.Drawing.Size(69, 21);
            this.comboBoxMicrosteps.TabIndex = 2;
            // 
            // comboBoxStepsRevolution
            // 
            this.comboBoxStepsRevolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStepsRevolution.FormattingEnabled = true;
            this.comboBoxStepsRevolution.Items.AddRange(new object[] {
            "100",
            "200",
            "400"});
            this.comboBoxStepsRevolution.Location = new System.Drawing.Point(118, 19);
            this.comboBoxStepsRevolution.Name = "comboBoxStepsRevolution";
            this.comboBoxStepsRevolution.Size = new System.Drawing.Size(69, 21);
            this.comboBoxStepsRevolution.TabIndex = 1;
            this.comboBoxStepsRevolution.SelectedIndexChanged += new System.EventHandler(this.comboBoxStepsRevolution_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Microsteps/step:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Steps/rev:";
            // 
            // labelStepAngle
            // 
            this.labelStepAngle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStepAngle.Location = new System.Drawing.Point(118, 51);
            this.labelStepAngle.Name = "labelStepAngle";
            this.labelStepAngle.Size = new System.Drawing.Size(69, 20);
            this.labelStepAngle.TabIndex = 21;
            this.labelStepAngle.Text = "1.8°";
            this.labelStepAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Full step angle:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonForcelastPosition);
            this.groupBox4.Controls.Add(this.radioButtonFindZero);
            this.groupBox4.Controls.Add(this.checkBoxRestoreLastPosition);
            this.groupBox4.Location = new System.Drawing.Point(235, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 113);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "At connection";
            // 
            // radioButtonForcelastPosition
            // 
            this.radioButtonForcelastPosition.AutoSize = true;
            this.radioButtonForcelastPosition.Location = new System.Drawing.Point(27, 81);
            this.radioButtonForcelastPosition.Name = "radioButtonForcelastPosition";
            this.radioButtonForcelastPosition.Size = new System.Drawing.Size(110, 17);
            this.radioButtonForcelastPosition.TabIndex = 28;
            this.radioButtonForcelastPosition.Text = "Force last position";
            this.radioButtonForcelastPosition.UseVisualStyleBackColor = true;
            // 
            // radioButtonFindZero
            // 
            this.radioButtonFindZero.AutoSize = true;
            this.radioButtonFindZero.Checked = true;
            this.radioButtonFindZero.Location = new System.Drawing.Point(27, 16);
            this.radioButtonFindZero.Name = "radioButtonFindZero";
            this.radioButtonFindZero.Size = new System.Drawing.Size(136, 17);
            this.radioButtonFindZero.TabIndex = 27;
            this.radioButtonFindZero.TabStop = true;
            this.radioButtonFindZero.Text = "Find zero at connection";
            this.radioButtonFindZero.UseVisualStyleBackColor = true;
            this.radioButtonFindZero.CheckedChanged += new System.EventHandler(this.radioButtonFindZero_CheckedChanged);
            // 
            // checkBoxRestoreLastPosition
            // 
            this.checkBoxRestoreLastPosition.Checked = true;
            this.checkBoxRestoreLastPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRestoreLastPosition.Location = new System.Drawing.Point(49, 39);
            this.checkBoxRestoreLastPosition.Name = "checkBoxRestoreLastPosition";
            this.checkBoxRestoreLastPosition.Size = new System.Drawing.Size(137, 36);
            this.checkBoxRestoreLastPosition.TabIndex = 26;
            this.checkBoxRestoreLastPosition.Text = "Restore last position after finding zero";
            this.checkBoxRestoreLastPosition.UseVisualStyleBackColor = true;
            // 
            // labelTempCoeffStepsCentigrade
            // 
            this.labelTempCoeffStepsCentigrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTempCoeffStepsCentigrade.Enabled = false;
            this.labelTempCoeffStepsCentigrade.Location = new System.Drawing.Point(127, 86);
            this.labelTempCoeffStepsCentigrade.Name = "labelTempCoeffStepsCentigrade";
            this.labelTempCoeffStepsCentigrade.Size = new System.Drawing.Size(69, 20);
            this.labelTempCoeffStepsCentigrade.TabIndex = 20;
            this.labelTempCoeffStepsCentigrade.Text = "0.0";
            this.labelTempCoeffStepsCentigrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetupDialogForm
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(449, 372);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picASCOM);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenericStepper Setup";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFocuserCourse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperatureMmCentigrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedSlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedFast)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownMaxStep;
        private System.Windows.Forms.NumericUpDown numericUpDownFocuserCourse;
        private System.Windows.Forms.Label labelStepSize;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelT2;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperatureMmCentigrade;
        private System.Windows.Forms.Label labelT1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picASCOM;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMicrosteps;
        private System.Windows.Forms.ComboBox comboBoxStepsRevolution;
        private System.Windows.Forms.Label labelStepAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedFast;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedSlow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonForcelastPosition;
        private System.Windows.Forms.RadioButton radioButtonFindZero;
        private System.Windows.Forms.CheckBox checkBoxRestoreLastPosition;
        private System.Windows.Forms.CheckBox checkBoxTemperatureCompensation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.Label labelTempCoeffStepsCentigrade;

    }
}