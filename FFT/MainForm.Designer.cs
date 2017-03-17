namespace FFT
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.crtInput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadSignal = new System.Windows.Forms.Button();
            this.cbSecondHarm = new System.Windows.Forms.CheckBox();
            this.cbThirdHarm = new System.Windows.Forms.CheckBox();
            this.trbSecondHarmMagnitude = new System.Windows.Forms.TrackBar();
            this.tbSecondHarmMagnitude = new System.Windows.Forms.TextBox();
            this.tbThirdHarmMagnitude = new System.Windows.Forms.TextBox();
            this.trbThirdHarmMagnitude = new System.Windows.Forms.TrackBar();
            this.trbThirdHarmAngle = new System.Windows.Forms.TrackBar();
            this.tbThirdHarmAngle = new System.Windows.Forms.TextBox();
            this.tbSecondHarmAngle = new System.Windows.Forms.TextBox();
            this.trbSecondHarmAngle = new System.Windows.Forms.TrackBar();
            this.lbSecondHarmMagn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crtFft = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFFT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbZeroMagnitude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbThirdFrequenc = new System.Windows.Forms.TextBox();
            this.tbSeconfFrequenc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crtInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSecondHarmMagnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThirdHarmMagnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThirdHarmAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSecondHarmAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtFft)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crtInput
            // 
            chartArea1.Name = "ChartArea1";
            this.crtInput.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtInput.Legends.Add(legend1);
            this.crtInput.Location = new System.Drawing.Point(12, 12);
            this.crtInput.MinimumSize = new System.Drawing.Size(987, 265);
            this.crtInput.Name = "crtInput";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Waveform";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Second Harmonic";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Third Harmonic";
            this.crtInput.Series.Add(series1);
            this.crtInput.Series.Add(series2);
            this.crtInput.Series.Add(series3);
            this.crtInput.Size = new System.Drawing.Size(987, 265);
            this.crtInput.TabIndex = 0;
            this.crtInput.Text = "Input Chart";
            // 
            // btnLoadSignal
            // 
            this.btnLoadSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadSignal.Location = new System.Drawing.Point(43, 58);
            this.btnLoadSignal.Name = "btnLoadSignal";
            this.btnLoadSignal.Size = new System.Drawing.Size(146, 32);
            this.btnLoadSignal.TabIndex = 1;
            this.btnLoadSignal.Text = "Load Signal";
            this.btnLoadSignal.UseVisualStyleBackColor = true;
            this.btnLoadSignal.Click += new System.EventHandler(this.btnLoadSignal_Click);
            // 
            // cbSecondHarm
            // 
            this.cbSecondHarm.AutoSize = true;
            this.cbSecondHarm.Location = new System.Drawing.Point(49, 30);
            this.cbSecondHarm.Name = "cbSecondHarm";
            this.cbSecondHarm.Size = new System.Drawing.Size(15, 14);
            this.cbSecondHarm.TabIndex = 3;
            this.cbSecondHarm.UseVisualStyleBackColor = true;
            this.cbSecondHarm.CheckedChanged += new System.EventHandler(this.cbSecondHarm_CheckedChanged);
            // 
            // cbThirdHarm
            // 
            this.cbThirdHarm.AutoSize = true;
            this.cbThirdHarm.Location = new System.Drawing.Point(166, 30);
            this.cbThirdHarm.Name = "cbThirdHarm";
            this.cbThirdHarm.Size = new System.Drawing.Size(15, 14);
            this.cbThirdHarm.TabIndex = 4;
            this.cbThirdHarm.UseVisualStyleBackColor = true;
            this.cbThirdHarm.CheckedChanged += new System.EventHandler(this.cbThirdHarm_CheckedChanged);
            // 
            // trbSecondHarmMagnitude
            // 
            this.trbSecondHarmMagnitude.LargeChange = 10;
            this.trbSecondHarmMagnitude.Location = new System.Drawing.Point(6, 183);
            this.trbSecondHarmMagnitude.Name = "trbSecondHarmMagnitude";
            this.trbSecondHarmMagnitude.Size = new System.Drawing.Size(108, 45);
            this.trbSecondHarmMagnitude.TabIndex = 5;
            this.trbSecondHarmMagnitude.Scroll += new System.EventHandler(this.trbSecondHarmMagnitude_Scroll);
            // 
            // tbSecondHarmMagnitude
            // 
            this.tbSecondHarmMagnitude.Enabled = false;
            this.tbSecondHarmMagnitude.Location = new System.Drawing.Point(43, 149);
            this.tbSecondHarmMagnitude.Name = "tbSecondHarmMagnitude";
            this.tbSecondHarmMagnitude.Size = new System.Drawing.Size(28, 26);
            this.tbSecondHarmMagnitude.TabIndex = 6;
            this.tbSecondHarmMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbThirdHarmMagnitude
            // 
            this.tbThirdHarmMagnitude.Enabled = false;
            this.tbThirdHarmMagnitude.Location = new System.Drawing.Point(161, 149);
            this.tbThirdHarmMagnitude.Name = "tbThirdHarmMagnitude";
            this.tbThirdHarmMagnitude.Size = new System.Drawing.Size(28, 26);
            this.tbThirdHarmMagnitude.TabIndex = 7;
            this.tbThirdHarmMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trbThirdHarmMagnitude
            // 
            this.trbThirdHarmMagnitude.LargeChange = 10;
            this.trbThirdHarmMagnitude.Location = new System.Drawing.Point(121, 183);
            this.trbThirdHarmMagnitude.Name = "trbThirdHarmMagnitude";
            this.trbThirdHarmMagnitude.Size = new System.Drawing.Size(108, 45);
            this.trbThirdHarmMagnitude.TabIndex = 8;
            this.trbThirdHarmMagnitude.Scroll += new System.EventHandler(this.trbThirdHarmMagnitude_Scroll);
            // 
            // trbThirdHarmAngle
            // 
            this.trbThirdHarmAngle.LargeChange = 10;
            this.trbThirdHarmAngle.Location = new System.Drawing.Point(155, 278);
            this.trbThirdHarmAngle.Maximum = 360;
            this.trbThirdHarmAngle.Name = "trbThirdHarmAngle";
            this.trbThirdHarmAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbThirdHarmAngle.Size = new System.Drawing.Size(45, 134);
            this.trbThirdHarmAngle.TabIndex = 14;
            this.trbThirdHarmAngle.Scroll += new System.EventHandler(this.trbThirdHarmAngle_Scroll);
            // 
            // tbThirdHarmAngle
            // 
            this.tbThirdHarmAngle.Enabled = false;
            this.tbThirdHarmAngle.Location = new System.Drawing.Point(155, 246);
            this.tbThirdHarmAngle.Name = "tbThirdHarmAngle";
            this.tbThirdHarmAngle.Size = new System.Drawing.Size(40, 26);
            this.tbThirdHarmAngle.TabIndex = 13;
            this.tbThirdHarmAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSecondHarmAngle
            // 
            this.tbSecondHarmAngle.Enabled = false;
            this.tbSecondHarmAngle.Location = new System.Drawing.Point(37, 246);
            this.tbSecondHarmAngle.Name = "tbSecondHarmAngle";
            this.tbSecondHarmAngle.Size = new System.Drawing.Size(40, 26);
            this.tbSecondHarmAngle.TabIndex = 12;
            this.tbSecondHarmAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trbSecondHarmAngle
            // 
            this.trbSecondHarmAngle.LargeChange = 10;
            this.trbSecondHarmAngle.Location = new System.Drawing.Point(37, 278);
            this.trbSecondHarmAngle.Maximum = 360;
            this.trbSecondHarmAngle.Name = "trbSecondHarmAngle";
            this.trbSecondHarmAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbSecondHarmAngle.Size = new System.Drawing.Size(45, 134);
            this.trbSecondHarmAngle.TabIndex = 11;
            this.trbSecondHarmAngle.Scroll += new System.EventHandler(this.trbSecondHarmAngle_Scroll);
            // 
            // lbSecondHarmMagn
            // 
            this.lbSecondHarmMagn.AutoSize = true;
            this.lbSecondHarmMagn.Location = new System.Drawing.Point(62, 26);
            this.lbSecondHarmMagn.Name = "lbSecondHarmMagn";
            this.lbSecondHarmMagn.Size = new System.Drawing.Size(36, 20);
            this.lbSecondHarmMagn.TabIndex = 15;
            this.lbSecondHarmMagn.Text = "2nd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "3rd\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Amplitudes\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Angles";
            // 
            // crtFft
            // 
            this.crtFft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea2.Name = "ChartArea1";
            this.crtFft.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtFft.Legends.Add(legend2);
            this.crtFft.Location = new System.Drawing.Point(12, 305);
            this.crtFft.MinimumSize = new System.Drawing.Size(987, 265);
            this.crtFft.Name = "crtFft";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Frequency";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Angles";
            this.crtFft.Series.Add(series4);
            this.crtFft.Series.Add(series5);
            this.crtFft.Size = new System.Drawing.Size(987, 265);
            this.crtFft.TabIndex = 19;
            this.crtFft.Text = "Input Chart";
            // 
            // btnFFT
            // 
            this.btnFFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFFT.Location = new System.Drawing.Point(1048, 538);
            this.btnFFT.Name = "btnFFT";
            this.btnFFT.Size = new System.Drawing.Size(146, 32);
            this.btnFFT.TabIndex = 20;
            this.btnFFT.Text = "FFT";
            this.btnFFT.UseVisualStyleBackColor = true;
            this.btnFFT.Click += new System.EventHandler(this.btnFFT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbZeroMagnitude);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnLoadSignal);
            this.groupBox1.Location = new System.Drawing.Point(1005, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 96);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WaveForm";
            // 
            // tbZeroMagnitude
            // 
            this.tbZeroMagnitude.Location = new System.Drawing.Point(173, 19);
            this.tbZeroMagnitude.Name = "tbZeroMagnitude";
            this.tbZeroMagnitude.Size = new System.Drawing.Size(44, 26);
            this.tbZeroMagnitude.TabIndex = 22;
            this.tbZeroMagnitude.Text = "0";
            this.tbZeroMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbZeroMagnitude.TextChanged += new System.EventHandler(this.tbZeroMagnitude_TextChanged);
            this.tbZeroMagnitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbZeroMagnitude_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Zero frq magnitude";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbThirdFrequenc);
            this.groupBox2.Controls.Add(this.tbSeconfFrequenc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbSecondHarmMagnitude);
            this.groupBox2.Controls.Add(this.cbSecondHarm);
            this.groupBox2.Controls.Add(this.trbThirdHarmAngle);
            this.groupBox2.Controls.Add(this.tbThirdHarmAngle);
            this.groupBox2.Controls.Add(this.cbThirdHarm);
            this.groupBox2.Controls.Add(this.tbSecondHarmAngle);
            this.groupBox2.Controls.Add(this.trbSecondHarmMagnitude);
            this.groupBox2.Controls.Add(this.trbSecondHarmAngle);
            this.groupBox2.Controls.Add(this.lbSecondHarmMagn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbThirdHarmMagnitude);
            this.groupBox2.Controls.Add(this.trbThirdHarmMagnitude);
            this.groupBox2.Location = new System.Drawing.Point(1005, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 418);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Harmonics";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Hz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hz";
            // 
            // tbThirdFrequenc
            // 
            this.tbThirdFrequenc.Location = new System.Drawing.Point(155, 85);
            this.tbThirdFrequenc.Name = "tbThirdFrequenc";
            this.tbThirdFrequenc.Size = new System.Drawing.Size(40, 26);
            this.tbThirdFrequenc.TabIndex = 21;
            this.tbThirdFrequenc.TextChanged += new System.EventHandler(this.tbThirdFrequenc_TextChanged);
            this.tbThirdFrequenc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThirdFrequenc_KeyPress);
            // 
            // tbSeconfFrequenc
            // 
            this.tbSeconfFrequenc.Location = new System.Drawing.Point(37, 85);
            this.tbSeconfFrequenc.Name = "tbSeconfFrequenc";
            this.tbSeconfFrequenc.Size = new System.Drawing.Size(40, 26);
            this.tbSeconfFrequenc.TabIndex = 20;
            this.tbSeconfFrequenc.TextChanged += new System.EventHandler(this.tbSeconfFrequenc_TextChanged);
            this.tbSeconfFrequenc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeconfFrequenc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Frequencies";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1252, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFFT);
            this.Controls.Add(this.crtFft);
            this.Controls.Add(this.crtInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1268, 621);
            this.Name = "MainForm";
            this.Text = "FFT Signal Analysis";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.crtInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSecondHarmMagnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThirdHarmMagnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThirdHarmAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSecondHarmAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtFft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtInput;
        private System.Windows.Forms.Button btnLoadSignal;
        private System.Windows.Forms.CheckBox cbSecondHarm;
        private System.Windows.Forms.CheckBox cbThirdHarm;
        private System.Windows.Forms.TrackBar trbSecondHarmMagnitude;
        private System.Windows.Forms.TextBox tbSecondHarmMagnitude;
        private System.Windows.Forms.TextBox tbThirdHarmMagnitude;
        private System.Windows.Forms.TrackBar trbThirdHarmMagnitude;
        private System.Windows.Forms.TrackBar trbThirdHarmAngle;
        private System.Windows.Forms.TextBox tbThirdHarmAngle;
        private System.Windows.Forms.TextBox tbSecondHarmAngle;
        private System.Windows.Forms.TrackBar trbSecondHarmAngle;
        private System.Windows.Forms.Label lbSecondHarmMagn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtFft;
        private System.Windows.Forms.Button btnFFT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbThirdFrequenc;
        private System.Windows.Forms.TextBox tbSeconfFrequenc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZeroMagnitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

