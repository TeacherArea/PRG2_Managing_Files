namespace WriteReadToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feed me with players and their scores.");
            string choice = "Go";
            while (true)
            {
                if(choice != "n")
                {
                    Console.Write("Write a players name: ");
                    string userName = Console.ReadLine();
                    Console.Write("Write the players highscore: ");
                    int score = int.Parse(Console.ReadLine());
                    SaveHighScore(userName, score);
                    Console.WriteLine("Save another player? [y/n]");
                    choice = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            LoadHighScores();
        }
        static private void SaveHighScore(string userName, int score)
        {
            string filePath = "highscores.txt";
            string scoreEntry = $"{userName} - {score}\n";

            File.AppendAllText(filePath, scoreEntry);
        }
        static private void LoadHighScores()
        {
            string filePath = "highscores.txt";

            if (File.Exists(filePath))
            {
                string[] scores = File.ReadAllLines(filePath);

                foreach (string s in scores)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
