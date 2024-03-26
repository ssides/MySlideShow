using Microsoft.VisualBasic.FileIO;
using MySlideShow.Models;
using System.Diagnostics;
using System.Text.Json;

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

        public void SaveReviewedFiles(string filename, List<ImageFile> files)
        {
            using (var writer = File.CreateText(filename))
            {
                string jsonString = JsonSerializer.Serialize(files);
                writer.Write(jsonString);
            }
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

        internal List<ImageFile> GetReviewedFiles(string filename)
        {
            var result = new List<ImageFile>();

            if (File.Exists(filename))
            {
                using (var reader = File.OpenText(filename))
                {
                    result = JsonSerializer.Deserialize<List<ImageFile>>(reader.ReadToEnd());
                }
            }

            return result ?? new List<ImageFile>();
        }

        internal void TryDeleteTempFiles(List<string> tmpFiles)
        {
            foreach (var f in tmpFiles)
            {
                try
                {
                    File.Delete(f);
                    Debug.WriteLine($"Deleted {f}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Could not delete temp file: {ex.Message}");
                }
            }
        }

        internal string DeleteFile(string fullPath)
        {
            var result = "";

            if (!fullPath.ToLower().StartsWith("c:"))
            {
                result = CopyToTemp(fullPath);
            }

            FileSystem.DeleteFile(fullPath,
                UIOption.OnlyErrorDialogs,
                RecycleOption.SendToRecycleBin,
                UICancelOption.ThrowException);

            return result;
        }

        private string CopyToTemp(string fullPath)
        {
            var tempPath = Path.GetTempPath();
            var fn = Path.GetFileNameWithoutExtension(fullPath);
            var ext = Path.GetExtension(fullPath);
            var i = 0;
            var tfn = GetFullTempPath(tempPath, fn, ext, i);

            while (File.Exists(tfn))
            {
                i++;
                tfn = GetFullTempPath(tempPath, fn, ext, i);
            }
            File.Copy(fullPath, tfn, true);

            return $"Copied to {tfn}";
        }

        private string GetFullTempPath(string tempPath, string fn, string ext, int i)
        {
            var n = i == 0 ? "" : $" ({i})";
            var filename = $"{fn} - Copy{n}";
            return Path.Combine(tempPath, filename + ext);
        }

        internal void Rename(string fullPath, string newFileName)
        {
            File.Move(fullPath, newFileName);
        }
    }
}
