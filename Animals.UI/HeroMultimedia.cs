﻿using Animals.Engine;
using Animals.Engine.Animals;
using Animals.Engine.UI.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals.UI
{
    public static class Multimedia
    {
        public static void ShowHero(AnimalType animalType, PictureBox heroPictureBox)
        {
            if (animalType == AnimalType.Dog)
            {
                heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.DogImage);
            }
            else if (animalType == AnimalType.Cat)
            {
                heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.catPicture);
            }
            else
            {
                heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.MosquitoImage);
            }
        }
        public static void ShowWinner(Winner winner, PictureBox winnerPictureBox)
        {
            if (winner == Winner.User)
            {
                winnerPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.DogImage);
            }
            else if (winner == Winner.Computer)
            {
                winnerPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.catPicture);
            }
            else
            {
                winnerPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.MosquitoImage);
            }
        }
    }
}
