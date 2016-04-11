using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp.Properties;

namespace QuizApp
{
    public partial class CountdownTimer : UserControl
    {
        private Timer m_Timer;
        private Stopwatch m_Stopwatch;
        private TimeSpan m_TotalTime;

        private TimeSpan m_LastBeepTime;

        public CountdownTimer()
        {
            InitializeComponent();

            m_Timer = new Timer {Interval = 70};
            m_Timer.Tick += (sender, args) =>
            {
                TimeLeft = m_TotalTime - m_Stopwatch.Elapsed;
                if (TimeLeft <= TimeSpan.Zero)
                {
                    TimeLeft = TimeSpan.Zero;

                    if (BeepAtEnd)
                    {
                        new SoundPlayer(Resources.LongBeep).Play();
                    }

                    Pause();

                    TimeElapsed?.Invoke(this, new EventArgs());
                }

                UpdateTimeShown();
            };
            m_Stopwatch = new Stopwatch();
        }

        public TimeSpan TimeLeft { get; private set; }
        public bool Running { get; private set; }

        public bool EnableAlert { get; set; } = true;
        public TimeSpan AlertTime { get; set; } = TimeSpan.FromSeconds(10);

        public bool EnableBeep { get; set; } = true;
        public TimeSpan BeepTime { get; set; } = TimeSpan.FromSeconds(10);
        public TimeSpan BeepInterval { get; set; } = TimeSpan.FromSeconds(1);
        public bool BeepAtEnd { get; set; } = true;

        public void Start()
        {
            if (!Running)
            {
                m_Timer.Start();
                m_Stopwatch.Start();
                Running = true;
            }
        }

        public void Pause()
        {
            if (Running)
            {
                m_Timer.Stop();
                m_Stopwatch.Stop();
                Running = false;
            }
        }

        public void Reset(TimeSpan startTime)
        {
            m_Timer.Stop();
            Running = false;

            m_TotalTime = startTime;
            TimeLeft = startTime;

            m_Stopwatch.Reset();

            m_LastBeepTime = TimeSpan.MaxValue;

            timeProgressBar.Maximum = (int) m_TotalTime.TotalMilliseconds;

            UpdateTimeShown();
        }

        private void UpdateTimeShown()
        {
            timeLabel.Text = $"{TimeLeft.Minutes.ToString("D2")}:" +
                                             $"{TimeLeft.Seconds.ToString("D2")}." +
                                             $"{((int)Math.Round((double)TimeLeft.Milliseconds / 10, 2)).ToString("D2")}";
            timeProgressBar.Value = (int)TimeLeft.TotalMilliseconds;

            if (EnableAlert && TimeLeft < AlertTime)
            {
                timeLabel.ForeColor = Color.Red;
                timeLabel.Font = new Font(timeLabel.Font, FontStyle.Bold);
            }
            else
            {
                timeLabel.ForeColor = Color.Black;
                timeLabel.Font = new Font(timeLabel.Font, FontStyle.Regular);
            }

            if (EnableBeep && TimeLeft < BeepTime && m_LastBeepTime - TimeLeft > BeepInterval)
            {
                new SoundPlayer(Resources.ShortBeep).Play();
                m_LastBeepTime = TimeLeft;
            }
        }

        public event EventHandler TimeElapsed;
    }
}
