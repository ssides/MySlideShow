using System.Text;

namespace MySlideShow.Services
{
    internal class ReviewViewService : ViewBase
    {
        private Size _size;
        private List<string> _tempFiles;
        private string _tempPath;
        private List<string> _messages;
        private Bitmap _404Image;
        private int _messagesHeight;

        public ReviewViewService(Size viewSize, string tempPath, List<string> tempFiles, int messagesHeight)
        {
            _size = viewSize;
            _tempFiles = tempFiles;
            _tempPath = tempPath;
            _messages = new List<string>();
            _404Image = Get404Image(_size);
            _messagesHeight = messagesHeight;
        }

        internal Bitmap GetImage(string path)
        {
            var display = new Bitmap(_size.Width, _size.Height);

            using (var gfx = Graphics.FromImage(display))
            {
                FillColor(_size, gfx, Color.White);
                var tempFN = GetTempFileName(path);
                _tempFiles.Add(tempFN);
                try
                {
                    File.Copy(path, tempFN, true);
                    DrawImageForDisplay(gfx, tempFN);
                }
                catch
                {
                    Draw404(gfx);
                }
            }

            return display;
        }

        internal void Rotate(string path)
        {
            var tempFN = GetTempFileName(path);
            _tempFiles.Add(tempFN);
            File.Copy(path, tempFN, true);
            var img = new Bitmap(tempFN);
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            img.Save(path);
        }

        private void Draw404(Graphics gfx)
        {
            var displayRect = GetImageRectangle(_size, _404Image.Size);
            gfx.DrawImage(_404Image, displayRect);
        }

        private string GetTempFileName(string path)
        {
            var ext = Path.GetExtension(path);
            var g = Guid.NewGuid().ToString();
            var fn = $"srs_{g}{ext}";
            return Path.Combine(_tempPath, fn);
        }

        private void DrawImageForDisplay(Graphics gfx, string path)
        {
            var img = new Bitmap(path);
            var displayRect = GetImageRectangle(_size, img.Size);
            gfx.DrawImage(img, displayRect);
        }

        internal string AddMessage(string message)
        {
            _messages.Add(message);
            return LastMessages(_messagesHeight);
        }

        private string LastMessages(int cnt)
        {
            var msgs = _messages.TakeLast(cnt).ToList();
            var result = new StringBuilder();
            foreach (var msg in msgs)
            {
                result.AppendLine(msg.ToString());
            }
            return result.ToString();
        }

    }
}
