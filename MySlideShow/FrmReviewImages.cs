using MySlideShow.Models;
using MySlideShow.Services;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MySlideShow
{
    public partial class FrmReviewImages : Form
    {
        private AppSettings _settings;
        private List<string> _tempFiles;
        private string _tempPath;
        private List<ImageFile> _reviewedFiles;
        private ImageFile _reviewingFile;
        private ReviewViewService _vs;
        private FileService _fs;
        private List<string> _files;

        public FrmReviewImages(Form owner, AppSettings settings)
        {
            InitializeComponent();
            Owner = owner;

            _settings = settings;
            _tempFiles = new List<string>();
            _tempPath = Path.GetTempPath();
            _reviewedFiles = new List<ImageFile>();
            _reviewingFile = new ImageFile() { FullPath = "", HasBeenReviewed = true };
            _vs = new ReviewViewService(pbImage.Size, _tempPath, _tempFiles, GetNumLines(txtMessages.Size.Height));
            _fs = new FileService();
            _files = _fs.GetFiles(_settings.PicturePath, _settings.IncludeSubdirectories).OrderBy(s => s).ToList();
            _reviewedFiles = new DataService().GetReviewedFiles(_fs.GetReviewedFiles(App.ReviewedFiles), _files);
            ShowImage("");
            var c = _reviewedFiles.Count(c => !c.HasBeenReviewed);
            txtMessages.Text = _vs.AddMessage($"{c} file(s) have not been reviewed.");
            btnDelete.Visible = btnDelete.Enabled = _settings.AllowDelete;
        }

        private int GetNumLines(int h)
        {
            Size sizeOfOneLine = TextRenderer.MeasureText("one line", txtMessages.Font);
            return h / sizeOfOneLine.Height;
        }

        private void ShowImage(string message)
        {
            _reviewingFile = _reviewedFiles.OrderBy(i => i.FullPath).FirstOrDefault(f => !f.HasBeenReviewed);

            if (_reviewingFile != null)
            {
                pbImage.Image = _vs.GetImage(_reviewingFile.FullPath);
                txtPath.Text = _reviewingFile.FullPath;
                if (!string.IsNullOrEmpty(message))
                {
                    txtMessages.Text = _vs.AddMessage(message);
                }
            }
            else
            {
                _reviewingFile = new ImageFile("");
                txtMessages.Text = _vs.AddMessage("All files have been reviewed.");
            }
        }

        private void pbImage_SizeChanged(object sender, EventArgs e)
        {
            _vs = new ReviewViewService(pbImage.Size, _tempPath, _tempFiles, GetNumLines(txtMessages.Size.Height));
            ShowImage("");
        }

        private void FrmReviewImages_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fs.SaveReviewedFiles(App.ReviewedFiles, _reviewedFiles);
            _fs.TryDeleteTempFiles(_tempFiles);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(_reviewingFile.FullPath))
            {
                var result = _fs.DeleteFile(_reviewingFile.FullPath);
                if (!string.IsNullOrEmpty(result))
                {
                    txtMessages.Text = _vs.AddMessage(result);
                }

                ShowReviewedAndGetNext($"Deleted \"{_reviewingFile.FullPath}\"");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(_reviewingFile.FullPath))
            {
                ShowReviewedAndGetNext($"Saved \"{_reviewingFile.FullPath}\"");
            }
        }

        private void ShowReviewedAndGetNext(string message)
        {
            _reviewingFile.HasBeenReviewed = true;
            ShowImage(message);
        }
    }
}
