namespace CAMostValuablePlayer
{
    public abstract class Repository<T>
    {
        /// <summary>
        /// A method to get dummy player datas
        /// </summary>
        /// <returns></returns>
        public abstract List<T> GetPlayers();
    }
}
