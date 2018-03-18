using Animals.Engine.Animals;
using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Engine.GameFlow
{
    public class Player
    {
        public string UserName { get; set; }
        public int InitialCardsNumber { get; }
        public IUIStream UIStream { get; set; }
        public List<IAnimal> Deck { get; set; }
        public Player(string usrName,IUIStream uiStream,  int initialCardsNumber)
        {
            UserName = usrName;
            InitialCardsNumber = initialCardsNumber;
            UIStream = uiStream;
            Deck = new List<IAnimal>();
            for(int cardIdx = 0;cardIdx<InitialCardsNumber;++cardIdx)
            {
                Deck.Add(HeroDraws.GetAnimal(UserName, UIStream));
            }
        }
    }
}
