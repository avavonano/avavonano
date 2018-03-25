using Animals.Engine.UI.Interfaces;
using Animals.Engine.UI.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Engine
{
    public static class GameUtilities
    {
        public static Winner GetWinner(Score score)
        {
            if(score .UserScore== score.PcScore)
            {
                return Winner.None;
            }
            else if(score.UserScore > score.PcScore)
            {
                return Winner.User;
            }
            else
            {
                return Winner.Computer;
            }
        }
    }
}
