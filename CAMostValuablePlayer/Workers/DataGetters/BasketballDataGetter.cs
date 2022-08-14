namespace CAMostValuablePlayer
{
    public class BasketballDataGetter : DataGetter<BasketballPlayer>
    {
        public override List<BasketballPlayer> GetPlayers()
        {
            var players = new List<BasketballPlayer>();

            players.Add(new Guard { Nick = "nick1", Team = 'A', PositionKey = 'G', Number = 4, ScoredPoint = 10, Rebound = 2, Assist = 7 });
            players.Add(new Forward { Nick = "nick2", Team = 'A', PositionKey = 'F', Number = 8, ScoredPoint = 0, Rebound = 10, Assist = 0 });
            players.Add(new Center { Nick = "nick3", Team = 'A', PositionKey = 'C', Number = 15, ScoredPoint = 15, Rebound = 10, Assist = 4 });

            players.Add(new Guard { Nick = "nick4", Team = 'B', PositionKey = 'G', Number = 16, ScoredPoint = 20, Rebound = 0, Assist = 0 });
            players.Add(new Forward { Nick = "nick5", Team = 'B', PositionKey = 'F', Number = 23, ScoredPoint = 4, Rebound = 7, Assist = 7 });
            players.Add(new Center { Nick = "nick6", Team = 'B', PositionKey = 'C', Number = 42, ScoredPoint = 8, Rebound = 10, Assist = 0 });

            return players;
        }
    }
}
