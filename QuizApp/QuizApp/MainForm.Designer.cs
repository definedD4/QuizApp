namespace QuizApp
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
            this.startBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.countdownTimer = new QuizApp.CountdownTimer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(13, 60);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(197, 59);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Заново";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(105, 59);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 3;
            this.pauseBtn.Text = "Пауза";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(13, 106);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(154, 20);
            this.startTimeTextBox.TabIndex = 4;
            // 
            // countdownTimer
            // 
            this.countdownTimer.AlertTime = System.TimeSpan.Parse("00:00:10");
            this.countdownTimer.BeepInterval = System.TimeSpan.Parse("00:00:01");
            this.countdownTimer.BeepTime = System.TimeSpan.Parse("00:00:10");
            this.countdownTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.countdownTimer.EnableAlert = true;
            this.countdownTimer.EnableBeep = true;
            this.countdownTimer.Location = new System.Drawing.Point(0, 0);
            this.countdownTimer.Name = "countdownTimer";
            this.countdownTimer.Size = new System.Drawing.Size(284, 53);
            this.countdownTimer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Начальное время в формате: мм:сс:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.countdownTimer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CountdownTimer countdownTimer;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.Label label1;
    }
}