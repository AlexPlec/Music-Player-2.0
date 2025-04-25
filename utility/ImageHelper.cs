using System.Drawing.Drawing2D;

namespace MusicPlayer.utils
{
    public static class ImageHelper
    {
        public static Bitmap ResizeImageKeepAspect(Image img, Size maxSize)
        {
            var ratioX = (double)maxSize.Width / img.Width;
            var ratioY = (double)maxSize.Height / img.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(img.Width * ratio);
            var newHeight = (int)(img.Height * ratio);

            var resized = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newWidth, newHeight);
            }

            return resized;
        }
    }
}