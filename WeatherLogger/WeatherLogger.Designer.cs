namespace WeatherLogger
{
    partial class WeatherLogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherLogger));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.sensitivityTxt = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ratioChk = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputTrk = new System.Windows.Forms.TrackBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.VindTimer = new System.Windows.Forms.Timer(this.components);
            this.RainTimer = new System.Windows.Forms.Timer(this.components);
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTrk)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.sensitivityTxt);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.ratioChk);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.inputTrk);
            this.GroupBox1.Location = new System.Drawing.Point(16, 15);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(549, 110);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Weather Station:";
            // 
            // sensitivityTxt
            // 
            this.sensitivityTxt.Location = new System.Drawing.Point(111, 60);
            this.sensitivityTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sensitivityTxt.Name = "sensitivityTxt";
            this.sensitivityTxt.ReadOnly = true;
            this.sensitivityTxt.Size = new System.Drawing.Size(100, 22);
            this.sensitivityTxt.TabIndex = 17;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(13, 41);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(55, 62);
            this.PictureBox1.TabIndex = 7;
            this.PictureBox1.TabStop = false;
            // 
            // ratioChk
            // 
            this.ratioChk.AutoSize = true;
            this.ratioChk.Location = new System.Drawing.Point(397, 57);
            this.ratioChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ratioChk.Name = "ratioChk";
            this.ratioChk.Size = new System.Drawing.Size(101, 21);
            this.ratioChk.TabIndex = 14;
            this.ratioChk.Text = "Ratiometric";
            this.ratioChk.UseVisualStyleBackColor = true;
            this.ratioChk.CheckedChanged += new System.EventHandler(this.ratioChk_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Input Sensitivity:";
            // 
            // inputTrk
            // 
            this.inputTrk.Location = new System.Drawing.Point(227, 41);
            this.inputTrk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTrk.Name = "inputTrk";
            this.inputTrk.Size = new System.Drawing.Size(139, 56);
            this.inputTrk.TabIndex = 15;
            this.inputTrk.Scroll += new System.EventHandler(this.inputTrk_Scroll);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // VindTimer
            // 
            this.VindTimer.Enabled = true;
            this.VindTimer.Interval = 6000;
            this.VindTimer.Tick += new System.EventHandler(this.VindTimer_Tick);
            // 
            // RainTimer
            // 
            this.RainTimer.Enabled = true;
            this.RainTimer.Interval = 60000;
            this.RainTimer.Tick += new System.EventHandler(this.RainTimer_Tick);
            // 
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 1500;
            this.Updater.Tick += new System.EventHandler(this.Updater_Tick);
            // 
            // WeatherLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 146);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WeatherLogger";
            this.Text = "WeatherLogger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTrk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox sensitivityTxt;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.CheckBox ratioChk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar inputTrk;
        internal System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer VindTimer;
        private System.Windows.Forms.Timer RainTimer;
        private System.Windows.Forms.Timer Updater;
    }
}

