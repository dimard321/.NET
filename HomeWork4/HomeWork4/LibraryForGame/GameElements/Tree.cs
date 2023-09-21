using LibraryForGame.AbstractClasses;

namespace LibraryForGame.GameElements
{
    /// <summary>
    /// Класс представляющий дерево.
    /// </summary>
    public class Tree : Obstacles
    {
        /// <summary>
        /// Инициализирует новый экземпляр дерева с указанными координатами.
        /// </summary>
        /// <param name="x">Координата X дерева.</param>
        /// <param name="y">Координата Y дерева.</param>
        public Tree(int x, int y) : base(x, y)
        {
        }
    }
}
