using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnConnChange
{
    public partial class FormMain : Form
    {
        public DateTime timeStarted = DateTime.Now;
        Ping pingSender = new Ping();
        byte[] buffer = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        int timeout = 800;
        AutoResetEvent waiter = new AutoResetEvent(false);
        PingOptions PingOptions = new PingOptions(64, true);
        private static int MaxConnDetailsCount = 128;
        private static List<Tuple<DateTime, long>> ConnDetails = new List<Tuple<DateTime, long>>(MaxConnDetailsCount);
        private static Object ConnDetailsLock = new Object();
        private bool OfflineSignaled = false;
        private bool OnlineSignaled = false;

        public FormMain()
        {
            InitializeComponent();
            pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);
            
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            timerInterval.Enabled = !timerInterval.Enabled;
            buttonStartStop.Text = timerInterval.Enabled ? "Stop" : "Start";

            groupBoxOptions.Size = new Size(groupBoxOptions.Size.Width, (groupBoxOptions.Size.Height==0) ? 116: 0); // 153
            this.Size = new Size(0,108);
        }

        private void numericUpDownPingIntervall_ValueChanged(object sender, EventArgs e)
        {
            timerInterval.Interval = (int)(numericUpDownPingIntervall.Value * 1000);
        }

        private void timerInterval_Tick(object sender, EventArgs e)
        {
            // Initiate Ping
            try
            {
                pingSender.SendAsync(IPList.getNextIP(), timeout, buffer, PingOptions, waiter);
            }
            catch(System.InvalidOperationException)
            {
                // Timeout while pinging most likely... wait a cycle
            }
            catch{ }
        }

        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            lock (ConnDetailsLock)
            {
                PingReply reply = e.Reply;
                
                
                DrawPing(reply);

#if DEBUG
                DebugPing(reply);
#endif
                if (ConnDetails.Count > MaxConnDetailsCount && MaxConnDetailsCount > 0)
                {
                    ConnDetails.RemoveAt(0);
                }
                if (reply.RoundtripTime >= 1)
                {
                    
                    if (reply.Status == IPStatus.Success && (ConnDetails.Count > 0 && ConnDetails.Last().Item2 == 0))
                    {
                        if(OfflineSignaled)
                            GoneOnline();
                    }
                }

                ConnDetails.Add(new Tuple<DateTime, long>(DateTime.Now, reply.RoundtripTime));
                if (ConnDetails.Count > 0 && OfflineThreshold() && !OfflineSignaled)
                {
                    GoneOffline();
                }
                

                
            }
        }


        // TODO: IMPLEMENT HOOKINS
        private void GoneOffline()
        {
#if DEBUG
            Console.WriteLine("GoneOffline()");
            //MessageBox.Show("GoneOffline();");
#endif
            OptionFocus();
            OptionSound(false);
            OfflineSignaled = true;
            OnlineSignaled = false;
        }

        // TODO: IMPLEMENT HOOKINS
        private void GoneOnline()
        {
#if DEBUG
            Console.WriteLine("GoneOnline()");
            //MessageBox.Show("GoneOnline();");
#endif
            OptionFocus();
            OptionSound(true);
            OfflineSignaled = false;
            OnlineSignaled = true;
        }

        private void OptionFocus()
        {
            if (checkBoxFocusOnConnChange.Checked)
            {
                this.Focus();
            }
        }

        private void OptionSound(bool nowOnline)
        {
            if (checkBoxAudioWarningOnConnChange.Checked)
            {
                if(!nowOnline)
                {
                    Morse.MorseCodeString("...");
                }
                else
                {
                    Morse.MorseCodeString("---");
                }
            }
        }

        private bool OfflineThreshold()
        {
            return FinalBatch(false, (int)numericUpDownDownDetectionThreshold.Value);   
        }

        private bool FinalBatch(bool StatusToCheckFor, int count, int lookat = 0)
        {
            if (count <= 0 || ConnDetails.Count < count || lookat < 0 || (lookat > 0 && lookat < count) || count > MaxConnDetailsCount || lookat > MaxConnDetailsCount)
            {
                return false;
            }

            if (lookat == 0)
            {
                lookat = count;
            }

            int online = 0;
            int offline = 0;
            

            for (int i = ConnDetails.Count - 1; (online+offline) < lookat; i--)
            {
                if ((ConnDetails[i].Item2 > 0)) // connected
                {
                    online++;
                }
                else
                {
                    offline++;
                }
            }
            if (StatusToCheckFor)
            {
                return online >= count;
            }
            else
            {
                return offline >= count;
            }
        }


        private void DebugPing(PingReply pr)
        {
            Console.WriteLine("Time: {3}, RTT: {0}, Dest: {1}, Success: {2}", pr.RoundtripTime, pr.Address.ToString(), pr.Status==IPStatus.Success, DateTime.Now);
        }

        private void DrawPing(PingReply pr)
        {
            // TODO: IMPLEMENT
            chart1.Series[0].Points.Add(pr.RoundtripTime);
            if (chart1.Series[0].Points.Count > 20)
                chart1.Series[0].Points.RemoveAt(0);
            changeYScala(chart1);
        }

        private void changeYScala(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            // start worst case
            double max = Double.MinValue;
            double min = Double.MaxValue;

            double xMin = chart.ChartAreas[0].AxisX.Minimum;
            double xMax = chart.ChartAreas[0].AxisX.Maximum;

            for (int i = 0; i < chart.Series.Count(); i++) // For each Series
            {
                foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint dp in chart.Series[i].Points)
                {
                    if (dp.XValue >= xMin && dp.XValue <= xMax)
                    {
                        min = Math.Min(min, dp.YValues[0]);
                        max = Math.Max(max, dp.YValues[0]);
                    }
                }
            }
            chart.ChartAreas[0].AxisY.Maximum = (Math.Ceiling((max / 10)) * 10);
            chart.ChartAreas[0].AxisY.Minimum = (Math.Floor((min / 10)) * 10);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
