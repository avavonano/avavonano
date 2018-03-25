using Animals.Engine.Advantages;
using Animals.Engine.Animals;
using Animals.Engine.GameFlow;
namespace Animals.Engine.UI.Interfaces
{
    public interface IGameUIStream
    {
        void UpdateScore(bool userDied, bool pcDied,ref Score score);
        void UpdateRound(int round);
        void DeclareWinner(Score score, string usrName, string opponentName);
        int PromptPlayerToPickCard(Player player);
        void ShowUserDeck(Player player, string msg);
        int PromptPlayerToPickAdvantage(Player player);
        void FocusAfterPrompt();
    }
}
