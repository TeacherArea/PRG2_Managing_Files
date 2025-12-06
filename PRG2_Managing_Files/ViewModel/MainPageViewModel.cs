using PRG2_Managing_Files.Model;
using PRG2_Managing_Files.Services;

namespace PRG2_Managing_Files.ViewModel
{
    public class MainPageViewModel
    {
        private readonly DataService dataService;

        public string CurrentName { get; set; } = "";
        public int CurrentScore { get; set; }

        public List<Player> PlayersList { get; private set; } = new();

        public MainPageViewModel(DataService dataService)
        {
            this.dataService = dataService;
            LoadPlayers();
        }

        public void LoadPlayers()
        {
            PlayersList = dataService.Load();
        }

        public void AddPlayer()
        {
            var newPlayer = new Player
            {
                Name = CurrentName,
                HighScore = CurrentScore
            };

            PlayersList.Add(newPlayer);
            dataService.Save(PlayersList);
        }
    }
}