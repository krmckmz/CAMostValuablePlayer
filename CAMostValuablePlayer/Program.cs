namespace CAMostValuablePlayer
{
    class Program
    {
        static public void Main(String[] args)
        {

            var basketballCalculator = new Calculator(new BasketballCalculator());
            var basketballMvp = basketballCalculator.GetMostValuablePlayer();

            var handballCalculator = new Calculator(new HandballCalculator());
            var handballMvp = handballCalculator.GetMostValuablePlayer();
        }


    }
}
