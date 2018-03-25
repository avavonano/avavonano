using Animals.Engine.UI.Interfaces.Enums;
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
    public partial class WinnerForm : Form
    {
        public WinnerForm(Winner winner)
        {
            InitializeComponent();
            Multimedia.ShowWinner(winner, winnerPictureBox);
        }
    }
}
