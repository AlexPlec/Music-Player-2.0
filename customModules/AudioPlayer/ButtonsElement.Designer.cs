namespace MusicPlayer.customModules.AudioPlayer
{
    partial class ButtonsElement
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
            btnPlay = new Button();
            btnRepeat = new Button();
            btnShuffle = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(165, 3);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnRepeat
            // 
            btnRepeat.Location = new Point(327, 3);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Size = new Size(75, 23);
            btnRepeat.TabIndex = 1;
            btnRepeat.Text = "Repeat";
            btnRepeat.UseVisualStyleBackColor = true;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(3, 3);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(75, 23);
            btnShuffle.TabIndex = 2;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(84, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(246, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // ButtonsElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnShuffle);
            Controls.Add(btnRepeat);
            Controls.Add(btnPlay);
            Name = "ButtonsElement";
            Size = new Size(405, 30);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button btnRepeat;
        private Button btnShuffle;
        private Button btnPrevious;
        private Button btnNext;
    }
}
