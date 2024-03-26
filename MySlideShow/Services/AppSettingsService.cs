using MySlideShow.Models;
using System.Text.Json;

namespace MySlideShow.Services
{
    internal class AppSettingsService
    {
        private string _path;

        internal AppSettingsService(string path) {
            _path = path;
        }

        internal void Save(AppSettings props)
        {
            using (var writer = File.CreateText(_path))
            {
                string jsonString = JsonSerializer.Serialize(props);
                writer.Write(jsonString);
            }
        }

        internal AppSettings Load()
        {
            AppSettings? props = null;

            using (var reader = File.OpenText(_path))
            {
                props = JsonSerializer.Deserialize<AppSettings>(reader.ReadToEnd());
            }

            return props ?? new AppSettings();
        }
    }
}
