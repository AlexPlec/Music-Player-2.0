namespace MusicPlayer.customModules.AudioPlayer
{
    partial class AudioPlayer
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
            songInfoElement = new SongInfoElement();
            volumeElement = new VolumeElement();
            buttonsElement = new ButtonsElement();
            timeBarElement = new TimeBarElement();
            SuspendLayout();
            // 
            // songInfoElement
            // 
            songInfoElement.Location = new Point(3, 3);
            songInfoElement.Name = "songInfoElement";
            songInfoElement.Size = new Size(150, 60);
            songInfoElement.TabIndex = 0;
            // 
            // volumeElement
            // 
            volumeElement.Location = new Point(355, 40);
            volumeElement.Name = "volumeElement";
            volumeElement.Size = new Size(140, 35);
            volumeElement.TabIndex = 2;
            // 
            // buttonsElement
            // 
            buttonsElement.Location = new Point(159, 3);
            buttonsElement.Name = "buttonsElement";
            buttonsElement.Size = new Size(405, 30);
            buttonsElement.TabIndex = 3;
            // 
            // timeBarElement
            // 
            timeBarElement.Location = new Point(159, 40);
            timeBarElement.Name = "timeBarElement";
            timeBarElement.Size = new Size(190, 30);
            timeBarElement.TabIndex = 4;
            // 
            // AudioPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeBarElement);
            Controls.Add(buttonsElement);
            Controls.Add(volumeElement);
            Controls.Add(songInfoElement);
            Name = "AudioPlayer";
            Size = new Size(565, 70);
            ResumeLayout(false);
        }

        #endregion

        private SongInfoElement songInfoElement;
        private TimeBarElement timeBarElements;
        private VolumeElement volumeElement;
        private ButtonsElement buttonsElement;
        private TimeBarElement timeBarElement;
    }
}
