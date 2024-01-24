using System;
using System.IO;
namespace WriteReadToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "Pelle Pelleson";
            int guesses = 8;
            Console.WriteLine("Hello World! And here is the High Scores:");
            SaveHighScore(userName, guesses);
            LoadHighScores();
        }
        static private void SaveHighScore(string userName, int guesses)
        {
            string filePath = "highscores.txt";
            string scoreEntry = $"{userName} - {guesses}\n";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write(scoreEntry);
            }
        }
        static private void LoadHighScores()
        {
            string filePath = "highscores.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
