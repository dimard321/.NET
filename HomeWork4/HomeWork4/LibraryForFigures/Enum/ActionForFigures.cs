using System.ComponentModel;

namespace LibraryForFigures.Enum
{
    /// <summary>
    /// Перечисление действий связанных с фигурами.
    /// </summary>
    public enum ActionForFigures
    {
        [Description("Выбор круга")]
        Circle = 1,
        [Description("Выбор треугольника")]
        Triangle,
        [Description("Выбор квадрата")]
        Square,
        [Description("Выбор прямоугольника")]
        Rectangle,
        [Description("Выход")]
        Exit
    }
}
