namespace MySlideShow.Services
{
    internal class ViewService
    {
        private Size _size;

        internal ViewService(Size size)
        {
            _size = size;
        }

        internal Bitmap GetSlide(string path)
        {
            var img = new Bitmap(_size.Width, _size.Height);
            var gfx = Graphics.FromImage(img);
            FillColor(gfx, Color.White);
            DrawSlide(gfx, path);

            return img;
        }

        private void DrawSlide(Graphics gfx, string path)
        {
            var img = new Bitmap(path);
            var displayRect = GetImageRectangle(img.Size);
            gfx.DrawImage(img, displayRect);
        }

        private Rectangle GetImageRectangle(Size imgSize)
        {
            var displayRatio = (double)_size.Width / _size.Height;
            var imgRatio = (double)imgSize.Width / imgSize.Height;
            Size s = new Size();
            int locX = 0;
            int locY = 0;

            if ((imgRatio < 1.0) || (displayRatio > imgRatio))
            {
                // the image is (portrait) or (landscape and the display is wider than the image)
                s.Height = _size.Height;
                s.Width = (int)(_size.Height * imgRatio);
                locX = (_size.Width - s.Width) / 2;
            }
            else
            {
                // the image is landscape and the display is narrower than the image.
                s.Width = _size.Width;
                s.Height = (int)(_size.Width * (1.0 / imgRatio));
                locY = (_size.Height - s.Height) / 2;
            }

            return new Rectangle(new Point(locX, locY), s);
        }

        private void FillColor(Graphics gfx, Color color)
        {
            using (var br = new SolidBrush(color))
            {
                gfx.FillRectangle(br, new Rectangle(new Point(0, 0), _size));
            }
        }
    }
}
