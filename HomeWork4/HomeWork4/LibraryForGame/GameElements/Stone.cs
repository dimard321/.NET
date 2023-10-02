using LibraryForGame.AbstractClasses;

namespace LibraryForGame.GameElements
{
    /// <summary>
    /// Класс представляющий камень.
    /// </summary>
    public class Stone : Obstacles
    {
        /// <summary>
        /// Инициализирует новый экземпляр камня с указанными координатами.
        /// </summary>
        /// <param name="x">Координата X камня.</param>
        /// <param name="y">Координата Y камня.</param>
        public Stone(int x, int y) : base(x, y)
        {
        }
    }
}
