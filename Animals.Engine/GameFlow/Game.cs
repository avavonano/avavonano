using Animals.Engine.Animals;
using Animals.Engine.UI.Interfaces;
using System.Threading;
using Utilities;
namespace Animals.Engine.GameFlow
{
    public class Game
    {
        public int InitialCardsNumber { get; }
        public int CurrentCardsNumber { get; private set; }
        public Player User { get; set; }
        public Player PC { get; set; }
        public IGameUIStream UIStream { get; set; }
        public Game(Player user, Player pc, int initialCardsNumber, IGameUIStream uiStream)
        {
            InitialCardsNumber = initialCardsNumber;
            User = user;
            PC = pc;
            UIStream = uiStream;
        }
        
        
        /// <summary>
        /// Need to dehardcode zero indices to enable multicard.
        /// </summary>
        public void Duel()
        {
            Score score = new Score();
            CurrentCardsNumber = User.Deck.Count;
            while (CurrentCardsNumber > 0)
            {
                int firstPlayerFlag = Math.RandomNumberBetween(0, 2);
                bool userDied = false;
                bool pcDied = false;
                
                User.DrawAdvantage();
                PC.DrawAdvantage();
                ExcerciseAdvantages();

                IAnimal userAnimal =GameUtilities.PromptPlayerToPickCard(User, UIStream);                
                IAnimal pcAnimal =GameUtilities.GetPCAnimal(PC,User);
                userAnimal.ShowHero();
                pcAnimal.ShowHero();

                for (int roundIdx = firstPlayerFlag; roundIdx < 1000; ++roundIdx)
                {
                    Thread.Sleep(Math.RandomNumberBetween(500, 1500));
                    if (roundIdx % 2 == 0)
                    {
                        userAnimal.Attack(pcAnimal);
                    }
                    else
                    {
                        pcAnimal.Attack(userAnimal);
                    }
                    userDied = userAnimal.CheckDeath();
                    pcDied = pcAnimal.CheckDeath();
                    UIStream.UpdateRound(roundIdx);
                    if (userDied || pcDied)
                    {
                        
                        if(userDied && pcDied)
                        {
                            firstPlayerFlag = Math.RandomNumberBetween(0, 2);
                        }
                        else if(userDied)
                        {
                            firstPlayerFlag = 1;
                        }
                        else
                        {
                            firstPlayerFlag = 0;
                        }
                        UIStream.UpdateScore(userDied, pcDied,ref score);
                        break;
                    }
                }
                CurrentCardsNumber = User.Deck.Count;
            }
            UIStream.DeclareWinner(score, PC.UserName, User.UserName);
        }
        private void ExcerciseAdvantages()
        {
            if ((!User.Advantages.IsNull()) && User.Advantages.Count > 0)
            {
                UIStream.ShowUserDeck(User, "Check out your deck before excercising an advantage. Exit to continue.");
                var advantage =GameUtilities.PromptPlayerToPickAdvantage(User, UIStream);
                advantage?.ApplyAdvantage(User, this);
            }
            if ((!PC.Advantages.IsNull()) && PC.Advantages.Count > 0)//todo add logic on how pc excercies advantage
            {
                var advantage = GameUtilities.GetPCAdvantage(PC, UIStream);
                advantage?.ApplyAdvantage(PC, this);
            }
        }
    }
    
}
