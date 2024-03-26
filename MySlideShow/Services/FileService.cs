namespace MySlideShow.Services
{
    internal class FileService
    {
        private List<string> _validExtensions = new List<string>() { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
        private List<string> _files;

        public List<string> GetFiles(string basepath, bool includeSubdirectories)
        {
            List<string> ret;

            if (includeSubdirectories)
            {
                _files = new List<string>();
                GetFilesRecurse(basepath);
                ret = _files;
            }
            else
            {
                ret = GetFilesNoRecurse(basepath);
            }

            return ret;
        }

        private void GetFilesRecurse(string basepath)
        {
            var dirInfo = new DirectoryInfo(basepath);

            foreach (var d in dirInfo.GetDirectories())
            {
                GetFilesRecurse(d.FullName);
            }
            foreach (var f in dirInfo.GetFiles())
            {
                if (_validExtensions.Contains(f.Extension.ToLower()))
                {
                    _files.Add(f.FullName);
                }
            }
        }

        private List<string> GetFilesNoRecurse(string basepath)
        {
            var result = new List<string>();
            var dirInfo = new DirectoryInfo(basepath);

            foreach (var f in dirInfo.GetFiles())
            {
                if (_validExtensions.Contains(f.Extension))
                {
                    result.Add(f.FullName);
                }
            }

            return result;
        }
    }
}
