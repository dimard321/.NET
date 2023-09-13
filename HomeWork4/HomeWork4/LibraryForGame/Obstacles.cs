namespace LibraryForGame
{
    /// <summary>
    /// Класс представляющий препятствия
    /// </summary>
    public class Obstacles
    {
        /// <summary>
        /// Координата X препятствия.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата Y препятствия.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр препятствия с указанными координатами.
        /// </summary>
        /// <param name="x">Координата X препятствия.</param>
        /// <param name="y">Координата Y препятствия.</param>
        public Obstacles(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
