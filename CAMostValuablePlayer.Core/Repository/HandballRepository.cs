namespace CAMostValuablePlayer
{
    public class HandballRepository : Repository<HandballPlayer>
    {
        public override List<HandballPlayer> GetPlayers()
        {
            var players = new List<HandballPlayer>();

            players.Add(new GoalKeeper { Nick = "nick1", Team = 'A', PositionKey = 'G', Number = 4, InitialRatingPoints = 50, GoalMade = 5, GoalReceived = -2 });
            players.Add(new FieldPlayer { Nick = "nick2", Team = 'A', PositionKey = 'F', Number = 8, InitialRatingPoints = 20, GoalMade = 3, GoalReceived = -1 });
            players.Add(new FieldPlayer { Nick = "nick3", Team = 'A', PositionKey = 'F', Number = 15, InitialRatingPoints = 40, GoalMade = 4, GoalReceived = -4 });

            players.Add(new GoalKeeper { Nick = "nick4", Team = 'B', PositionKey = 'G', Number = 16, InitialRatingPoints = 30, GoalMade = 3, GoalReceived = -3 });
            players.Add(new FieldPlayer { Nick = "nick5", Team = 'B', PositionKey = 'F', Number = 23, InitialRatingPoints = 60, GoalMade = 2, GoalReceived = -1 });
            players.Add(new FieldPlayer { Nick = "nick6", Team = 'B', PositionKey = 'F', Number = 42, InitialRatingPoints = 25, GoalMade = 5, GoalReceived = -2 });

            return players;
        }
    }
}
