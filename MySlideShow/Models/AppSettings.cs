namespace MySlideShow.Models
{
    public class AppSettings
    {
        public string PicturePath { get; set; } = "";
        public bool ShowPath { get; set; } = false;
        public bool IncludeSubdirectories { get; set; } = false;
        public bool AllowDelete { get; set; } = false;
        public int AutoChangeSeconds { get; set; }
    }
}
