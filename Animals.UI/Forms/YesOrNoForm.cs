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
    public partial class YesOrNoForm : Form
    {
        public bool IsYes { get; private set; }
        public YesOrNoForm(string msg,string formTitle="")
        {
            InitializeComponent();
            yesOrNoDialogueText.Text = msg;
            if(formTitle!="")
            {
                Text = formTitle;
            }            
        }
        private void yesButton_Click(object sender, EventArgs e)
        {
            IsYes = true;
            Hide();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            IsYes = false;
            Hide();
        }
    }
}
