namespace MusicPlayer.customModules.AudioPlayer
{
    partial class VolumeElement
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
            volumeLevel = new TrackBar();
            volumeLevelValue = new Label();
            ((System.ComponentModel.ISupportInitialize)volumeLevel).BeginInit();
            SuspendLayout();
            // 
            // volumeLevel
            // 
            volumeLevel.Location = new Point(3, 3);
            volumeLevel.Maximum = 100;
            volumeLevel.Name = "volumeLevel";
            volumeLevel.Size = new Size(104, 45);
            volumeLevel.TabIndex = 0;
            volumeLevel.TickStyle = TickStyle.None;
            volumeLevel.Value = 100;
            // 
            // volumeLevelValue
            // 
            volumeLevelValue.AutoSize = true;
            volumeLevelValue.Location = new Point(113, 3);
            volumeLevelValue.Name = "volumeLevelValue";
            volumeLevelValue.Size = new Size(25, 15);
            volumeLevelValue.TabIndex = 1;
            volumeLevelValue.Text = "100";
            // 
            // VolumeElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(volumeLevelValue);
            Controls.Add(volumeLevel);
            Name = "VolumeElement";
            Size = new Size(140, 35);
            ((System.ComponentModel.ISupportInitialize)volumeLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar volumeLevel;
        private Label volumeLevelValue;
    }
}
