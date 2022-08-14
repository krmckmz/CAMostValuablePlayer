namespace CAMostValuablePlayer
{
    class Program
    {
        static public void Main(String[] args)
        {

            var basketballCalculator = new BasketballCalculator();
            var basketballMvp = basketballCalculator.GetMostValuablePlayer();

            var handballCalculator = new HandballCalculator();
            var handballMvp = handballCalculator.GetMostValuablePlayer();
        }

        
    }
}
