using MySlideShow.Models;
using MySlideShow.Services;

namespace MySlideShow
{
    public partial class FrmInit : Form
    {
        private AppSettings _appSettings;

        public FrmInit()
        {
            InitializeComponent();
            GetSettings();
        }

        private void GetSettings()
        {
            _appSettings = new AppSettingsService(App.AppSettings).Load();

            txtPath.Text = _appSettings.PicturePath;
            cbRecurseFolders.Checked = _appSettings.IncludeSubdirectories;
            cbShowPath.Checked = _appSettings.ShowPath;
            cbAllowDelete.Checked = _appSettings.AllowDelete;
        }

        private void btnSlideShow_Click(object sender, EventArgs e)
        {
            SaveSettings();

            try
            {
                new FrmMySlideShow(this, _appSettings).ShowDialog();
            }
            catch (Exception ex)
            {
                new FrmError(this, ex.Message).ShowDialog();
            }
        }

        private void btnReviewFiles_Click(object sender, EventArgs e)
        {
            SaveSettings();

            try
            {
                new FrmReviewImages(this, _appSettings).ShowDialog();
            }
            catch (Exception ex)
            {
                new FrmError(this, ex.Message).ShowDialog();
            }
        }

        private void FrmInit_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            _appSettings = new AppSettings() { PicturePath = txtPath.Text, IncludeSubdirectories = cbRecurseFolders.Checked, ShowPath = cbShowPath.Checked, AllowDelete = cbAllowDelete.Checked };
            new AppSettingsService(App.AppSettings).Save(_appSettings);
        }

        private void btnClearReviewedFiles_Click(object sender, EventArgs e)
        {
            new FileService().SaveReviewedFiles(App.ReviewedFiles, new List<ImageFile>());
        }

    }
}
