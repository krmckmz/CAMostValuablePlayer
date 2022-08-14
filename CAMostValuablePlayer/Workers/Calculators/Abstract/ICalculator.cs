namespace CAMostValuablePlayer
{
    public interface ICalculator<T>
    {
        public abstract List<T> BindPlayerPoints(List<T> players);
        public abstract char GetWinnerTeam(List<T> players);
        public abstract Player GetMostValuablePlayer();
    }
}
