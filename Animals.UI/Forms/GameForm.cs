using System;
using System.Windows.Forms;
using Animals.Engine.UI.Interfaces;
using Animals.Engine.GameFlow;
using Animals.UI.UIEngineHandshake;
using Animals.UI.UIEngineHandshake.Support;
using System.ComponentModel;

namespace Animals.UI
{
    public partial class GameForm : Form
    {
        public BackgroundWorker _backgroundWorker;
        public GameForm()
        {
            InitializeComponent();
            txtUserName.Text = Environment.UserName;
        }
        public void ForceTabPageUpdate()
        {
            //int selectedIndex = SelectedIndex;

            //foreach (TabPage page in tabControl1.TabPages)
            //{
            //    page.Show();
            //}

            //tabControl1.TabPages[selectedIndex].Show();
            //Application.DoEvents();
        }

        private void RunWorker(object sender, EventArgs e)
        {
            int cardsNum = 5;
            bool logingOff = false;
            CardLabels userLabesl = PlayerCardLabels;
            CardLabels pcLabesl = PCCardLabels;
            IPlayerUIStream userUIStream = new WindowsFormPlayerUIStream(playerConsole, logingOff, userLabesl, pictureBoxPlayer, userLifeBar);
            IPlayerUIStream pcUIStream = new WindowsFormPlayerUIStream(opponentConsole, logingOff, pcLabesl, pictureBoxOpponent, opponentLifeBar);
            IGameUIStream gameUIStream = new WindowsFormGameUIStream(txtRound, txtBoxWinner, playerScoreTxtBox, pcScoreTxtBox, this);
            Player usr = new Player(txtUserName.Text, userUIStream, cardsNum);
            Player pc = new Player("Computer", pcUIStream, cardsNum);
            Game newGame = new Game(usr, pc, cardsNum, gameUIStream);
            newGame.Duel();
        }
        
        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //string status = e.UserState.ToString();
            //lblStatus.Text = status;
        }
        private void cmdStartGame_Click(object sender, EventArgs e)
        {
            _backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            ForceTabPageUpdate();
            _backgroundWorker.DoWork += RunWorker;
            _backgroundWorker.ProgressChanged += ProgressChanged;
            _backgroundWorker.RunWorkerAsync();
        }
    }
}
