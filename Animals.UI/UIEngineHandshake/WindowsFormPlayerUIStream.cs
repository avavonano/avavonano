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
            _heroDialogueBox.AppendLine(phrase, true);
        }
        public void UpdateStats(IAnimal animal)
        {
            _labels.Life.ReplaceText((animal.Life<0? 0:animal.Life) +":"+ animal.InitialLife,true);
            _labels.Attack.ReplaceText("Damage: " + animal.Damage + "", true);
            _labels.Defence.ReplaceText("Defence: " + animal.Defense + "", true);
            _labels.SpecialAbility.ReplaceText(animal.SpecialAbilities, true);
            _lifeBar.UpdateValue(animal.Life, true);
            _labels.Update();
        }
        public void ShowHero(AnimalType animalType)
        {
            Multimedia.ShowHero(animalType, _heroPictureBox,true);
        }
        public void Reset(IAnimal animal)
        {
            _lifeBar.Initiate(animal.InitialLife, true);
        }
    }   
}
