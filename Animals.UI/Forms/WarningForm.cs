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
    public partial class WarningForm : Form
    {
        public WarningForm(string warning)
        {
            InitializeComponent();
            warningTxtBox.Text = warning;
        }
    }
}
