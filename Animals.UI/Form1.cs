﻿using System;
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

namespace Animals.UI
{
    public partial class txtWinner : Form
    {
        public txtWinner()
        {
            InitializeComponent();
        }
        IAnimal GetAnimal(string name, ref TextBox txtBox)
        {
            IAnimal animal;
            int rnd = Utilities.RandomNumberBetween(0, 3);
            if (rnd == 0)
            {
                animal = new Cat(name, false, false, 200, 20, 10, ref txtBox);
            }
            else if (rnd == 1)
            {
                animal = new Dog(name, true, 550, 50, 18, ref txtBox);
            }
            else
            {
                animal = new RandomBug(name, true, 20, 3, 25, ref txtBox);
            }
            animal.LoggingOff = false;
            return animal;
        }
        void UpdateLabels(IAnimal inp, Labels labels)
        {
            labels.Life.ReplaceText(inp.InitialLife + "");
            labels.Attack.ReplaceText("Damage: " + inp.Damage + "");
            labels.Defence.ReplaceText("Defence: " + inp.Defense + "");
            labels.Update();
        }
        class Labels
        {
            public Label Life { get; set; }
            public Label Defence { get; set; }
            public Label Attack { get; set; }
            public Labels(Label life, Label defence, Label attack)
            {
                Life = life;
                Defence = defence;
                Attack = attack;
            }
            public void Update()
            {
                Life.Update();
                Defence.Update();
                Attack.Update();
            }
        }
        private void cmdStartGame_Click(object sender, EventArgs e)
        {
            Labels userLabesl = new Labels(labelLifePlayer, labelDefensePlayer, labelAttackPlayer);
            Labels pcLabesl = new Labels(labelLifeComputer, labelDefenceComputer, labelAttackComputer);
            IAnimal user = GetAnimal(txtUserName.Text,ref playerConsole);
            IAnimal computer = GetAnimal("Computer",ref opponentConsole);

            UpdateLabels(user, userLabesl);
            UpdateLabels(computer, pcLabesl);

           

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
                UpdateLabels(user, userLabesl);
                UpdateLabels(computer, pcLabesl);

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
