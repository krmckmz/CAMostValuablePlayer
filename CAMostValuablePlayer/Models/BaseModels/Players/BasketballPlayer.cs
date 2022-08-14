namespace CAMostValuablePlayer
{
    public abstract class BasketballPlayer : Player
    {
        public int ScoredPoint { get; set; }
        public int Rebound { get; set; }
        public int Assist { get; set; }

        protected internal readonly int ScoreMultiplier = 2;
        protected internal readonly int ReboundMultiplier = 1;
        protected internal readonly int AssistMultiplier = 3;
    }
}
