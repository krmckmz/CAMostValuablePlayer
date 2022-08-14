namespace CAMostValuablePlayer
{
    public class HandballCalculator : ICalculator<HandballPlayer>
    {
        public List<HandballPlayer> BindPlayerPoints(List<HandballPlayer> players)
        {
            char winnerTeam = GetWinnerTeam(players);

            foreach (var player in players)
            {
                player.Point = player.InitialRatingPoints
                                             + (player.GoalMade * player.GoalMadeMultiplier)
                                             + (player.GoalReceived * player.GoalReceivedMultiplier);

                if (player.Team == winnerTeam)
                    player.Point += 10;
            }

            return players;
        }

        public Player GetMostValuablePlayer()
        {
            var handballDataGetter = new HandballDataGetter();
            List<HandballPlayer> handballPlayers = handballDataGetter.GetPlayers();
            var players = BindPlayerPoints(handballPlayers);

            return players.OrderByDescending(x => x.Point).First();
        }

        public char GetWinnerTeam(List<HandballPlayer> players)
        {
            int teamAGoalSum = players.Where(x => x.Team == 'A').Sum(x => x.GoalMade);
            int teamBGoalSum = players.Where(x => x.Team == 'B').Sum(x => x.GoalMade);

            return teamAGoalSum > teamBGoalSum ? 'A' : 'B';
        }
    }
}
