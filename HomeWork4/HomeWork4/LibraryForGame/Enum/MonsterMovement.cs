using System.ComponentModel;

namespace LibraryForGame.Enum
{
    /// <summary>
    /// Перечисление движения монстров
    /// </summary>
    public enum MonsterMovement
    {
        /// <summary>
        /// Движение вверх.
        /// </summary>
        [Description("Вверх")]
        Up = 1,
        /// <summary>
        /// Движение вниз.
        /// </summary>
        [Description("Вниз")]
        Down = 2,
        /// <summary>
        /// Движение влево.
        /// </summary>
        [Description("Влево")]
        Left = 3,
        /// <summary>
        /// Движение вправо.
        /// </summary>
        [Description("Вправо")]
        Right = 4,
    }
}
