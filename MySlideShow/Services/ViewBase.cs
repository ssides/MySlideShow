namespace MySlideShow.Services
{
    internal class ViewBase
    {
        public Rectangle GetImageRectangle(Size viewSize, Size imgSize)
        {
            var displayRatio = (double)viewSize.Width / viewSize.Height;
            var imgRatio = (double)imgSize.Width / imgSize.Height;
            Size s = new Size();
            int locX = 0;
            int locY = 0;

            if ((imgRatio < 1.0) || (displayRatio > imgRatio))
            {
                // the image is (portrait) or (landscape and the display is wider than the image)
                s.Height = viewSize.Height;
                s.Width = (int)(viewSize.Height * imgRatio);
                locX = (viewSize.Width - s.Width) / 2;
            }
            else
            {
                // the image is landscape and the display is narrower than the image.
                s.Width = viewSize.Width;
                s.Height = (int)(viewSize.Width * (1.0 / imgRatio));
                locY = (viewSize.Height - s.Height) / 2;
            }

            return new Rectangle(new Point(locX, locY), s);
        }

        public Bitmap Get404Image(Size viewSize)
        {
            var img = new Bitmap(500, 800);

            using (var gfx = Graphics.FromImage(img))
            {
                FillColor(viewSize, gfx, Color.White);
                using (var p = new Pen(Color.Black))
                {
                    gfx.DrawRectangle(p, new Rectangle(new Point(80, 200), new Size(49, 79)));
                }
                using (var br = new SolidBrush(Color.Red))
                {
                    var f = FontService.GetFont(new Models.Font { Name = "Arial", Size = 20, Style = "Bold" });
                    gfx.DrawString("X", f, br, new PointF(90, 223));
                }
            }

            return img;
        }

        public void FillColor(Size viewSize, Graphics gfx, Color color)
        {
            using (var br = new SolidBrush(color))
            {
                gfx.FillRectangle(br, new Rectangle(new Point(0, 0), viewSize));
            }
        }

    }
}
