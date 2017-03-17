using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;


namespace FFT
{
    public partial class MainForm : Form
    {
        private static int _numSamples = 2000;
        private static int _sampleRate = 4000;
        private static int _magSecond;
        private static int _magThird;
        private static double _phaseSecond;
        private static double _phaseThird;
        private static int _freqSecond = 120;
        private static int _freqThird = 180;
        private static int _zeroMagnitude = 0;

        readonly Complex[] _samples = new Complex[_numSamples];

        public MainForm()
        {
            InitializeComponent();
            tbSeconfFrequenc.Text = _freqSecond.ToString();
            tbThirdFrequenc.Text = _freqThird.ToString();
            //tbSamplesNumber.Text = _numSamples.ToString();
        }

        private void btnLoadSignal_Click(object sender, EventArgs e)
        {
            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
        }

        private void PlotWaveform(int secondHarm, int thirdHarm, double secondPhase, double thirdPhase, double _zeroMagn)
        {
            crtInput.Series["Waveform"].Points.Clear();
            crtInput.Series["Second Harmonic"].Points.Clear();
            crtInput.Series["Third Harmonic"].Points.Clear();

            double[] fundamental = Generate.Sinusoidal(_numSamples, _sampleRate, 60, 10.0);
            double[] second = Generate.Sinusoidal(_numSamples, _sampleRate, _freqSecond, secondHarm, 0.0, secondPhase*Math.PI/180);
            double[] third = Generate.Sinusoidal(_numSamples, _sampleRate, _freqThird, thirdHarm, 0.0, thirdPhase*Math.PI/180);

            for (int i = 0; i < _numSamples; i++)
            {
                _samples[i] = new Complex(fundamental[i] + second[i] + third[i] + _zeroMagn, 0);
            }

            for (int i = 0; i < _samples.Length/5; i++)
            {
                double time = ((i + 1.0)/_numSamples)/2;

                crtInput.Series["Waveform"].LegendText = "Waveform";
                crtInput.Series["Waveform"].ChartType = SeriesChartType.Line;

                crtInput.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 14.0f);
                crtInput.ChartAreas["ChartArea1"].AxisX.Title = "Seconds";

                if (cbSecondHarm.Checked)
                {
                    crtInput.Series["Second Harmonic"].Points.AddXY(time, second[i]);
                }

                if (cbThirdHarm.Checked)
                {
                    crtInput.Series["Third Harmonic"].Points.AddXY(time, third[i]);
                }

                crtInput.Series["Waveform"].Points.AddXY(time, _samples[i].Real);
            }
        }

        private void trbSecondHarmMagnitude_Scroll(object sender, EventArgs e)
        {
            tbSecondHarmMagnitude.Text = trbSecondHarmMagnitude.Value.ToString();

            _magSecond = trbSecondHarmMagnitude.Value;

            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
            if(crtFft.Series["Frequency"].Points.Count != 0) PlotFftAnalys();
        }

        private void trbThirdHarmMagnitude_Scroll(object sender, EventArgs e)
        {
            tbThirdHarmMagnitude.Text = trbThirdHarmMagnitude.Value.ToString();

            _magThird = trbThirdHarmMagnitude.Value;

            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
            if(crtFft.Series["Frequency"].Points.Count != 0) PlotFftAnalys();
        }

        private void cbSecondHarm_CheckedChanged(object sender, EventArgs e)
        {
            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
        }

        private void cbThirdHarm_CheckedChanged(object sender, EventArgs e)
        {
            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
        }

        private void trbSecondHarmAngle_Scroll(object sender, EventArgs e)
        {
            tbSecondHarmAngle.Text = trbSecondHarmAngle.Value.ToString();

            _phaseSecond = trbSecondHarmAngle.Value;

            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
        }

        private void trbThirdHarmAngle_Scroll(object sender, EventArgs e)
        {
            tbThirdHarmAngle.Text = trbThirdHarmAngle.Value.ToString();

            _phaseThird = trbThirdHarmAngle.Value;

            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
        }

        private void btnFFT_Click(object sender, EventArgs e)
        {
            PlotFftAnalys();
        }

        private void PlotFftAnalys()
        {
            crtFft.Series["Frequency"].Points.Clear();
            
            Fourier.Forward(_samples, FourierOptions.NoScaling);

            for (int i = 0; i < _samples.Length/4; i++)
            {
                crtFft.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
                crtFft.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 14.0f);
                crtFft.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = true;

                double mag = (2.0/_numSamples)*(Math.Abs(Math.Sqrt(Math.Pow(_samples[i].Real, 2) +
                                                Math.Pow(_samples[i].Imaginary, 2))));

                double hzPerSample = _sampleRate/_numSamples;

                crtFft.Series["Frequency"].Points.AddXY(hzPerSample*i, mag);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            crtInput.Width = this.Width - 281;
            crtFft.Width = this.Width - 281;
            crtInput.Height = (this.Height - 91)/2;
            crtFft.Height = (this.Height - 91)/2;

        }

        private void tbSeconfFrequenc_TextChanged(object sender, EventArgs e)
        {
            var res = int.TryParse(tbSeconfFrequenc.Text, out _freqSecond);
            if (!res)
            {
                _freqSecond = 1;
                //tbSeconfFrequenc.Text = "1";
            }
            //_freqSecond = int.Parse(tbSeconfFrequenc.Text);
            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
            if (crtFft.Series["Frequency"].Points.Count != 0) PlotFftAnalys();
        }

        private void tbSeconfFrequenc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbThirdFrequenc_TextChanged(object sender, EventArgs e)
        {
            var res = int.TryParse(tbThirdFrequenc.Text, out _freqThird);
            if (!res)
            {
                _freqThird = 1;
                //tbThirdFrequenc.Text = "1";
            }

            //_freqThird = int.Parse(tbThirdFrequenc.Text);
            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
            if (crtFft.Series["Frequency"].Points.Count != 0) PlotFftAnalys();
        }

        private void tbThirdFrequenc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbZeroMagnitude_TextChanged(object sender, EventArgs e)
        {
            var res = int.TryParse(tbZeroMagnitude.Text, out _zeroMagnitude);
            if (!res) _zeroMagnitude = 0;
            PlotWaveform(_magSecond, _magThird, _phaseSecond, _phaseThird, _zeroMagnitude);
            if (crtFft.Series["Frequency"].Points.Count != 0) PlotFftAnalys();
        }

        private void tbZeroMagnitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*private void tbSamplesNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void tbSamplesNumber_TextChanged(object sender, EventArgs e)
        {
            _numSamples = int.Parse(tbSamplesNumber.Text);
        }*/
    }
}
