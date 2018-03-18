using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Engine.GameFlow
{
    public class Game
    {
        public int InitialCardsNumber { get; }
        public Player User { get; set; }
        public Player PC { get; set; }
        public Game(Player user, Player pc, int initialCardsNumber)
        {
            InitialCardsNumber = initialCardsNumber;
            User = user;
            PC = pc;
        }
    }
}
