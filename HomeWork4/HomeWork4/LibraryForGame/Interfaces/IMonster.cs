namespace LibraryForGame.Interfaces
{
    public interface IMonster
    {
        /// <summary>
        /// Координата X препятствия
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата Y препятствия.
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Сила атаки Монстра
        /// </summary>
        public int Attack { get; set; }
        /// <summary>
        /// HP монстра
        /// </summary>
        public int HP { get; set; }
    }
}
