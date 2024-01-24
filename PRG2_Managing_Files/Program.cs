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
            Console.WriteLine("Hello World! And here is the High Scores: ");
           
                       SaveHighScore(userName, guesses);
            LoadHighScores();
        }
        static private void SaveHighScore(string userName,
       int guesses)
        {
            string filePath = "highscores.txt";
            string scoreEntry = $"{userName} - {guesses}\n";

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
                //listBoxHighScores.Items.Clear();
                //listBoxHighScores.Items.AddRange(scores);
            }
        }
    }
}
