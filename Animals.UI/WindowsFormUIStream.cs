using Animals.Engine;
using Animals.Engine.UI.Interfaces;
using System.Windows.Forms;

namespace Animals.UI
{
    public class WindowsFormUIStream : IUIStream
    {
        public bool LoggingOff { get; set; }
        public TextBox HeroDialogueBox { get; set; }
        public WindowsFormUIStream(TextBox heroDialogueBox,bool loggingOff)
        {
            HeroDialogueBox = heroDialogueBox;
            LoggingOff = loggingOff;
        }
        public void Talk(string phrase)
        {
            if(!LoggingOff)
            HeroDialogueBox.AppendLine(phrase);
        }
    }
}
