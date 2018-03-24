using Animals.Engine;
using Animals.Engine.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals.UI
{
    public static class HeroMultimedia
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
    }
}
