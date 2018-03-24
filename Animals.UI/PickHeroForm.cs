using Animals.Engine.GameFlow;
using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals.UI
{
    public partial class PickHeroForm : Form
    {
        public int HeroIndex { get; private set; }
        private IGameUIStream _uiStream;
        public PickHeroForm(IGameUIStream uiStream, Player player)
        {
            _uiStream = uiStream;
            InitializeComponent();
            List<PictureBox> pictures = new List<PictureBox>();
            pictures.Add(firstHeroPictureBox);
            pictures.Add(secondHeroPictureBox);
            pictures.Add(thirdHeroPictureBox);
            pictures.Add(fourthHeroPictureBox);
            pictures.Add(fifthHeroPictureBox);
            for(int i=0;i<player.Deck.Count;++i)
            {
                HeroMultimedia.ShowHero(player.Deck[i].AnimalType, pictures[i]);
            }
        }

        private void firstHeroPictureBox_Click(object sender, EventArgs e)
        {
            HeroIndex = 0;
            Hide();            
        }

        private void secondHeroPictureBox_Click(object sender, EventArgs e)
        {
            HeroIndex = 1;
            Hide();
        }

        private void thirdHeroPictureBox_Click(object sender, EventArgs e)
        {
            HeroIndex = 2;
            Hide();
        }

        private void fourthHeroPictureBox_Click(object sender, EventArgs e)
        {
            HeroIndex = 3;
            Hide();
        }

        private void fifthHeroPictureBox_Click(object sender, EventArgs e)
        {
            HeroIndex = 4;
            Hide();
        }
    }
}
