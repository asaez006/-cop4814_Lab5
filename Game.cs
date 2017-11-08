using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//For Step 7
//Update 2
//Part1

namespace Lab_2
{
    public class Game
    {
        public string Team1 { get; set; }
        public string Team1Scores { get; set; }
        public string Team2 { get; set; }
        public string Team2Scores { get; set; }
        public Game() { }

        public Game(string Team1, string Team1Scores, string Team2, string Team2Scores)
        {
            this.Team1 = Team1;
            this.Team1Scores = Team1Scores;
            this.Team2 = Team2;
            this.Team2Scores = Team2Scores;
        }
        public override string ToString()
        {
            return String.Format("{0} ({1}) - {2} ({3})", Team1, Team1Scores, Team2, Team2Scores);
        }
        
    }

}
