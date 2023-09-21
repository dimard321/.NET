using LibraryForGame.AbstractClasses;

namespace LibraryForGame.GameElements
{
    /// <summary>
    /// Класс представляющий эльфа
    /// </summary>
    public class Elph : Character
    {
        /// <summary>
        /// Инициализирует новый экземпляр эльфа с указанными координатами, уровнем атаки и здоровьем.
        /// </summary>
        /// <param name="x">Координата X эльфа.</param>
        /// <param name="y">Координата Y эльфа.</param>
        /// <param name="attack">Уровень атаки эльфа.</param>
        /// <param name="hp">Здоровье эльфа.</param>
        public Elph(int hp, int speed, int attack, int x, int y) : base(hp, speed, attack, x, y)
        {
        }
    }
}
