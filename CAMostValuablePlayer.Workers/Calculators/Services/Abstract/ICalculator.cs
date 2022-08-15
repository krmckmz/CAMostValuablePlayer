namespace CAMostValuablePlayer
{
    public interface ICalculator<T>
    {
        /// <summary>
        /// A method to calculate and set personel point value to players
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        public abstract List<T> BindPlayerPoints(List<T> players);

        /// <summary>
        /// A method to get the winner team as a char
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        public abstract char GetWinnerTeam(List<T> players);

        /// <summary>
        /// A method to get mvp of the current sport
        /// </summary>
        /// <returns></returns>
        public abstract Player GetMostValuablePlayer();
    }
}
