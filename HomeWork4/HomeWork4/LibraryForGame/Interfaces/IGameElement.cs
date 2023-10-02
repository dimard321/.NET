namespace LibraryForGame.Interfaces
{
    public interface IGameElement
    {
        /// <summary>
        /// Координата X препятствия.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата Y препятствия.
        /// </summary>
        public int Y { get; set; }
    }
}
