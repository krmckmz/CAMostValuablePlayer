namespace CAMostValuablePlayer
{
    public class Calculator<T>
    {
        private readonly ICalculator<T> _calculator;
        public Calculator(ICalculator<T> calculator)
        {
            _calculator = calculator;
        }

        public List<T> BindPlayerPoints(List<T> players)
        {
            return _calculator.BindPlayerPoints(players);
        }

        public Player GetMostValuablePlayer() => _calculator.GetMostValuablePlayer();

        public char GetWinnerTeam(List<T> players)
        {
            return _calculator.GetWinnerTeam(players);
        }
    }
}
