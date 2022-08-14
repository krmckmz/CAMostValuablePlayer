namespace CAMostValuablePlayer
{
    public class HandballCalculator : ICalculator
    {
        public int CalculatePoint()
        {
            return 0;
        }

        public Player GetMostValuablePlayer()
        {
            var handballDataGetter = new HandballDataGetter();
            List<HandballPlayer>  handballPlayers = handballDataGetter.GetPlayers();

            return handballPlayers.First();
        }
    }
}
