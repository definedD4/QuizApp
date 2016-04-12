using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp.Properties;

namespace QuizApp
{
    public enum GameState
    {
        Awaiting,
        Running,
        Answering,
        OutOfTime
    }

    public partial class MainForm : Form
    {
        public const Keys Player1AnsKey = Keys.Insert;
        public const Keys Player2AnsKey = Keys.PageUp;
        public const Keys Player3AnsKey = Keys.Home;

        private GameState m_State;

        public MainForm()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            if (m_State == GameState.Awaiting || m_State == GameState.OutOfTime)
            {
                m_State = GameState.Running;

                ResetTimer();
                countdownTimer.Start();

                stateLabel.Text = "";

                new SoundPlayer(Resources.LongBeep).Play();

                runBtn.Text = Resources.RunText;
                runBtn.Enabled = false;
                resetBtn.Text = Resources.ResetText;
                resetBtn.Enabled = true;
            }
            else if (m_State == GameState.Answering)
            {
                m_State = GameState.Running;

                stateLabel.Text = "";

                countdownTimer.Start();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            m_State = GameState.Awaiting;

            ResetTimer();

            stateLabel.Text = "";

            runBtn.Text = Resources.RunText;
            resetBtn.Enabled = false;
            resetBtn.Text = Resources.ResetText;
            runBtn.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Player1AnsKey ||
                e.KeyCode == Player2AnsKey || e.KeyCode == Player3AnsKey)
            {
                string teamName = "";
                if (e.KeyCode == Player1AnsKey)
                {
                    teamName = team1Tb.Text;
                }
                else if (e.KeyCode == Player2AnsKey)
                {
                    teamName = team2Tb.Text;
                }
                else if (e.KeyCode == Player3AnsKey)
                {
                    teamName = team3Tb.Text;
                }

                if (m_State == GameState.Running)
                {
                    m_State = GameState.Answering;

                    countdownTimer.Pause();

                    new SoundPlayer(Resources.ShortBeep).Play();

                    stateLabel.Text = $"Команда {teamName} отвечает.";

                    runBtn.Text = Resources.ContinueText;
                    runBtn.Enabled = true;

                    resetBtn.Text = Resources.StopText;
                    resetBtn.Enabled = true;

                    e.Handled = true;
                }
                else if (m_State == GameState.Awaiting && falseStartCb.Checked)
                {
                    MessageBox.Show($"Команда {teamName} нажала кнопку раньше времени.");
                }
            } 
        }

        private void countdownTimer_TimeElapsed(object sender, EventArgs e)
        {
            if (m_State == GameState.Running)
            {
                m_State = GameState.OutOfTime;

                stateLabel.Text = Resources.OutOfTimeText;

                runBtn.Text = Resources.RunText;
                resetBtn.Enabled = true;
                resetBtn.Text = Resources.ResetText;
                runBtn.Enabled = true;
            }
        }

        private void timeSTb_Leave(object sender, EventArgs e)
        {
            double seconds, minutes;
            if(!double.TryParse(timeSTb.Text, out seconds)){
                seconds = 0;
            }
            if (!double.TryParse(timeMTb.Text, out minutes)){
                minutes = 1;
            }
            while (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }

            timeSTb.Text = seconds.ToString();
            timeMTb.Text = minutes.ToString();
        }

        private void ResetTimer()
        {
            double minutes = 1, seconds = 0;
            try
            {
                minutes = double.Parse(timeMTb.Text);
                seconds = double.Parse(timeSTb.Text);
            }
            catch(Exception e)
            {
                MessageBox.Show("Времмя введено в неверном формате.");
            }
            TimeSpan startTime = TimeSpan.FromSeconds(minutes * 60 + seconds);
            countdownTimer.Reset(startTime);
        }
    }
}
