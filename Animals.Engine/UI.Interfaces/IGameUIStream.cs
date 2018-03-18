using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Engine.UI.Interfaces
{
    public interface IGameUIStream
    {
        void UpdateRound(int round);
        void DeclareWinner(bool userDied, bool pcDied, string usrName, string opponentName);
    }
}
