using Animals.Engine.GameFlow;
using Animals.Engine.Animals;
using Utilities;

namespace Animals.Engine.Advantages.Implementations
{
    public class RedrawCardAdvantage : Advantage
    {
        public RedrawCardAdvantage()
            : base("A card of the player's choice will be replaced by a random card.")
        {
        }
        protected override void ApplyAdvantageInternal(Player player, Game game)
        {
            if(player.UserName!=game.PC.UserName)
            {
                IAnimal animalThatIsDeleted = GameUtilities.PromptPlayerToPickCard(player, game.UIStream);
                player.Deck.Add(Draws.GetAnimal(player.UserName, player.UIStream));
                game.UIStream.ShowUserDeck(player, "Check out your deck after the " + GetType().Name + " advantage. If you want to continue, exit.");
            }     
            else
            {
                int idx = Math.RandomNumberBetween(0, player.Deck.Count);
                player.Deck.RemoveAt(idx);
                player.Deck.Add(Draws.GetAnimal(player.UserName, player.UIStream));
            }
           
        }
    }
}
