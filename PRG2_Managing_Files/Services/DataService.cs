using PRG2_Managing_Files.Model;
using System.Text.Json;

namespace PRG2_Managing_Files.Services
{
    public class DataService
    {
        private readonly string filePath = "highscores.json";

        public async Task<List<Player>> Load()
        {
            if (!File.Exists(filePath))
                return new List<Player>();

            string json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
        }

        public async Task Save(List<Player> players)
        {
            string json = JsonSerializer.Serialize(players, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(filePath, json);
        }
    }
}