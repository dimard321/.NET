using System.ComponentModel;

namespace DelegateDemo
{
    /// <summary>
    /// Перечисление, представляющее тип операции с сортировкой матрицы.
    /// </summary>
    enum OperationType
    {
        /// <summary>
        /// Сортировка по сумме элементов в строке матрицы.
        /// </summary>
        [Description("Сортировка по сумме элементов в строке")]
        SortSumOfMatrixRowElements,

        /// <summary>
        /// Сортировка по максимальному элементу в строке матрицы.
        /// </summary>
        [Description("Сортировка по максимальному элементу в строке")]
        SortOfMaxElementInARowOfTheMatrix,

        /// <summary>
        /// Сортировка по минимальному элементу в строке матрицы.
        /// </summary>
        [Description("Сортировка по минимальному элементу в строке")]
        SortOfMinElementInARowOfTheMatrix
    }
}
