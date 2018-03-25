using Animals.Engine.Advantages;
using Animals.Engine.Animals;
using Animals.Engine.GameFlow;
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

        public static IAnimal PromptPlayerToPickCard(Player user,IGameUIStream uiStream)
        {
            IAnimal animal = null;
            int cardIdx = uiStream.PromptPlayerToPickCard(user);
            animal = user.Deck[cardIdx];
            user.Deck.RemoveAt(cardIdx);
            return animal;
        }
        public static Advantage PromptPlayerToAdvantage(Player user, IGameUIStream uiStream)
        {
            Advantage advantage = null;
            int cardIdx = uiStream.PromptPlayerToPickAdvantage(user);
            advantage = user.Advantages[cardIdx];
            user.Advantages.RemoveAt(cardIdx);
            return advantage;
        }
    }
}
