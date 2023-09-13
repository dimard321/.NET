namespace LibraryForGame
{
    /// <summary>
    /// Класс представляющий человека.
    /// </summary>
    public class Human : Character
    {
        /// <summary>
        /// Инициализирует новый экземпляр человека с указанными координатами, уровнем атаки и здоровьем.
        /// </summary>
        /// <param name="x">Координата X человека.</param>
        /// <param name="y">Координата Y человека.</param>
        /// <param name="attack">Уровень атаки человека.</param>
        /// <param name="hp">Здоровье человека.</param>
        public Human(int hp, int speed, int attack, int x, int y) : base(hp, speed, attack, x, y)
        {
        }
    }
}
