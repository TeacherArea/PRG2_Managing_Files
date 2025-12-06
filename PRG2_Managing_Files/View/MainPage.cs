using PRG2_Managing_Files.ViewModel;
using PRG2_Managing_Files.Services;

namespace PRG2_Managing_Files.View
{
    internal class MainPage
    {
        static void Main(string[] args)
        {
            var dataService = new DataService();
            var vm = new MainPageViewModel(dataService); // kopplingen där ViewModel och DataService

            Console.WriteLine("Feed me with players and their scores.");

            while (true)
            {
                Console.Write("Write a player's name: ");
                vm.CurrentName = Console.ReadLine() ?? "";

                Console.Write("Write the player's highscore: ");
                vm.CurrentScore = int.Parse(Console.ReadLine() ?? "0");

                vm.AddPlayer();

                Console.Write("Save another player? [y/n]: ");
                string choice = (Console.ReadLine() ?? "").ToLower();
                if (choice == "n") break;
            }

            Console.WriteLine("High Scores:");

            foreach (var player in vm.PlayersList)
            {
                Console.WriteLine($"{player.Name} - {player.HighScore}");
            }
        }
    }
}
