using MySlideShow.Models;
using MySlideShow.Services;

namespace MySlideShow
{
    public partial class FrmMySlideShow : Form
    {
        private Properties _props;
        private List<string> _files;
        private ViewService _vs;
        private int _index = 0;
        public FrmMySlideShow()
        {
            InitializeComponent();

            // new PropertiesService("properties.json").Save(new Properties());

            _props = new PropertiesService("properties.json").Load();
            _files = new FileService().GetFiles(_props.PicturePath, _props.IncludeSubdirectories).OrderBy(s => s).ToList();
            _vs = new ViewService(pbSlide.Size);
            ShowSlide();

            // Set Debug true if you need the filename of the image.  For example, if you need to look for slides that need to be rotated.
            txtFilePath.Visible = _props.Debug;
        }

        private void ShowSlide()
        {
            var fn = _files.ElementAt(_index);
            pbSlide.Image = _vs.GetSlide(fn);
            txtFilePath.Text = fn;
        }

        private void pbSlide_SizeChanged(object sender, EventArgs e)
        {
            _vs = new ViewService(pbSlide.Size);
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
