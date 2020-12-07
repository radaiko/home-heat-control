using System.IO;
using System.Text.Json;

namespace HoHeCo.Models
{
    public class Config
    {
        public string OpenhabUrl { get; set; }

        public static void SaveConfig(Config config)
        {
            var jsonString = JsonSerializer.Serialize(config);
            File.WriteAllText("config.json", jsonString);
        }

        public static Config GetConfig()
        {
            var jsonString = File.ReadAllText("config.json");
            return JsonSerializer.Deserialize<Config>(jsonString);
        }
    }
}