using System.ComponentModel;

namespace RectangleHelper
{
    /// <summary>
    /// Представляет действия, связанные с прямоугольником.
    /// </summary>
    public enum CaseForRectangle
    {
        [Description("Подсчет периметра")]
        perimetr = 1,
        [Description("Подсчет площади")]
        area,
        [Description("Вернуться назад")]
        back
    }
}
