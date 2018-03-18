using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals.Engine;
using Animals.Engine.Animals;
using Animals.Engine.Animals.Implementations;
using Animals.Engine.UI.Interfaces;

namespace Animals.UI
{
    public partial class txtWinner : Form
    {
        public txtWinner()
        {
            InitializeComponent();
        }
        IAnimal GetAnimal(string name,  IUIStream uiStream)
        {
            IAnimal animal;
            int rnd = Utilities.RandomNumberBetween(0, 3);
            if (rnd == 0)
            {
                animal = new Cat(name, false, false, 200, 20, 10,  uiStream);
            }
            else if (rnd == 1)
            {
                animal = new Dog(name, true, 550, 50, 18,  uiStream);
            }
            else
            {
                animal = new RandomBug(name, true, 20, 3, 25,  uiStream);
            }
            return animal;
        }
                
        private void cmdStartGame_Click(object sender, EventArgs e)
        {
            bool logingOff = false;
            Labels userLabesl = new Labels(labelLifePlayer, labelDefensePlayer, labelAttackPlayer, labelUserSpecialAbilities);
            Labels pcLabesl = new Labels(labelLifeComputer, labelDefenceComputer, labelAttackComputer, labelPCSpecialAbilities);
            WindowsFormUIStream userUIStream = new WindowsFormUIStream(playerConsole, logingOff, userLabesl);
            WindowsFormUIStream pcUIStream = new WindowsFormUIStream(opponentConsole, logingOff, pcLabesl);
            
            IAnimal user = GetAnimal(txtUserName.Text, userUIStream);
            IAnimal computer = GetAnimal("Computer", pcUIStream);
            userLifeBar.Initiate(user.InitialLife);
            opponentLifeBar.Initiate(computer.InitialLife);
            UpdatePictureBox(pictureBoxPlayer, user.AnimalType);
            UpdatePictureBox(pictureBoxOpponent, computer.AnimalType);
            int firstPlayerFlag = Utilities.RandomNumberBetween(0, 2);
            bool userDied = false;
            bool pcDied = false;
            for (int roundIdx = firstPlayerFlag; roundIdx < 1000; ++roundIdx)
            {
                Thread.Sleep(Utilities.RandomNumberBetween(500, 1500));
                if (roundIdx % 2 == 0)
                {
                    user.Talk();
                    
                    user.Attack(computer);
                    userLifeBar.UpdateValue(user.Life);
                    opponentLifeBar.UpdateValue(computer.Life);
                }
                else
                {
                    computer.Talk();
                    computer.Attack(user);
                    userLifeBar.UpdateValue(user.Life);
                    opponentLifeBar.UpdateValue(computer.Life);
                }
                userDied = user.CheckDeath();
                pcDied = computer.CheckDeath();
                txtRound.ReplaceText(roundIdx+"");
                if (userDied || pcDied)
                {
                    if (userDied && pcDied)
                    {
                        txtBoxWinner.ReplaceText("None!");
                    }
                    else if(userDied)
                    {
                        txtBoxWinner.ReplaceText(computer.Name);
                    }
                    else
                    {
                        txtBoxWinner.ReplaceText(user.Name);
                    }
                    //catDeaths += catDied ? 1 : 0;
                    //dogDeaths += dogDied ? 1 : 0;

                    break;
                }

            }
        }
        
        void UpdatePictureBox(PictureBox inp, AnimalType animalType)
        {
            if (animalType == AnimalType.Dog)
            {
                inp.UpdatePictureBox(global::Animals.UI.Properties.Resources.DogImage);
            }
            else if (animalType == AnimalType.Cat)
            {
                inp.UpdatePictureBox(global::Animals.UI.Properties.Resources.catPicture);
            }
            else
            {
                inp.UpdatePictureBox(global::Animals.UI.Properties.Resources.MosquitoImage);
            }
        }

    }
}
