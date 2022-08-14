namespace CAMostValuablePlayer
{
    public class BasketballCalculator : ICalculator<BasketballPlayer>
    {
        public List<BasketballPlayer> BindPlayerPoints(List<BasketballPlayer> players)
        {
            char winnerTeam = GetWinnerTeam(players);

            foreach (var player in players)
            {
                player.Point = (player.ScoredPoint * player.ScoreMultiplier)
                               + (player.Rebound * player.ReboundMultiplier)
                               + (player.Assist * player.AssistMultiplier);

                if (player.Team == winnerTeam)
                    player.Point += 10;
            }


            return players;
        }

        public Player GetMostValuablePlayer()
        {
            var basketballDataGetter = new BasketballDataGetter();
            List<BasketballPlayer> basketballPlayers = basketballDataGetter.GetPlayers();
            var pointBindedPlayers = BindPlayerPoints(basketballPlayers);

            return pointBindedPlayers.OrderByDescending(x => x.Point).First();
        }

        public char GetWinnerTeam(List<BasketballPlayer> players)
        {
            int teamAGoalSum = players.Where(x => x.Team == 'A').Sum(x => x.ScoredPoint);
            int teamBGoalSum = players.Where(x => x.Team == 'B').Sum(x => x.ScoredPoint);

            return teamAGoalSum > teamBGoalSum ? 'A' : 'B';
        }
    }
}
