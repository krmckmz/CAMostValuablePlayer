namespace CAMostValuablePlayer
{
    class Program
    {
        static public void Main(String[] args)
        {
            var basketballCalculator = new Calculator<BasketballPlayer>(new BasketballCalculator());
            var basketballMvp = basketballCalculator.GetMostValuablePlayer();

            var handballCalculator = new Calculator<HandballPlayer>(new HandballCalculator());
            var handballMvp = handballCalculator.GetMostValuablePlayer();

            Console.WriteLine($"{nameof(basketballMvp)} : {basketballMvp}");
            Console.WriteLine(string.Empty);
            Console.WriteLine($"{nameof(handballMvp)} : {handballMvp}");
            Console.ReadLine();
        }


    }
}
