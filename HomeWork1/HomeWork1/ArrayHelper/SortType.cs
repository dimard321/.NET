using System.ComponentModel;

namespace ArrayHelper
{
    /// <summary>
    /// Представляет тип сортировки массива.
    /// </summary>
    public enum SortType
    {
        [Description("Сортировка по возрастанию")]
        ASC = 1,
        [Description("Сортировка по убыванию")]
        DESC
    }
}
