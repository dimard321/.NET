using LibraryForGame.Interfaces;

namespace LibraryForGame.AbstractClasses
{
    /// <summary>
    /// Класс представляющий препятствия
    /// </summary>
    public abstract class Obstacles : IObstacles
    {
        /// <inheritdoc/>
        public int X { get; set; }
        /// <inheritdoc/>
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
