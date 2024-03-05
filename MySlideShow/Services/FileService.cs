namespace MySlideShow.Services
{
    internal class FileService
    {
        public List<string> GetFiles(string basepath)
        {
            var result = new List<string>();
            var dirInfo = new DirectoryInfo(basepath);

            foreach (var f in dirInfo.GetFiles())
            {
                result.Add(f.FullName);
            }

            return result;
        }
    }
}
