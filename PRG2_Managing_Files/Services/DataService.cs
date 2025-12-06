using PRG2_Managing_Files.Model;
using System.Text.Json;

namespace PRG2_Managing_Files.Services
{
    public class DataService
    {
        private readonly string filePath = "highscores.json";

        public List<Player> Load()
        {
            if (!File.Exists(filePath))
                return new List<Player>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
        }

        public void Save(List<Player> players)
        {
            string json = JsonSerializer.Serialize(players, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}