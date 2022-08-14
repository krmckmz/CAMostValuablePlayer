namespace CAMostValuablePlayer
{
    public class HandballCalculator : ICalculator<HandballPlayer>
    {
        public List<HandballPlayer> BindPlayerPoints(List<HandballPlayer> players)
        {
            foreach (var player in players)
                player.Point =   player.InitialRatingPoints
                               + (player.GoalMade * player.GoalMadeMultiplier)
                               + (player.GoalReceived * player.GoalReceivedMultiplier);

            return players;
        }

        public Player GetMostValuablePlayer()
        {
            var handballDataGetter = new HandballDataGetter();
            List<HandballPlayer> handballPlayers = handballDataGetter.GetPlayers();
            var players = BindPlayerPoints(handballPlayers);

            return players.OrderByDescending(x => x.Point).First();
        }
    }
}
