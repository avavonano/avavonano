using System;
using System.Threading;
using System.Windows.Forms;
using Animals.Engine;
using Animals.Engine.Animals;
using Animals.Engine.Animals.Implementations;
using Animals.Engine.UI.Interfaces;
using Animals.Engine.GameFlow;

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
            
            //IAnimal user = GetAnimal(txtUserName.Text, userUIStream);
           // IAnimal computer = GetAnimal("Computer", pcUIStream);

            Player usr = new Player(txtUserName.Text, userUIStream, 1);
            Player pc = new Player("Computer", pcUIStream, 1);
            Game newGame = new Game(usr, pc, 1);


            int firstPlayerFlag = Utilities.RandomNumberBetween(0, 2);
            bool userDied = false;
            bool pcDied = false;
            for (int roundIdx = firstPlayerFlag; roundIdx < 1000; ++roundIdx)
            {
                Thread.Sleep(Utilities.RandomNumberBetween(500, 1500));
                if (roundIdx % 2 == 0)
                {                  
                    newGame.User.Deck[0].Attack(newGame.PC.Deck[0]);
                }
                else
                {
                    newGame.PC.Deck[0].Attack(newGame.User.Deck[0]);
                }
                userDied = newGame.User.Deck[0].CheckDeath();
                pcDied = newGame.PC.Deck[0].CheckDeath();
                txtRound.ReplaceText(roundIdx+"");
                if (userDied || pcDied)
                {
                    if (userDied && pcDied)
                    {
                        txtBoxWinner.ReplaceText("None!");
                    }
                    else if(userDied)
                    {
                        txtBoxWinner.ReplaceText(newGame.PC.Deck[0].Name);
                    }
                    else
                    {
                        txtBoxWinner.ReplaceText(newGame.User.Deck[0].Name);
                    }
                    //catDeaths += catDied ? 1 : 0;
                    //dogDeaths += dogDied ? 1 : 0;

                    break;
                }

            }
        }
    }
}
