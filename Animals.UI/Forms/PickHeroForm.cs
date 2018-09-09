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
        private List<PictureBox> _pictures;

        public PickHeroForm(IGameUIStream uiStream, Player player,string newFormTitle="")
        {
            _uiStream = uiStream;
            InitializeComponent();
            _pictures = new List<PictureBox>();
            _pictures.Add(firstHeroPictureBox);
            _pictures.Add(secondHeroPictureBox);
            _pictures.Add(thirdHeroPictureBox);
            _pictures.Add(fourthHeroPictureBox);
            _pictures.Add(fifthHeroPictureBox);
            for(int i=0;i< _pictures.Count;++i)
            {
                if(i<player.Deck.Count)
                {
                    Multimedia.ShowHero(player.Deck[i].AnimalType, _pictures[i],false);
                }
                else
                {
                    _pictures[i].Hide();
                }
                
            }
            if (newFormTitle != "")
            {
                Text = newFormTitle;
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
