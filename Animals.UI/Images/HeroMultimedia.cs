using Animals.Engine;
using Animals.Engine.Animals;
using Animals.Engine.UI.Interfaces.Enums;
using System.Windows.Forms;
using Utilities;

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
            else if (animalType == AnimalType.Rhino)
            {
                heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.rhinoPicture);
            }
            else if (animalType == AnimalType.Rat)
            {
                heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.justRatPicture);
            }
            else
            {
                heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.MosquitoImage);
            }
        }
        public static void ShowWinner(Winner winner, PictureBox winnerPictureBox,TextBox msg)
        {
            if (winner == Winner.User)
            {
                winnerPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.winner);
                msg.Text = "Congratulations! You are victorious.";
            }
            else if (winner == Winner.Computer)
            {
                winnerPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.loser);
                msg.Text = "You had a defeat with no honor. You just suck!";
            }
            else
            {
                winnerPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.tie);
                msg.Text = "No winners here. Only losers. Lol";
            }
        }
    }
}
