using System.Diagnostics;

namespace DelTemp
{
    internal class DelTempApp
    {
        /// <summary>
        /// FrmReviewImages works by making a temporary copy of the image so the original file
        /// can be manipulated.  On close, these temp files may still be in use, so they cannot
        /// be deleted.  This app just goes out and deletes them to save space.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var files = GetFiles(Path.GetTempPath());
            foreach (var file in files)
            {
                TryDelete(file);
            }
        }

        static List<string> GetFiles(string basepath)
        {
            var result = new List<string>();
            var dirInfo = new DirectoryInfo(basepath);

            foreach (var f in dirInfo.GetFiles("srs_*"))
            {
                result.Add(f.FullName);
            }

            return result;
        }

        private static void TryDelete(string file)
        {
            try
            {
                File.Delete(file);
                Console.WriteLine($"Deleted \"{file}\"");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Could not delete \"{file}\" {ex.Message}");
            }
        }
    }
}
