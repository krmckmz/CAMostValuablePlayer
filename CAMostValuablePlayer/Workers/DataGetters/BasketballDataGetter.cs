namespace CAMostValuablePlayer
{
    public class BasketballDataGetter : DataGetter<BasketballPlayer>
    {
        public override List<BasketballPlayer> GetPlayers()
        {
            var players = new List<BasketballPlayer>();

            players.Add(new Guard { ScoredPoint = 2, Rebound = 3, Assist = 1 });
            players.Add(new Forward { ScoredPoint = 2, Rebound = 2, Assist = 2 });
            players.Add(new Center { ScoredPoint = 2, Rebound = 1, Assist = 3 });

            return players;
        }
    }
}
