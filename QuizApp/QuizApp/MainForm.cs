using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp.Properties;

namespace QuizApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            countdownTimer.Start();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            countdownTimer.Pause();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                countdownTimer.Reset(TimeSpan.Parse("0:" + startTimeTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.StartTimeParseErrorString);
            }
        }
    }
}
