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

                countdownTimer.Reset(TimeSpan.FromMinutes(1));
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

            countdownTimer.Reset(TimeSpan.FromMinutes(1));

            stateLabel.Text = "";

            runBtn.Text = Resources.RunText;
            resetBtn.Enabled = false;
            resetBtn.Text = Resources.ResetText;
            runBtn.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            countdownTimer.Reset(TimeSpan.FromMinutes(1));
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
    }
}
