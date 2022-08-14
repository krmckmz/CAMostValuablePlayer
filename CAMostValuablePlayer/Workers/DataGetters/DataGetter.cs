namespace CAMostValuablePlayer
{
    public abstract class DataGetter<T>
    {
        /// <summary>
        /// A method to get dummy player datas
        /// </summary>
        /// <returns></returns>
        public abstract List<T> GetPlayers();
    }
}
