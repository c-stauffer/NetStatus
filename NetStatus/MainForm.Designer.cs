namespace NetStatus
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
            this.components = new System.ComponentModel.Container();
            this.lblStartDateTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFailureRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLastFailure = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnResetStats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPingCount = new System.Windows.Forms.Label();
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.pingWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblStartDateTime
            // 
            this.lblStartDateTime.AutoSize = true;
            this.lblStartDateTime.Location = new System.Drawing.Point(85, 13);
            this.lblStartDateTime.Name = "lblStartDateTime";
            this.lblStartDateTime.Size = new System.Drawing.Size(0, 20);
            this.lblStartDateTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Failure Rate:";
            // 
            // lblFailureRate
            // 
            this.lblFailureRate.AutoSize = true;
            this.lblFailureRate.Location = new System.Drawing.Point(123, 65);
            this.lblFailureRate.Name = "lblFailureRate";
            this.lblFailureRate.Size = new System.Drawing.Size(0, 20);
            this.lblFailureRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Failure:";
            // 
            // lblLastFailure
            // 
            this.lblLastFailure.AutoSize = true;
            this.lblLastFailure.Location = new System.Drawing.Point(123, 116);
            this.lblLastFailure.Name = "lblLastFailure";
            this.lblLastFailure.Size = new System.Drawing.Size(0, 20);
            this.lblLastFailure.TabIndex = 5;
            // 
            // btnStartStop
            // 
            this.btnStartStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartStop.Location = new System.Drawing.Point(17, 186);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(164, 52);
            this.btnStartStop.TabIndex = 6;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnResetStats
            // 
            this.btnResetStats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResetStats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResetStats.Location = new System.Drawing.Point(17, 259);
            this.btnResetStats.Name = "btnResetStats";
            this.btnResetStats.Size = new System.Drawing.Size(164, 52);
            this.btnResetStats.TabIndex = 7;
            this.btnResetStats.Text = "Reset Stats";
            this.btnResetStats.UseVisualStyleBackColor = true;
            this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Started:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ping Count:";
            // 
            // lblPingCount
            // 
            this.lblPingCount.AutoSize = true;
            this.lblPingCount.Location = new System.Drawing.Point(116, 352);
            this.lblPingCount.Name = "lblPingCount";
            this.lblPingCount.Size = new System.Drawing.Size(0, 20);
            this.lblPingCount.TabIndex = 9;
            // 
            // pingTimer
            // 
            this.pingTimer.Interval = 3000;
            this.pingTimer.Tick += new System.EventHandler(this.pingTimer_Tick);
            // 
            // pingWorker
            // 
            this.pingWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.pingWorker_DoWork);
            this.pingWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.pingWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(432, 420);
            this.Controls.Add(this.lblPingCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetStats);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblLastFailure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFailureRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStartDateTime);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "NetStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStartDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFailureRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLastFailure;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnResetStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPingCount;
        private System.Windows.Forms.Timer pingTimer;
        private System.ComponentModel.BackgroundWorker pingWorker;
    }
}

