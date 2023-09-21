using System.ComponentModel;

namespace LibraryForGame.Enum
{
    /// <summary>
    /// Перечисление выбора персонажа.
    /// </summary>
    public enum ChoseCharacter
    {
        /// <summary>
        /// Выбор человека.
        /// </summary>
        [Description("Выбор человека")]
        Human = 1,
        /// <summary>
        /// Выбор эльфа.
        /// </summary>
        [Description("Выбор эльфа")]
        Elph
    }
}
