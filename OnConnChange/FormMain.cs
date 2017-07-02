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
        int timeout = 2000;
        AutoResetEvent waiter = new AutoResetEvent(false);
        PingOptions PingOptions = new PingOptions(64, true);
        private static int MaxConnDetailsCount = 128;
        private static List<Tuple<DateTime, long>> ConnDetails = new List<Tuple<DateTime, long>>(MaxConnDetailsCount);
        private static Object ConnDetailsLock = new Object();

        public FormMain()
        {
            InitializeComponent();
            pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);
            
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            timerInterval.Enabled = !timerInterval.Enabled;
            buttonStartStop.Text = timerInterval.Enabled ? "Stop" : "Start";
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
                ConnDetails.Add(new Tuple<DateTime, long>(DateTime.Now, reply.RoundtripTime));
                DebugPing(reply);

                if (ConnDetails.Count > MaxConnDetailsCount && MaxConnDetailsCount > 0)
                {
                    ConnDetails.RemoveAt(0);
                }
                if (reply.Status == IPStatus.Success)
                {
                    if (ConnDetails.Last().Item2 == 0) // TODO: CHANGE TO DETECTION THRESHOLD VALUE
                    {
                        GoneOnline();
                    }
                    Console.Beep();
                }
                else // Not connected or unsuccessful ping
                {
                    if (PacketlossThreshold())
                    {
                        GonePacketlossy();
                    }

                    if (OfflineThreshold())
                    {
                        GoneOffline();
                    }
                }
            }
        }

        private void GonePacketlossy()
        {
            //throw new NotImplementedException();
        }

        private void GoneOffline()
        {
            Console.WriteLine("GoneOffline()");
            OptionFocus();
            OptionSound(false);
        }

        private void GoneOnline()
        {
            Console.WriteLine("GoneOnline()");
            OptionFocus();
            OptionSound(true);
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
                    Morse.MorseCodeString("...---...");
                }
                else
                {
                    Morse.MorseCodeString("---------");
                }
            }
        }

        private bool OfflineThreshold()
        {
            return finalBatch(false, (int)numericUpDownDownDetectionThreshold.Value);
            // TODO: IMPLEMENT
            
        }

        private bool finalBatch(bool StatusToCheckFor, int count, int lookat = 0)
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

        private bool PacketlossThreshold()
        {
            return finalBatch(false, (int)numericUpDownPacketLossThreshold.Value);
        }

        private void DebugPing(PingReply pr)
        {
            Console.WriteLine("Time: {3}, RTT: {0}, Dest: {1}, Success: {2}", pr.RoundtripTime, pr.Address.ToString(), pr.Status==IPStatus.Success, DateTime.Now);
        }
    }
}
