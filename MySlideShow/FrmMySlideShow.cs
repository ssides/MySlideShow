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
        private int _currentSlideSeconds = 0;

        public FrmMySlideShow(Form owner, AppSettings settings)
        {
            InitializeComponent();

            _settings = settings;
            _files = new FileService().GetFiles(_settings.PicturePath, _settings.IncludeSubdirectories).OrderBy(f => f).ToList();
            _vs = new SlideShowViewService(pbSlide.Size);
            _currentSlideSeconds = _settings.AutoChangeSeconds;
            txtFilePath.Visible = _settings.ShowPath;
            tmrAutoChange.Enabled = true;

            ShowSlide();
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

        private void tmrAutoChange_Tick(object sender, EventArgs e)
        {
            if (_settings.AutoChangeSeconds > 0)
            {
                if (_currentSlideSeconds <= 0)
                {
                    _index = _index < _files.Count - 1 ? _index + 1 : 0;
                    ShowSlide();
                    _currentSlideSeconds = _settings.AutoChangeSeconds;
                }
                else
                {
                    _currentSlideSeconds--;
                }
            }
        }

        private void FrmMySlideShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrAutoChange.Enabled = false;
        }
    }
}
