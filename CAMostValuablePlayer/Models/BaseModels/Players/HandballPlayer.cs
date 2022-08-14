namespace CAMostValuablePlayer
{
    public abstract class HandballPlayer : Player
    {
        public int InitialRatingPoints { get; set; }
        public int GoalMade { get; set; }
        public int GoalReceived { get; set; }

        protected internal readonly int GoalMadeMultiplier = 5;
        protected internal readonly int GoalReceivedMultiplier = 10;
    }
}
