using System.Windows.Forms;
using Utilities.Forms;

namespace Animals.UI.UIEngineHandshake.Support
{
    public class CardLabels : ControlsBearingClass
    {
        public Label Life { get; set; }
        public Label Defence { get; set; }
        public Label Attack { get; set; }
        public Label SpecialAbility { get; set; }
        public CardLabels()
        {
            Life = new Label(); 
            Defence = new Label(); 
            Attack = new Label();
            SpecialAbility = new Label();
        }
    }
}
