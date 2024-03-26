namespace MySlideShow.Models
{
    internal class ImageFile
    {
        public string FullPath { get; set; } = "";
        public bool HasBeenReviewed { get; set; } = false;
        public ImageFile(string filePath)
        {
            FullPath = filePath;
        }
        public ImageFile() { }
    }
}
