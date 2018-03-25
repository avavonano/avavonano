using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Engine.GameFlow;

namespace Animals.Engine.Advantages.Implementations
{
    public class SeeOpponentDeck : Advantage
    {
        public SeeOpponentDeck()
            : base("See opponent's deck.")
        {
        }

        protected override void ApplyAdvantageInternal(Player player, Game game)
        {
            if(player.UserName==game.PC.UserName)
            {

            }
            else
            {
                game.UIStream.ShowUserDeck(game.PC, "You opponents is naked. Here is its cards.");
            }
        }
    }
}
