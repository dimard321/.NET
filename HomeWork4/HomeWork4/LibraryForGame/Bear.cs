namespace LibraryForGame
{
    /// <summary>
    /// Класс представляющий медведя.
    /// </summary>
    public class Bear : Monters
    {
        /// <summary>
        /// Инициализирует новый экземпляр медведя с указанными координатами, уровнем атаки и здоровьем.
        /// </summary>
        /// <param name="x">Координата X медведя.</param>
        /// <param name="y">Координата Y медведя.</param>
        /// <param name="attack">Уровень атаки медведя.</param>
        /// <param name="hp">Здоровье медведя.</param>
        public Bear(int x, int y, int attack, int hp) : base(x, y, attack, hp)
        {
        }
    }
}
