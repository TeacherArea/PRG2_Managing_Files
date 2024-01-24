using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using PRG2_Managing_Files;

namespace WriteReadToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighScoreManager manager = new HighScoreManager();
            HighScores highScores = new HighScores("Pelle Pelleson", 8);

            Console.WriteLine("Hello World! The scores:");
            manager.SaveHighScore(highScores);

            var scores = manager.LoadHighScores();
            foreach (var score in scores)
            {
                Console.WriteLine($"{score.UserName} - {score.Score} ");

            }
        }
    }
}
