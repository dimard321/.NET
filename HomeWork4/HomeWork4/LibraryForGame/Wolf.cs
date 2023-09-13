namespace LibraryForGame
{
    /// <summary>
    /// Класс представляющий волка.
    /// </summary>
    public class Wolf : Monters
    {
        /// <summary>
        /// Инициализирует новый экземпляр волка с указанными координатами, уровнем атаки и здоровьем.
        /// </summary>
        /// <param name="x">Координата X волка.</param>
        /// <param name="y">Координата Y волка.</param>
        /// <param name="attack">Уровень атаки волка.</param>
        /// <param name="hp">Здоровье волка.</param>
        public Wolf(int x, int y, int attack, int hp) : base(x, y, attack, hp)
        {
        }
    }
}
