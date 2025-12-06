using System.Text.Json;

namespace PRG2_Managing_Files
{
    public class HighScoreManager
    {
        public string CurrentName { get; set; } = "";
        public int CurrentScore { get; set; }

        public List<Player> PlayersList { get; private set; } = new();

        public HighScoreManager()
        {
            LoadPlayers();
        }

        public void LoadPlayers()
        {
            PlayersList = Load();
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