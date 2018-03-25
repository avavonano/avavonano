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
        public static IAnimal GetPCAnimal(Player player, Player alreadyPickedOpponentAnimal)
        {
            IAnimal pickedAnimal = null;
            int pickedAnimalIndex = 0;
            //todo add logic for the pc to pick next card
            if (alreadyPickedOpponentAnimal == null)//plays first
            {
                pickedAnimalIndex = 0;
            }
            else
            {
                pickedAnimalIndex = 0;
            }
            pickedAnimal = player.Deck[pickedAnimalIndex];
            player.Deck.RemoveAt(pickedAnimalIndex);
            return pickedAnimal;
        }
        public static Advantage PromptPlayerToPickAdvantage(Player user, IGameUIStream uiStream)
        {
            Advantage advantage = null;
            int cardIdx = uiStream.PromptPlayerToPickAdvantage(user);
            if(cardIdx>=0)
            {
                advantage = user.Advantages[cardIdx];
                user.Advantages.RemoveAt(cardIdx);
            }            
            return advantage;
        }
        public static Advantage GetPCAdvantage(Player user, IGameUIStream uiStream)
        {
            int idx = 0;//todo: make smart
            Advantage advantage = user.Advantages[idx];
            user.Advantages.RemoveAt(idx);
            return advantage;
        }
    }
}
