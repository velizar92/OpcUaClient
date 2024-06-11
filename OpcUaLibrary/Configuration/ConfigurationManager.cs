using System.IO;
using Newtonsoft.Json;

namespace OpcUaLibrary.Configuration
{
    public class ConfigurationManager
    {
        public static Configuration LoadConfiguration()
        {
            Configuration configuration = null;

            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "configuration.json");

            configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(filePath));
            return configuration;
        }

    }
}
