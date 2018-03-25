using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Engine.GameFlow;

namespace Animals.Engine.Advantages.Implementations
{
    public class RedrawDeckAdvantage : Advantage
    {
        public RedrawDeckAdvantage() 
            : base("The player's deck will be replaced by another random deck. No more cards are added.")
        {
        }

        protected override void ApplyAdvantageInternal(Player player, Game game)
        {
            player.ResetDeck(game.CurrentCardsNumber);            
        }
    }
}
