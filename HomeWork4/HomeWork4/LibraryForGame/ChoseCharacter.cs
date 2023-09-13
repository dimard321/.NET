using System.ComponentModel;

namespace LibraryForGame
{
    /// <summary>
    /// Перечисление выбора персонажа.
    /// </summary>
    public enum ChoseCharacter
    {
        [Description("Выбор человека")]
        Human = 1,
        [Description("Выбор эльфа")]
        Elph
    }
}
