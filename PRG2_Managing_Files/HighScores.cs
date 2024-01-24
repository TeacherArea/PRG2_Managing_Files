using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_Managing_Files
{
    internal class HighScores
    {
        private string userName;
        private int score;
        public HighScores(string userName, int score)
        {
            this.userName = userName;
            this.score = score;
        }
        public string UserName
        {
            get { return userName; }
        }
        public int Score
        {
            get { return score; }
        }
    }
}