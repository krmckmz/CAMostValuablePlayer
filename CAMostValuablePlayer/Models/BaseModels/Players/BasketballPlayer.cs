namespace CAMostValuablePlayer
{
    public abstract class BasketballPlayer : Player
    {
        public int ScoredPoint { get; set; }
        public int Rebound { get; set; }
        public int Assist { get; set; }

        public readonly int ScoreMultiplier = 2;
        public readonly int ReboundMultiplier = 1;
        public readonly int AssistMultiplier = 3;
    }
}
