using Animals.Engine;
using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals.Engine.Animals;
using Animals.Engine.GameFlow;

namespace Animals.UI.UIEngineHandshake
{
    public class WindowsFormGameUIStream : IGameUIStream
    {
        private TextBox _roundBox;
        private TextBox _winnerBox;
        public WindowsFormGameUIStream(TextBox roundBox, TextBox winnerBox)
        {
            _roundBox = roundBox;
            _winnerBox = winnerBox;
        }

        public void DeclareWinner(bool userDied, bool pcDied, string usrName, string opponentName)
        {
            if (userDied && pcDied)
            {
                _winnerBox.ReplaceText("None!");
            }
            else if (userDied)
            {
                _winnerBox.ReplaceText(usrName);
            }
            else
            {
                _winnerBox.ReplaceText(opponentName);
            }
        }

        public IAnimal PromptPlayerToPickCard(Player player)
        {
            IAnimal animal = null;
            using (PickHeroForm pickCardForm = new PickHeroForm(this,player))
            {
                pickCardForm.ShowDialog();
                animal = player.Deck[pickCardForm.HeroIndex];
                player.Deck.RemoveAt(pickCardForm.HeroIndex);
            }            
            return animal;
        }

        public void UpdateRound(int round)
        {
            _roundBox.ReplaceText(round + "");
        }
    }
}
