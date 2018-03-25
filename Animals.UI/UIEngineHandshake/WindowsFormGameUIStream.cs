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
using Animals.Engine.UI.Interfaces.Enums;
using Utilities;

namespace Animals.UI.UIEngineHandshake
{
    public class WindowsFormGameUIStream : IGameUIStream
    {
        private GameForm _gameForm;
        private TextBox _roundBox;
        private TextBox _winnerBox;
        private TextBox _userScoreTxtBox;
        private TextBox _pcScoreTxtBox;
        public WindowsFormGameUIStream(TextBox roundBox, TextBox winnerBox, TextBox userScoreTxtBox, TextBox pcScoreTxtBox, GameForm gameForm)
        {
            _roundBox = roundBox;
            _winnerBox = winnerBox;
            _userScoreTxtBox = userScoreTxtBox;
            _pcScoreTxtBox = pcScoreTxtBox;
            _userScoreTxtBox.Text = "0";
            _pcScoreTxtBox.Text = "0";
            _gameForm=gameForm;
        }

        public void DeclareWinner(Score score, string usrName, string opponentName)
        {
            Winner winner = GameUtilities.GetWinner(score);
            WinnerForm winnerForm = new WinnerForm(winner);
            winnerForm.ShowDialog();
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

        public void UpdateScore(bool userDied, bool pcDied, ref Score score)
        {
            if(userDied && !(pcDied))
            {
                score.UpdateScore(0, 1);
                _pcScoreTxtBox.Text = score.PcScore.ToString();
            }
            else if (!(userDied) && pcDied)
            {
                score.UpdateScore(1, 0);
                _userScoreTxtBox.Text = score.UserScore.ToString();
            }
        }

        public void FocusAfterPrompt()
        {
            _gameForm.Show();
        }

    }
}
