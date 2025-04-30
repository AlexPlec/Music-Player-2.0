namespace MusicPlayer.customModules.AudioPlayer
{
    partial class TimeBarElement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBarTime = new TrackBar();
            songCurrentTime = new Label();
            songDuration = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarTime).BeginInit();
            SuspendLayout();
            // 
            // trackBarTime
            // 
            trackBarTime.Location = new Point(43, 3);
            trackBarTime.Name = "trackBarTime";
            trackBarTime.Size = new Size(104, 45);
            trackBarTime.TabIndex = 0;
            trackBarTime.TickStyle = TickStyle.None;
            // 
            // songCurrentTime
            // 
            songCurrentTime.AutoSize = true;
            songCurrentTime.Location = new Point(3, 3);
            songCurrentTime.Name = "songCurrentTime";
            songCurrentTime.Size = new Size(34, 15);
            songCurrentTime.TabIndex = 1;
            songCurrentTime.Text = "00:00";
            // 
            // songDuration
            // 
            songDuration.AutoSize = true;
            songDuration.Location = new Point(153, 3);
            songDuration.Name = "songDuration";
            songDuration.Size = new Size(34, 15);
            songDuration.TabIndex = 2;
            songDuration.Text = "00:00";
            // 
            // TimeBarElements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(songDuration);
            Controls.Add(songCurrentTime);
            Controls.Add(trackBarTime);
            Name = "TimeBarElements";
            Size = new Size(190, 30);
            ((System.ComponentModel.ISupportInitialize)trackBarTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarTime;
        private Label songCurrentTime;
        private Label songDuration;
    }
}
