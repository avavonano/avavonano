using Animals.Engine.UI.Interfaces;
using System.Windows.Forms;
using Animals.Engine.Animals;
using Utilities;
using Animals.UI.UIEngineHandshake.Support;
namespace Animals.UI
{
    public class WindowsFormPlayerUIStream : IPlayerUIStream
    {
        public bool LoggingOff { get; set; }
        private TextBox _heroDialogueBox { get; set; }
        private CardLabels _labels { get; set; }
        private PictureBox _heroPictureBox;
        ProgressBar _lifeBar;
        public WindowsFormPlayerUIStream(TextBox heroDialogueBox,bool loggingOff, CardLabels labels, PictureBox heroPictureBox,ProgressBar lifeBar)
        {
            _heroDialogueBox = heroDialogueBox;
            LoggingOff = loggingOff;
            _labels = labels;
            _heroPictureBox = heroPictureBox;
            _lifeBar = lifeBar;
        }
        public void Talk(string phrase)
        {
            if(!LoggingOff)
            _heroDialogueBox.AppendLine(phrase);
        }
        public void UpdateStats(IAnimal animal)
        {
            _labels.Life.ReplaceText((animal.Life<0? 0:animal.Life) +":"+ animal.InitialLife);
            _labels.Attack.ReplaceText("Damage: " + animal.Damage + "");
            _labels.Defence.ReplaceText("Defence: " + animal.Defense + "");
            _labels.SpecialAbility.ReplaceText(animal.SpecialAbilities);
            _lifeBar.UpdateValue(animal.Life);
            _labels.Update();
        }
        public void ShowHero(AnimalType animalType)
        {
            Multimedia.ShowHero(animalType, _heroPictureBox);
        }
        public void Reset(IAnimal animal)
        {
            _lifeBar.Initiate(animal.InitialLife);
        }
    }   
}
