using System.Text.Json;

namespace PRG2_Managing_Files
{
    public class HighScoreManager
    {
        public string CurrentName { get; set; } = "";
        public int CurrentScore { get; set; }

        public List<Player> PlayersList { get; private set; } = new();

        public async Task LoadPlayers()
        {
            PlayersList = await Load();
        }

        public void AddPlayer()
        {
            var newPlayer = new Player
            {
                Name = CurrentName,
                HighScore = CurrentScore
            };

            PlayersList.Add(newPlayer);
            Save(PlayersList);
        }

        // Hantring av Json-processen, med Load() och Save()
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