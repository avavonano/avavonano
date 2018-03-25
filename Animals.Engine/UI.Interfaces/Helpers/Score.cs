using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Engine.UI.Interfaces
{
    public class Score
    {
        public int UserScore { get; set; }
        public int PcScore { get; set; }
        public void UpdateScore(int userScore, int pcScore)
        {
            UserScore += UserScore;
            PcScore += pcScore;
        }
    }
}
