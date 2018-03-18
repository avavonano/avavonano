using Animals.Engine;
using Animals.Engine.UI.Interfaces;
using System.Windows.Forms;
using System;
using Animals.Engine.Animals;

namespace Animals.UI
{
    public class WindowsFormUIStream : IUIStream
    {
        public bool LoggingOff { get; set; }
        public TextBox HeroDialogueBox { get; set; }
        public Labels Labels { get; set; }
        private PictureBox _heroPictureBox;
        ProgressBar _lifeBar;
        public WindowsFormUIStream(TextBox heroDialogueBox,bool loggingOff, Labels labels, PictureBox heroPictureBox,ProgressBar lifeBar)
        {
            HeroDialogueBox = heroDialogueBox;
            LoggingOff = loggingOff;
            Labels = labels;
            _heroPictureBox = heroPictureBox;
            _lifeBar = lifeBar;
        }
        public void Talk(string phrase)
        {
            if(!LoggingOff)
            HeroDialogueBox.AppendLine(phrase);
        }

        public void UpdateStats(IAnimal animal)
        {
            Labels.Life.ReplaceText(animal.InitialLife + "");
            Labels.Attack.ReplaceText("Damage: " + animal.Damage + "");
            Labels.Defence.ReplaceText("Defence: " + animal.Defense + "");
            Labels.SpecialAbility.ReplaceText(animal.SpecialAbilities);
            _lifeBar.UpdateValue(animal.Life);
            Labels.Update();
        }

        public void ShowHero(AnimalType animalType)
        {
            if (animalType == AnimalType.Dog)
            {
                _heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.DogImage);
            }
            else if (animalType == AnimalType.Cat)
            {
                _heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.catPicture);
            }
            else
            {
                _heroPictureBox.UpdatePictureBox(global::Animals.UI.Properties.Resources.MosquitoImage);
            }
        }

        public void Reset(IAnimal animal)
        {
            _lifeBar.Initiate(animal.InitialLife);
        }
    }
    public class Labels
    {
        public Label Life { get; set; }
        public Label Defence { get; set; }
        public Label Attack { get; set; }
        public Label SpecialAbility { get; set; }
        public Labels(Label life, Label defence, Label attack, Label specialAbility)
        {
            Life = life;
            Defence = defence;
            Attack = attack;
            SpecialAbility = specialAbility;
        }
        public void Update()
        {
            Life.Update();
            Defence.Update();
            Attack.Update();
            SpecialAbility.Update();
        }
    }
}
