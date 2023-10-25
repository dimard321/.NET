using System.ComponentModel;

namespace DelegateDemo
{
    /// <summary>
    /// Перечисление, представляющее тип сортировки.
    /// </summary>
    enum SortType
    {
        /// <summary>
        /// Сортировка в порядке возрастания.
        /// </summary>
        [Description("Сортировка по возрастанию")]
        ASC,

        /// <summary>
        /// Сортировка в порядке убывания.
        /// </summary>
        [Description("Сортировка по убыванию")]
        DESC
    }
}
