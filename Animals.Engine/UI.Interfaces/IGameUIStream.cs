using Animals.Engine.Advantages;
using Animals.Engine.Animals;
using Animals.Engine.GameFlow;
namespace Animals.Engine.UI.Interfaces
{
    public interface IGameUIStream
    {
        /// <summary>
        /// Must update the score in the UI.
        /// </summary>
        /// <param name="score"></param>
        void UpdateScore(Score score);
        /// <summary>
        /// Must update the round number in the UI.
        /// </summary>
        /// <param name="round"></param>
        void UpdateRound(int round);
        /// <summary>
        /// Must declare the winner using the score in the UI.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="usrName"></param>
        /// <param name="opponentName"></param>
        void DeclareWinner(Score score, string usrName, string opponentName);
        /// <summary>
        /// Must return the index of the card chosen by the user through the UI.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        int PromptPlayerToPickCard(Player player);
        /// <summary>
        /// Must Show the player's deck in the UI.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="msg"></param>
        void ShowUserDeck(Player player, string msg);
        /// <summary>
        /// Must return the index of the Advantage chosen by the user through the UI.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        int PromptPlayerToPickAdvantage(Player player);
        /// <summary>
        /// Return to UI.
        /// </summary>
        void FocusAfterPrompt();
    }
}
