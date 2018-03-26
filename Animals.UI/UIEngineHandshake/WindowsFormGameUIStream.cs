﻿using Animals.Engine;
using Animals.Engine.UI.Interfaces;
using System.Windows.Forms;
using Animals.Engine.GameFlow;
using Animals.Engine.UI.Interfaces.Enums;
using Utilities;
using Animals.UI.Forms;

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

        public int PromptPlayerToPickCard(Player player)
        {
            int animal = -1;
            using (PickHeroForm pickCardForm = new PickHeroForm(this,player))
            {
                pickCardForm.ShowDialog();
                animal = pickCardForm.HeroIndex;
            }
            FocusAfterPrompt();
            return animal;
        }

        public void UpdateRound(int round)
        {
            _roundBox.ReplaceText(round + "");
        }

        public void UpdateScore(Score score)
        {
            _pcScoreTxtBox.Text = score.PcScore.ToString();          
            _userScoreTxtBox.Text = score.UserScore.ToString();            
        }

        public void FocusAfterPrompt()
        {
            _gameForm.Show();
        }

        public int PromptPlayerToPickAdvantage(Player player)
        {
            int advantage = -1;
            using (PickAdvantageForm pickAdvantageForm = new PickAdvantageForm(player))
            {
                pickAdvantageForm.ShowDialog();
                if(pickAdvantageForm.AdvantageIndex>=0)
                {
                    advantage = pickAdvantageForm.AdvantageIndex;
                }                
            }
            return advantage;
        }

        public void ShowUserDeck(Player player,string msg)
        {
            using (PickHeroForm pickCardForm = new PickHeroForm(this, player,msg))
            {
                pickCardForm.ShowDialog();                
            }
        }
    }
}
