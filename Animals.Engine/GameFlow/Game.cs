using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Animals.Engine.GameFlow
{
    public class Game
    {
        public int InitialCardsNumber { get; }
        public Player User { get; set; }
        public Player PC { get; set; }
        public IGameUIStream UIStream { get; set; }
        public Game(Player user, Player pc, int initialCardsNumber, IGameUIStream uiStream)
        {
            InitialCardsNumber = initialCardsNumber;
            User = user;
            PC = pc;
            UIStream = uiStream;
        }
        /// <summary>
        /// Need to dehardcode zero indices to enable multicard
        /// </summary>
        public void Duel()
        {
            int firstPlayerFlag = Utilities.RandomNumberBetween(0, 2);
            bool userDied = false;
            bool pcDied = false;
            for (int roundIdx = firstPlayerFlag; roundIdx < 1000; ++roundIdx)
            {
                Thread.Sleep(Utilities.RandomNumberBetween(500, 1500));
                if (roundIdx % 2 == 0)
                {
                    User.Deck[0].Attack(PC.Deck[0]);
                }
                else
                {
                    PC.Deck[0].Attack(User.Deck[0]);
                }
                userDied = User.Deck[0].CheckDeath();
                pcDied = PC.Deck[0].CheckDeath();
                UIStream.UpdateRound(roundIdx);
                if (userDied || pcDied)
                {
                    UIStream.DeclareWinner(userDied, pcDied, PC.Deck[0].Name, User.Deck[0].Name);
                    break;
                }

            }
        }
    }
}
