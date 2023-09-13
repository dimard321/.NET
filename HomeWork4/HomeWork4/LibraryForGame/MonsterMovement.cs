using System.ComponentModel;

namespace LibraryForGame
{
    /// <summary>
    /// Перечисление движения монстров
    /// </summary>
    public enum MonsterMovement
    {
        [Description("Вверх")]
        Up = 1,
        [Description("Вниз")]
        Down = 2,
        [Description("Влево")]
        Left = 3,
        [Description("Вправо")]
        Right = 4,
    }
}
