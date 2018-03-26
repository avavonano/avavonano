namespace Animals.Engine.UI.Interfaces
{
    public class Score
    {
        public int UserScore { get;private set; }
        public int PcScore { get;private set; }
        public int Ties { get;private set; }
        public int FirstPlayerFlag { get; private set; }
        private IGameUIStream _gameUIStream;
        public Score(IGameUIStream gameUIStream)
        {
            FirstPlayerFlag = Utilities.Math.RandomNumberBetween(0, 2);
            _gameUIStream = gameUIStream;
        }
        public void UpdateScore(bool userDied, bool pcDied)
        {
            if(userDied && pcDied)
            {
                ++Ties;
                FirstPlayerFlag =Utilities.Math.RandomNumberBetween(0, 2);
            }
            else if(userDied)
            {
                FirstPlayerFlag = 0;
                ++PcScore;
            }
            else
            {
                FirstPlayerFlag = 1;
                ++UserScore;
            }
            _gameUIStream.UpdateScore(this);
        }
    }
}
