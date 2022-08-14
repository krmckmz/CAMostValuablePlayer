namespace CAMostValuablePlayer
{
    public abstract class HandballPlayer : Player
    {
        public int InitialRatingPoints { get; set; }
        public int GoalMade { get; set; }
        public int GoalReceived { get; set; }

        public readonly int GoalMadeMultiplier = 5;
        public readonly int GoalReceivedMultiplier = 10;
    }
}
