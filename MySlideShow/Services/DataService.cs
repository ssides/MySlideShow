using MySlideShow.Models;

namespace MySlideShow.Services
{
    internal class DataService
    {
        internal List<ImageFile> GetReviewedFiles(List<ImageFile> completedFiles, List<string> files)
        {
            var ret = new List<ImageFile>();

            foreach (var filePath in files)
            {
                var f = completedFiles.FirstOrDefault(f => f.FullPath == filePath);

                if (f != null)
                {
                    ret.Add(f);
                }
                else
                {
                    ret.Add(new ImageFile(filePath));
                }
            }

            return ret;
        }
    }
}
