using System;
using System.Threading;
using System.Windows.Forms;
using Animals.Engine;
using Animals.Engine.Animals;
using Animals.Engine.Animals.Implementations;
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
            bool logingOff = false;
            Labels userLabesl = new Labels(labelLifePlayer, labelDefensePlayer, labelAttackPlayer, labelUserSpecialAbilities);
            Labels pcLabesl = new Labels(labelLifeComputer, labelDefenceComputer, labelAttackComputer, labelPCSpecialAbilities);
            IUIStream userUIStream = new WindowsFormUIStream(playerConsole, logingOff, userLabesl, pictureBoxPlayer, userLifeBar);
            IUIStream pcUIStream = new WindowsFormUIStream(opponentConsole, logingOff, pcLabesl, pictureBoxOpponent, opponentLifeBar);
            IGameUIStream gameUIStream = new WindowsFormGameUIStream(txtRound, txtBoxWinner);
            Player usr = new Player(txtUserName.Text, userUIStream, 5);
            Player pc = new Player("Computer", pcUIStream, 5);
            Game newGame = new Game(usr, pc, 1,gameUIStream);
            newGame.Duel();
        }
    }
}
