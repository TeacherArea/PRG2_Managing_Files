using System.Threading.Tasks;

namespace PRG2_Managing_Files
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var manager= new HighScoreManager();
            await manager.LoadPlayers();

            Console.WriteLine("Feed me with players and their scores.");

            while (true)
            {
                Console.Write("Write a player's name: ");
                manager.CurrentName = Console.ReadLine() ?? "";

                Console.Write("Write the player's highscore: ");
                manager.CurrentScore = int.Parse(Console.ReadLine() ?? "0");

                manager.AddPlayer();

                Console.Write("Save another player? [y/n]: ");
                string choice = (Console.ReadLine() ?? "").ToLower();
                if (choice == "n") break;
            }

            Console.WriteLine("High Scores:");

            foreach (var player in manager.PlayersList)
            {
                Console.WriteLine($"{player.Name} - {player.HighScore}");
            }
        }
    }
}