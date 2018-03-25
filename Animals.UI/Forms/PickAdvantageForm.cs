using Animals.Engine.GameFlow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals.UI.Forms
{
    public partial class PickAdvantageForm : Form
    {
        Player _player;
        public int AdvantageIndex { get; private set; }
        public PickAdvantageForm(Player player)
        {
            InitializeComponent();
            _player = player;            
            foreach (var advantage in player.Advantages)
            {
                advantagesListBox.Items.Add(advantage.Description);
            }
        }

        private void pickAdvantage_Click(object sender, EventArgs e)
        {            
            var selectedItems = advantagesListBox.SelectedIndices;
            if (selectedItems.Count ==0)
            {
                using (WarningForm warning = new WarningForm("No advantage has been selected. Please try again."))
                {
                    warning.ShowDialog();
                }
            }
            else if (selectedItems.Count>1)
            {
                using (WarningForm warning = new WarningForm("No more than one advantages can be applied at the same time. Please try again."))
                {
                    warning.ShowDialog();
                }
            }
            else
            {
                AdvantageIndex = advantagesListBox.SelectedIndices[0];
                Hide();
            }            
        }
    }
}
