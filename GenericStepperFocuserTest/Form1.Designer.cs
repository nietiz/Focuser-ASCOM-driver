namespace ASCOM.GenericStepper
{
    partial class Form1
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
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.buttonMoveTo = new System.Windows.Forms.Button();
            this.numericUpDownPosition = new System.Windows.Forms.NumericUpDown();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonMicroSteps = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonInSlow = new System.Windows.Forms.Button();
            this.buttonOutSlow = new System.Windows.Forms.Button();
            this.buttonGoToZero = new System.Windows.Forms.Button();
            this.buttonGoToEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(309, 10);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(72, 23);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(309, 39);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(72, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelDriverId
            // 
            this.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.GenericStepper.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(12, 40);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(291, 21);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.GenericStepper.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonMoveTo
            // 
            this.buttonMoveTo.Location = new System.Drawing.Point(12, 210);
            this.buttonMoveTo.Name = "buttonMoveTo";
            this.buttonMoveTo.Size = new System.Drawing.Size(51, 23);
            this.buttonMoveTo.TabIndex = 3;
            this.buttonMoveTo.Text = "Go To";
            this.buttonMoveTo.UseVisualStyleBackColor = true;
            this.buttonMoveTo.Click += new System.EventHandler(this.buttonMoveTo_Click);
            // 
            // numericUpDownPosition
            // 
            this.numericUpDownPosition.Location = new System.Drawing.Point(83, 213);
            this.numericUpDownPosition.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDownPosition.Name = "numericUpDownPosition";
            this.numericUpDownPosition.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownPosition.TabIndex = 4;
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(12, 150);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(75, 23);
            this.buttonIn.TabIndex = 5;
            this.buttonIn.Text = "<<";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonIn_MouseDown);
            this.buttonIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonIn_MouseUp);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(270, 150);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(75, 23);
            this.buttonOut.TabIndex = 5;
            this.buttonOut.Text = ">>";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOut_MouseDown);
            this.buttonOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonOut_MouseUp);
            // 
            // labelPosition
            // 
            this.labelPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPosition.Location = new System.Drawing.Point(12, 110);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(170, 23);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(12, 74);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(75, 23);
            this.buttonZero.TabIndex = 7;
            this.buttonZero.Text = "Find zero";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(107, 74);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonMicroSteps
            // 
            this.buttonMicroSteps.Location = new System.Drawing.Point(12, 298);
            this.buttonMicroSteps.Name = "buttonMicroSteps";
            this.buttonMicroSteps.Size = new System.Drawing.Size(75, 23);
            this.buttonMicroSteps.TabIndex = 8;
            this.buttonMicroSteps.Text = "micro steps";
            this.buttonMicroSteps.UseVisualStyleBackColor = true;
            this.buttonMicroSteps.Click += new System.EventHandler(this.buttonMicroSteps_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.comboBox1.Location = new System.Drawing.Point(93, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // buttonInSlow
            // 
            this.buttonInSlow.Location = new System.Drawing.Point(93, 150);
            this.buttonInSlow.Name = "buttonInSlow";
            this.buttonInSlow.Size = new System.Drawing.Size(75, 23);
            this.buttonInSlow.TabIndex = 5;
            this.buttonInSlow.Text = "<";
            this.buttonInSlow.UseVisualStyleBackColor = true;
            this.buttonInSlow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonInSlow_MouseDown);
            this.buttonInSlow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonInSlow_MouseUp);
            // 
            // buttonOutSlow
            // 
            this.buttonOutSlow.Location = new System.Drawing.Point(189, 150);
            this.buttonOutSlow.Name = "buttonOutSlow";
            this.buttonOutSlow.Size = new System.Drawing.Size(75, 23);
            this.buttonOutSlow.TabIndex = 5;
            this.buttonOutSlow.Text = ">";
            this.buttonOutSlow.UseVisualStyleBackColor = true;
            this.buttonOutSlow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOutSlow_MouseDown);
            this.buttonOutSlow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonOutSlow_MouseUp);
            // 
            // buttonGoToZero
            // 
            this.buttonGoToZero.Location = new System.Drawing.Point(12, 239);
            this.buttonGoToZero.Name = "buttonGoToZero";
            this.buttonGoToZero.Size = new System.Drawing.Size(75, 23);
            this.buttonGoToZero.TabIndex = 10;
            this.buttonGoToZero.Text = "Go to zero";
            this.buttonGoToZero.UseVisualStyleBackColor = true;
            this.buttonGoToZero.Click += new System.EventHandler(this.buttonGoToZero_Click);
            // 
            // buttonGoToEnd
            // 
            this.buttonGoToEnd.Location = new System.Drawing.Point(93, 239);
            this.buttonGoToEnd.Name = "buttonGoToEnd";
            this.buttonGoToEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonGoToEnd.TabIndex = 10;
            this.buttonGoToEnd.Text = "Go to end";
            this.buttonGoToEnd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 420);
            this.Controls.Add(this.buttonGoToEnd);
            this.Controls.Add(this.buttonGoToZero);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonMicroSteps);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.buttonOutSlow);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonInSlow);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.numericUpDownPosition);
            this.Controls.Add(this.buttonMoveTo);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Name = "Form1";
            this.Text = "TEMPLATEDEVICETYPE Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Button buttonMoveTo;
        private System.Windows.Forms.NumericUpDown numericUpDownPosition;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonMicroSteps;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonInSlow;
        private System.Windows.Forms.Button buttonOutSlow;
        private System.Windows.Forms.Button buttonGoToZero;
        private System.Windows.Forms.Button buttonGoToEnd;
    }
}

