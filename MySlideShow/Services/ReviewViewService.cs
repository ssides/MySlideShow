using System.Text;

namespace MySlideShow.Services
{
    internal class ReviewViewService
    {
        private Size _size;
        private List<string> _tempFiles;
        private string _tempPath;
        private List<string> _messages;
        private Bitmap _404Image;
        private int _messagesHeight;

        public ReviewViewService(Size viewSize, string tempPath, List<string> tempFiles, int messagesHeight) {
            _size = viewSize;
            _tempFiles = tempFiles;
            _tempPath = tempPath;
            _messages = new List<string>();
            _404Image = View.Get404Image(_size);
            _messagesHeight = messagesHeight;
        }

        internal Bitmap GetImage(string path)
        {
            var display = new Bitmap(_size.Width, _size.Height);

            using (var gfx = Graphics.FromImage(display))
            {
                View.FillColor(_size, gfx, Color.White);
                var tempFN = GetTempFileName(path);
                _tempFiles.Add(tempFN);
                try
                {
                    File.Copy(path, tempFN, true);
                    DrawImage(gfx, tempFN);
                }
                catch
                {
                    Draw404(gfx);
                }
            }

            return display;
        }

        private void Draw404(Graphics gfx)
        {
            var displayRect = View.GetImageRectangle(_size, _404Image.Size);
            gfx.DrawImage(_404Image, displayRect);
        }

        private string GetTempFileName(string path)
        {
            var ext = Path.GetExtension(path);
            var g = Guid.NewGuid().ToString();
            var fn = $"srs_{g}{ext}";
            return Path.Combine(_tempPath, fn);
        }

        private void DrawImage(Graphics gfx, string path)
        {
            Bitmap img = new Bitmap(path);
            var displayRect = View.GetImageRectangle(_size, img.Size);
            gfx.DrawImage(img, displayRect);
        }
              
        internal string AddMessage(string message)
        {
            _messages.Add(message);
            return LastMessage(_messagesHeight);
        }

        private string LastMessage(int cnt)
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
