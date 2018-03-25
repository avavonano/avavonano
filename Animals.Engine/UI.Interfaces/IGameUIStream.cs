using Animals.Engine.Animals;
using Animals.Engine.GameFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Engine.UI.Interfaces
{
    public interface IGameUIStream
    {
        void UpdateScore(bool userDied, bool pcDied,ref Score score);
        void UpdateRound(int round);
        void DeclareWinner(Score score, string usrName, string opponentName);
        IAnimal PromptPlayerToPickCard(Player player);
        
    }
}
