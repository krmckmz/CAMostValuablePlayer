namespace CAMostValuablePlayer
{
    public class BasketballCalculator : ICalculator
    {
     

        public int CalculatePoint()
        {

            return 0;
        }

        public Player GetMostValuablePlayer()
        {
            var basketballDataGetter = new BasketballDataGetter();
            List<BasketballPlayer> basketballPlayers = basketballDataGetter.GetPlayers();

            return basketballPlayers.First();
        }
    }
}
