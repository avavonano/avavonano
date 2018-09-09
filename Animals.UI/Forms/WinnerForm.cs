using Animals.Engine.UI.Interfaces.Enums;
using System.Windows.Forms;
namespace Animals.UI
{
    public partial class WinnerForm : Form
    {
        public WinnerForm(Winner winner)
        {
            InitializeComponent();
            Multimedia.ShowWinner(winner, winnerPictureBox,winnerTextBox,false);
        }

        private void winnerPictureBox_Click(object sender, System.EventArgs e)
        {
            Hide();
        }
    }
}
