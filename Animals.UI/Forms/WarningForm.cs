using System;
using System.Windows.Forms;
namespace Animals.UI.Forms
{
    public partial class WarningForm : Form
    {
        public WarningForm(string warning)
        {
            InitializeComponent();
            warningTxtBox.Text = warning;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
