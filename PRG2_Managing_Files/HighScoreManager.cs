using PRG2_Managing_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PRG2_Managing_Files
{
    internal class HighScoreManager
    {
        private string filePath = "highscores.json";

        public void SaveHighScore(HighScores highScore)
        {
            List<HighScores> scores = LoadHighScores();
            scores.Add(highScore);
            string json = JsonSerializer.Serialize(scores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public List<HighScores> LoadHighScores()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<HighScores>> (json) ?? new List<HighScores>();
            }
            return new List<HighScores>();
        }
    }
}