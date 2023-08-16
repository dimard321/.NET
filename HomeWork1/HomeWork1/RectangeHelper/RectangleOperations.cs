using System.ComponentModel;

namespace RectangleHelper
{
    /// <summary>
    /// Представляет действия, связанные с прямоугольником.
    /// </summary>
    public enum RectangleOperations
    {
        [Description("Подсчет периметра")]
        GetPerimetr = 1,
        [Description("Подсчет площади")]
        GetArea,
        [Description("Вернуться назад")]
        back
    }
}
