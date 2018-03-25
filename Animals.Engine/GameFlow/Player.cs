using Animals.Engine.Advantages;
using Animals.Engine.Animals;
using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Animals.Engine.GameFlow
{
    public class Player
    {
        public string UserName { get; set; }
        public int InitialCardsNumber { get; }
        public IUIStream UIStream { get; set; }
        public List<IAnimal> Deck { get; set; }
        public List<Advantage> Advantages { get; set; }
        public Player(string usrName,IUIStream uiStream,  int initialCardsNumber)
        {


            if (string.IsNullOrEmpty(usrName))
            {
                UserName = "random player";
            }
            else
            {
                UserName = usrName;
            }


            
            InitialCardsNumber = initialCardsNumber;
            UIStream = uiStream;
            ResetDeck(InitialCardsNumber);
        }
        public void ResetDeck(int initialCardsNumber)
        {
            Deck = new List<IAnimal>();
            for (int cardIdx = 0; cardIdx < initialCardsNumber; ++cardIdx)
            {
                Deck.Add(Draws.GetAnimal(UserName, UIStream));
            }
        }
        public void DrawAdvantage()
        {
            if(Advantages.IsNull())
            {
                Advantages = new List<Advantage>();
            }
            Advantages.Add(Draws.GetAdvantage());
        }
    }
}
