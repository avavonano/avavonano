using Animals.Engine.Animals;
using Animals.Engine.UI.Interfaces;
using System.Threading;

namespace Animals.Engine.GameFlow
{
    public class Game
    {
        public int InitialCardsNumber { get; }
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
        private IAnimal GetPCAnimal(Player player, Player alreadyPickedOpponentAnimal)
        {
            IAnimal pickedAnimal = null;
            int pickedAnimalIndex = 0;
            if (alreadyPickedOpponentAnimal==null)//plays first
            {
                pickedAnimalIndex = 0;
            }
            else
            {
                pickedAnimalIndex = 0;
            }
            pickedAnimal = player.Deck[pickedAnimalIndex];
            player.Deck.RemoveAt(pickedAnimalIndex);
            return pickedAnimal;
        }
        /// <summary>
        /// Need to dehardcode zero indices to enable multicard.
        /// </summary>
        public void Duel()
        {            
            while(User.Deck.Count>0 && PC.Deck.Count>0)
            {
                int firstPlayerFlag = Utilities.RandomNumberBetween(0, 2);
                bool userDied = false;
                bool pcDied = false;
                IAnimal userAnimal = UIStream.PromptPlayerToPickCard(User);
                IAnimal pcAnimal = GetPCAnimal(PC,User);
                userAnimal.ShowHero();
                pcAnimal.ShowHero();
                for (int roundIdx = firstPlayerFlag; roundIdx < 1000; ++roundIdx)
                {
                    Thread.Sleep(Utilities.RandomNumberBetween(500, 1500));
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
                        UIStream.DeclareWinner(userDied, pcDied, pcAnimal.Name, userAnimal.Name);
                        if(userDied && pcDied)
                        {
                            firstPlayerFlag = Utilities.RandomNumberBetween(0, 2);
                        }
                        else if(userDied)
                        {
                            firstPlayerFlag = 1;
                        }
                        else
                        {
                            firstPlayerFlag = 0;
                        }
                        break;
                    }
                }
            }            
        }
    }
}
