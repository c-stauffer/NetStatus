using System;
using System.Drawing;
using System.Text;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace NetStatus
{
    public partial class MainForm : Form
    {
        private bool _started;
        private int _total, _successes, _failures;
        private DateTime _startDateTime;

        private const string _host = "google.com";
        private const int _timeout = 3000;
        private readonly byte[] _buffer = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        private readonly PingOptions _pingOpts = new PingOptions(64, true);
        private readonly Ping _pinger;

        public MainForm()
        {
            _pinger = new Ping();
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            _started = !_started;
            if (_started)
            {
                btnStartStop.Text = "Stop";
                _startDateTime = DateTime.Now;
                lblStartDateTime.Text = _startDateTime.ToString();

                _pinger.SendAsync(_host, _timeout, _buffer, _pingOpts);
                pingTimer.Start();
            }
            else
            {
                pingTimer.Stop();
                btnStartStop.Text = "Start";
                lblStartDateTime.Text = "Not started";
            }
        }

        private void btnResetStats_Click(object sender, EventArgs e)
        {
            _successes = 0;
            _failures = 0;
            lblLastFailure.Text = string.Empty;
            lblFailureRate.Text = "--%";
        }

        private void pingWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) => e.Result = _pinger.Send(_host, _timeout, _buffer, _pingOpts);

        private void pingWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            _total++;
            lblPingCount.Text = _total.ToString();
            if (((PingReply)e.Result).Status != IPStatus.Success)
            {
                _failures++;
                lblLastFailure.Text = DateTime.Now.ToString();
                BackColor = Color.DarkRed;
                LogErr(DateTime.Now);
            }
            else
            {
                _successes++;
                BackColor = Color.Black;
            }

            if (_successes == 0)
                lblFailureRate.Text = "100%";
            else
            {
                var totalPct = (float)_failures / (_successes + _failures);
                var minutesRun = (DateTime.Now - _startDateTime).TotalMinutes;
                var failsPerMinute = _failures / minutesRun;
                lblFailureRate.Text = $"{totalPct.ToString("#0.##%")} -({failsPerMinute.ToString("####0.##")} per minute)";
            }
        }

        private void LogErr(DateTime errDate)
        {
            // log date and time of failed pings
            using (var sw = System.IO.File.AppendText("failures.txt"))
                sw.WriteLine(errDate.ToString());
        }

        private void pingTimer_Tick(object sender, EventArgs e)
        {
            if (!pingWorker.IsBusy)
                pingWorker.RunWorkerAsync();
        }
    }
}