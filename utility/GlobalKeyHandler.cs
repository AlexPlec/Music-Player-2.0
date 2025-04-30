using MusicPlayer.customModules.AudioPlayer;

namespace MusicPlayer.utility
{
    public class GlobalKeyHandler
    {
        private readonly Form mainForm;
        private readonly ButtonsElement buttonsElement;

        public GlobalKeyHandler(Form form, ButtonsElement buttons)
        {
            mainForm = form;
            buttonsElement = buttons;

            mainForm.KeyPreview = true;
            mainForm.KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (buttonsElement == null) return;

            switch (e.KeyCode)
            {
                case Keys.Space:
                    buttonsElement.TogglePlay();
                    e.Handled = true;
                    break;

                case Keys.Right:
                    buttonsElement.NextTrack();
                    e.Handled = true;
                    break;

                case Keys.Left:
                    buttonsElement.PreviousTrack();
                    e.Handled = true;
                    break;
            }
        }
    }
}
