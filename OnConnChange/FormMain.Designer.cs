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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.checkBoxAudioWarningOnConnChange = new System.Windows.Forms.CheckBox();
            this.checkBoxFocusOnConnChange = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDownDetectionThreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPingIntervall = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timerInterval = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDownDetectionThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingIntervall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(3, 3);
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
            this.checkBoxAudioWarningOnConnChange.Checked = true;
            this.checkBoxAudioWarningOnConnChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAudioWarningOnConnChange.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAudioWarningOnConnChange.Name = "checkBoxAudioWarningOnConnChange";
            this.checkBoxAudioWarningOnConnChange.Size = new System.Drawing.Size(242, 17);
            this.checkBoxAudioWarningOnConnChange.TabIndex = 1;
            this.checkBoxAudioWarningOnConnChange.Text = "Play sound when loosing/gaining connectivity";
            this.checkBoxAudioWarningOnConnChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxFocusOnConnChange
            // 
            this.checkBoxFocusOnConnChange.AutoSize = true;
            this.checkBoxFocusOnConnChange.Location = new System.Drawing.Point(6, 37);
            this.checkBoxFocusOnConnChange.Name = "checkBoxFocusOnConnChange";
            this.checkBoxFocusOnConnChange.Size = new System.Drawing.Size(232, 17);
            this.checkBoxFocusOnConnChange.TabIndex = 2;
            this.checkBoxFocusOnConnChange.Text = "Focus this tool upon change of connectivity";
            this.checkBoxFocusOnConnChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Threshold for down detection:";
            // 
            // numericUpDownDownDetectionThreshold
            // 
            this.numericUpDownDownDetectionThreshold.Location = new System.Drawing.Point(160, 55);
            this.numericUpDownDownDetectionThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDownDetectionThreshold.Name = "numericUpDownDownDetectionThreshold";
            this.numericUpDownDownDetectionThreshold.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownDownDetectionThreshold.TabIndex = 4;
            this.numericUpDownDownDetectionThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
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
            this.numericUpDownPingIntervall.Location = new System.Drawing.Point(160, 81);
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
            this.label3.Location = new System.Drawing.Point(231, 83);
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
            // chart1
            // 
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(284, 80);
            this.chart1.TabIndex = 10;
            this.chart1.TabStop = false;
            this.chart1.Text = "Latency";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // checkBoxAlwaysOnTop
            // 
            this.checkBoxAlwaysOnTop.AutoSize = true;
            this.checkBoxAlwaysOnTop.Location = new System.Drawing.Point(84, 3);
            this.checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            this.checkBoxAlwaysOnTop.Size = new System.Drawing.Size(91, 17);
            this.checkBoxAlwaysOnTop.TabIndex = 11;
            this.checkBoxAlwaysOnTop.Text = "always on top";
            this.checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBoxAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxOptions.Controls.Add(this.checkBoxAudioWarningOnConnChange);
            this.groupBoxOptions.Controls.Add(this.checkBoxFocusOnConnChange);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.numericUpDownDownDetectionThreshold);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.label3);
            this.groupBoxOptions.Controls.Add(this.numericUpDownPingIntervall);
            this.groupBoxOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxOptions.Location = new System.Drawing.Point(0, 116);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(284, 111);
            this.groupBoxOptions.TabIndex = 12;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonStartStop);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAlwaysOnTop);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 28);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "VisualAlertOnDisconnect";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDownDetectionThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingIntervall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBoxAlwaysOnTop;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

