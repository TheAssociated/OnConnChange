namespace OnConnChange
{
    partial class FormMain
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
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.checkBoxAudioWarningOnConnChange = new System.Windows.Forms.CheckBox();
            this.checkBoxFocusOnConnChange = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDownDetectionThreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPingIntervall = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timerInterval = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPacketLossThreshold = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDownDetectionThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingIntervall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPacketLossThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(12, 12);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // checkBoxAudioWarningOnConnChange
            // 
            this.checkBoxAudioWarningOnConnChange.AutoSize = true;
            this.checkBoxAudioWarningOnConnChange.Location = new System.Drawing.Point(12, 41);
            this.checkBoxAudioWarningOnConnChange.Name = "checkBoxAudioWarningOnConnChange";
            this.checkBoxAudioWarningOnConnChange.Size = new System.Drawing.Size(242, 17);
            this.checkBoxAudioWarningOnConnChange.TabIndex = 1;
            this.checkBoxAudioWarningOnConnChange.Text = "Play sound when loosing/gaining connectivity";
            this.checkBoxAudioWarningOnConnChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxFocusOnConnChange
            // 
            this.checkBoxFocusOnConnChange.AutoSize = true;
            this.checkBoxFocusOnConnChange.Location = new System.Drawing.Point(12, 59);
            this.checkBoxFocusOnConnChange.Name = "checkBoxFocusOnConnChange";
            this.checkBoxFocusOnConnChange.Size = new System.Drawing.Size(232, 17);
            this.checkBoxFocusOnConnChange.TabIndex = 2;
            this.checkBoxFocusOnConnChange.Text = "Focus this tool upon change of connectivity";
            this.checkBoxFocusOnConnChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Threshold for down detection:";
            // 
            // numericUpDownDownDetectionThreshold
            // 
            this.numericUpDownDownDetectionThreshold.Location = new System.Drawing.Point(166, 77);
            this.numericUpDownDownDetectionThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDownDetectionThreshold.Name = "numericUpDownDownDetectionThreshold";
            this.numericUpDownDownDetectionThreshold.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownDownDetectionThreshold.TabIndex = 4;
            this.numericUpDownDownDetectionThreshold.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ping Intervall";
            // 
            // numericUpDownPingIntervall
            // 
            this.numericUpDownPingIntervall.DecimalPlaces = 1;
            this.numericUpDownPingIntervall.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownPingIntervall.Location = new System.Drawing.Point(166, 129);
            this.numericUpDownPingIntervall.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownPingIntervall.Name = "numericUpDownPingIntervall";
            this.numericUpDownPingIntervall.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownPingIntervall.TabIndex = 6;
            this.numericUpDownPingIntervall.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.numericUpDownPingIntervall.ValueChanged += new System.EventHandler(this.numericUpDownPingIntervall_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "s";
            // 
            // timerInterval
            // 
            this.timerInterval.Interval = 2000;
            this.timerInterval.Tick += new System.EventHandler(this.timerInterval_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Packetloss Warning Threshold";
            // 
            // numericUpDownPacketLossThreshold
            // 
            this.numericUpDownPacketLossThreshold.Location = new System.Drawing.Point(166, 103);
            this.numericUpDownPacketLossThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPacketLossThreshold.Name = "numericUpDownPacketLossThreshold";
            this.numericUpDownPacketLossThreshold.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownPacketLossThreshold.TabIndex = 9;
            this.numericUpDownPacketLossThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.numericUpDownPacketLossThreshold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownPingIntervall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownDownDetectionThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxFocusOnConnChange);
            this.Controls.Add(this.checkBoxAudioWarningOnConnChange);
            this.Controls.Add(this.buttonStartStop);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 240);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "VisualAlertOnDisconnect";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDownDetectionThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingIntervall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPacketLossThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.CheckBox checkBoxAudioWarningOnConnChange;
        private System.Windows.Forms.CheckBox checkBoxFocusOnConnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDownDetectionThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPingIntervall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPacketLossThreshold;
    }
}

