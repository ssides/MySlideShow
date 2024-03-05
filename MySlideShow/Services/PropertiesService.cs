using MySlideShow.Models;
using System.Text.Json;

namespace MySlideShow.Services
{
    internal class PropertiesService
    {
        private string _path;

        internal PropertiesService(string path) {
            _path = path;
        }

        internal void Save(Properties props)
        {
            using (var writer = File.CreateText(_path))
            {
                string jsonString = JsonSerializer.Serialize(props);
                writer.Write(jsonString);
            }
        }

        internal Properties Load()
        {
            var props = new Properties();

            using (var reader = File.OpenText(_path))
            {
                props = JsonSerializer.Deserialize<Properties>(reader.ReadToEnd());
            }

            return props;
        }
    }
}
