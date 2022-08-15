namespace CAMostValuablePlayer
{
    public class BasketballCalculator : ICalculator<BasketballPlayer>
    {
        public List<BasketballPlayer> BindPlayerPoints(List<BasketballPlayer> players)
        {
            char winnerTeam = GetWinnerTeam(players);

            foreach (var player in players)
            {
                player.Point = (player.ScoredPoint * BasketballConstants.ScoreMultiplier)
                               + (player.Rebound * BasketballConstants.ReboundMultiplier)
                               + (player.Assist * BasketballConstants.AssistMultiplier);

                if (player.Team == winnerTeam)
                    player.Point += 10;
            }


            return players;
        }

        public Player GetMostValuablePlayer()
        {
            var basketballRepository = new BasketballRepository();
            List<BasketballPlayer> basketballPlayers = basketballRepository.GetPlayers();
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
