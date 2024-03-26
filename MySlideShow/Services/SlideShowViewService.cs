namespace MySlideShow.Services
{
    internal class SlideShowViewService
    {
        private Size _size;
        private Bitmap _404Image;

        internal SlideShowViewService(Size size)
        {
            _size = size;
            _404Image = View.Get404Image(_size);
        }

        internal Bitmap GetSlide(string path)
        {
            var img = new Bitmap(_size.Width, _size.Height);
            var gfx = Graphics.FromImage(img);
            FillColor(gfx, Color.White);

            try
            {
                DrawSlide(gfx, path);
            }
            catch
            {
                Draw404(gfx);
            }

            return img;
        }

        private void DrawSlide(Graphics gfx, string path)
        {
            var img = new Bitmap(path);
            var displayRect = View.GetImageRectangle(_size, img.Size);
            gfx.DrawImage(img, displayRect);
        }

        private void Draw404(Graphics gfx)
        {
            var displayRect = View.GetImageRectangle(_size, _404Image.Size);
            gfx.DrawImage(_404Image, displayRect);
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
