using PRG2_Managing_Files.Model;
using PRG2_Managing_Files.Services;

namespace PRG2_Managing_Files.ViewModel
{
    public class HighScoreViewModel
    {
        private readonly DataService dataService;

        public string CurrentName { get; set; } = "";
        public int CurrentScore { get; set; }

        public List<Player> Players { get; private set; } = new();

        public HighScoreViewModel(DataService dataService)
        {
            this.dataService = dataService;
            LoadPlayers();
        }

        public void LoadPlayers()
        {
            Players = dataService.Load();
        }

        public void AddPlayer()
        {
            var newPlayer = new Player
            {
                Name = CurrentName,
                HighScore = CurrentScore
            };

            Players.Add(newPlayer);
            dataService.Save(Players);
        }
    }
}