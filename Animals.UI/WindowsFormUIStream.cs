using Animals.Engine;
using Animals.Engine.UI.Interfaces;
using System.Windows.Forms;

namespace Animals.UI
{
    public class WindowsFormUIStream : IUIStream
    {
        public TextBox HeroDialogueBox { get; set; }
        public WindowsFormUIStream(TextBox heroDialogueBox)
        {
            HeroDialogueBox = heroDialogueBox;
        }
        public void Talk(string phrase)
        {
            HeroDialogueBox.AppendLine(phrase);
        }
    }
}
