using System;
using System.Windows.Forms;
using Animals.Engine.UI.Interfaces;
using Animals.Engine.GameFlow;
using Animals.UI.UIEngineHandshake;

namespace Animals.UI
{
    public partial class txtWinner : Form
    {
        public txtWinner()
        {
            InitializeComponent();
        }       
        private void cmdStartGame_Click(object sender, EventArgs e)
        { 
            int cardsNum = 5;
            bool logingOff = false;
            Labels userLabesl = new Labels(labelLifePlayer, labelDefensePlayer, labelAttackPlayer, labelUserSpecialAbilities);
            Labels pcLabesl = new Labels(labelLifeComputer, labelDefenceComputer, labelAttackComputer, labelPCSpecialAbilities);
            IUIStream userUIStream = new WindowsFormUIStream(playerConsole, logingOff, userLabesl, pictureBoxPlayer, userLifeBar);
            IUIStream pcUIStream = new WindowsFormUIStream(opponentConsole, logingOff, pcLabesl, pictureBoxOpponent, opponentLifeBar);
            IGameUIStream gameUIStream = new WindowsFormGameUIStream(txtRound, txtBoxWinner,playerScoreTxtBox,pcScoreTxtBox);
            Player usr = new Player(txtUserName.Text, userUIStream, cardsNum);
            Player pc = new Player("Computer", pcUIStream, cardsNum);
            Game newGame = new Game(usr, pc, cardsNum, gameUIStream);
            newGame.Duel();
        }
    }
}
