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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.team3Tb = new System.Windows.Forms.TextBox();
            this.team2Tb = new System.Windows.Forms.TextBox();
            this.team1Tb = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.falseStartCb = new System.Windows.Forms.CheckBox();
            this.countdownTimer = new QuizApp.CountdownTimer();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.team3Tb);
            this.groupBox1.Controls.Add(this.team2Tb);
            this.groupBox1.Controls.Add(this.team1Tb);
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команды";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Команда 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Команда 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Команда 1:";
            // 
            // team3Tb
            // 
            this.team3Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.team3Tb.Location = new System.Drawing.Point(76, 72);
            this.team3Tb.Name = "team3Tb";
            this.team3Tb.Size = new System.Drawing.Size(269, 20);
            this.team3Tb.TabIndex = 2;
            // 
            // team2Tb
            // 
            this.team2Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.team2Tb.Location = new System.Drawing.Point(76, 46);
            this.team2Tb.Name = "team2Tb";
            this.team2Tb.Size = new System.Drawing.Size(269, 20);
            this.team2Tb.TabIndex = 1;
            // 
            // team1Tb
            // 
            this.team1Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.team1Tb.Location = new System.Drawing.Point(76, 19);
            this.team1Tb.Name = "team1Tb";
            this.team1Tb.Size = new System.Drawing.Size(269, 20);
            this.team1Tb.TabIndex = 0;
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.Location = new System.Drawing.Point(12, 102);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(660, 39);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(3, 3);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(93, 23);
            this.runBtn.TabIndex = 3;
            this.runBtn.Text = "Запуск";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.Enabled = false;
            this.resetBtn.Location = new System.Drawing.Point(198, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(93, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Заново";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.runBtn);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Location = new System.Drawing.Point(194, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 35);
            this.panel1.TabIndex = 5;
            // 
            // falseStartCb
            // 
            this.falseStartCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.falseStartCb.AutoSize = true;
            this.falseStartCb.Location = new System.Drawing.Point(382, 369);
            this.falseStartCb.Name = "falseStartCb";
            this.falseStartCb.Size = new System.Drawing.Size(91, 17);
            this.falseStartCb.TabIndex = 6;
            this.falseStartCb.Text = "Фальшстарт";
            this.falseStartCb.UseVisualStyleBackColor = true;
            // 
            // countdownTimer
            // 
            this.countdownTimer.AlertTime = System.TimeSpan.Parse("00:00:10");
            this.countdownTimer.BeepAtEnd = true;
            this.countdownTimer.BeepInterval = System.TimeSpan.Parse("00:00:01");
            this.countdownTimer.BeepTime = System.TimeSpan.Parse("00:00:10");
            this.countdownTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.countdownTimer.EnableAlert = true;
            this.countdownTimer.EnableBeep = true;
            this.countdownTimer.Location = new System.Drawing.Point(0, 0);
            this.countdownTimer.Margin = new System.Windows.Forms.Padding(10);
            this.countdownTimer.Name = "countdownTimer";
            this.countdownTimer.Size = new System.Drawing.Size(684, 92);
            this.countdownTimer.TabIndex = 0;
            this.countdownTimer.TimeElapsed += new System.EventHandler(this.countdownTimer_TimeElapsed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 410);
            this.Controls.Add(this.falseStartCb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.countdownTimer);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CountdownTimer countdownTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox team3Tb;
        private System.Windows.Forms.TextBox team2Tb;
        private System.Windows.Forms.TextBox team1Tb;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox falseStartCb;
    }
}