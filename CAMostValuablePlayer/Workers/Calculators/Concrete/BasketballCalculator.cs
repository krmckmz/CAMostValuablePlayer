namespace CAMostValuablePlayer
{
    public class BasketballCalculator : ICalculator<BasketballPlayer>
    {
        public List<BasketballPlayer> BindPlayerPoints(List<BasketballPlayer> players)
        {
            foreach (var player in players)
                player.Point =   (player.ScoredPoint * player.ScoreMultiplier)
                               + (player.Rebound * player.ReboundMultiplier)
                               + (player.Assist * player.AssistMultiplier);

            return players;
        }

        public Player GetMostValuablePlayer()
        {
            var basketballDataGetter = new BasketballDataGetter();
            List<BasketballPlayer> basketballPlayers = basketballDataGetter.GetPlayers();
            var pointBindedPlayers = BindPlayerPoints(basketballPlayers);

            return pointBindedPlayers.OrderByDescending(x => x.Point).First();
        }
    }
}
