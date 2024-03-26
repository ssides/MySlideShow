using MySlideShow.Models;
using MySlideShow.Services;

namespace MySlideShow
{
    public partial class FrmMySlideShow : Form
    {
        private AppSettings _settings;
        private List<string> _files;
        private SlideShowViewService _vs;
        private int _index = 0;
        public FrmMySlideShow(Form owner, AppSettings settings)
        {
            InitializeComponent();

            _settings = settings;
            _files = new FileService().GetFiles(_settings.PicturePath, _settings.IncludeSubdirectories).OrderBy(s => s).ToList();
            _vs = new SlideShowViewService(pbSlide.Size);
            ShowSlide();

            // Set Debug true if you need the filename of the image.  For example, if you need to look for slides that need to be rotated.
            txtFilePath.Visible = _settings.ShowPath;
        }

        private void ShowSlide()
        {
            var fn = _files.ElementAt(_index);
            pbSlide.Image = _vs.GetSlide(fn);
            txtFilePath.Text = fn;
        }

        private void pbSlide_SizeChanged(object sender, EventArgs e)
        {
            _vs = new SlideShowViewService(pbSlide.Size);
            ShowSlide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_index < _files.Count - 1)
            {
                _index++;
                ShowSlide();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_index > 0)
            {
                _index--;
                ShowSlide();
            }
        }
    }
}
