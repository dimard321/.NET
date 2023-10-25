namespace DelegateDemo
{
    /// <summary>
    /// Класс для сортировки матрицы с использованием различных стратегий.
    /// </summary>
    public class BubbleSortArray
    { 
    /// <summary>
    /// Метод для сортировки двумерного массива с использованием пузырьковой сортировки на основе заданных условий.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив для сортировки.</param>
    /// <param name="comparer">Функция сравнения элементов массива.</param>
    /// <param name="sortType">Функция, определяющая способ сравнения элементов массива.</param>
    /// <returns>Отсортированный двумерный массив.</returns>
        public int[,] BubbleSortByCondition(int[,] matrix, Comparison<int> comparer, Func<int[,], int, int, int, (int, int)> sortType)
    {
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                int comparativeValue1 = 0;

                int comparativeValue2 = 0;

                (comparativeValue1, comparativeValue2) = sortType(matrix, comparativeValue1, comparativeValue2, j);

                if (comparer(comparativeValue1, comparativeValue2) > 0)
                {
                    SwapRows(matrix, j, j + 1);
                }
            }
        }
        return matrix;
    }

    /// <summary>
    /// Метод для нахождения минимальных элементов в двух строках массива.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <param name="min1">Минимальное значение в первой строке.</param>
    /// <param name="min2">Минимальное значение во второй строке.</param>
    /// <param name="j">Индекс строки для сравнения.</param>
    /// <returns>Минимальные значения в двух строках.</returns>
    public (int, int) MinElements(int[,] matrix, int min1, int min2, int j)
    {
        min1 = int.MaxValue;

        min2 = int.MaxValue;

        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (matrix[j, k] < min1)
            {
                min1 = matrix[j, k];
            }
            if (matrix[j + 1, k] < min2)
            {
                min2 = matrix[j + 1, k];
            }
        }

        return (min1, min2);
    }

    /// <summary>
    /// Метод для нахождения максимальных элементов в двух строках массива.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <param name="max1">Максимальное значение в первой строке.</param>
    /// <param name="max2">Максимальное значение во второй строке.</param>
    /// <param name="j">Индекс строки для сравнения.</param>
    /// <returns>Максимальные значения в двух строках.</returns>
    public (int, int) MaxElements(int[,] matrix, int max1, int max2, int j)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (matrix[j, k] > max1)
            {
                max1 = matrix[j, k];
            }
            if (matrix[j + 1, k] > max2)
            {
                max2 = matrix[j + 1, k];
            }
        }

        return (max1, max2);
    }

    /// <summary>
    /// Метод для нахождения суммы элементов в двух строках массива.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <param name="sum1">Сумма элементов в первой строке.</param>
    /// <param name="sum2">Сумма элементов во второй строке.</param>
    /// <param name="j">Индекс строки для сравнения.</param>
    /// <returns>Сумма элементов в двух строках.</returns>
    public (int, int) SumInRows(int[,] matrix, int sum1, int sum2, int j)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            sum1 += matrix[j, k];

            sum2 += matrix[j + 1, k];
        }

        return (sum1, sum2);
    }

    /// <summary>
    /// Метод для сортировки двумерного массива по возрастанию максимального элемента в строке.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <returns>Отсортированный двумерный массив.</returns>
    public int[,] BubbleSortByMaxElementInRowAsc(int[,] matrix)
    {
        return BubbleSortByCondition(matrix, (min, max) => min.CompareTo(max), MaxElements);
    }

    /// <summary>
    /// Метод для сортировки двумерного массива по убыванию максимального элемента в строке.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <returns>Отсортированный двумерный массив.</returns>
    public int[,] BubbleSortByMaxElementInRowDesc(int[,] matrix)
    {
        return BubbleSortByCondition(matrix, (min, max) => max.CompareTo(min), MaxElements);
    }

    /// <summary>
    /// Метод для сортировки двумерного массива по возрастанию суммы элементов в строке.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <returns>Отсортированный двумерный массив.</returns>
    public int[,] BubbleSortBySumElementsInRowAsc(int[,] matrix)
    {
        return BubbleSortByCondition(matrix, (x, y) => x.CompareTo(y), SumInRows);
    }

    /// <summary>
    /// Метод для сортировки двумерного массива по убыванию суммы элементов в строке.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <returns>Отсортированный двумерный массив.</returns>
    public int[,] BubbleSortBySumElementsInRowDesc(int[,] matrix)
    {
        return BubbleSortByCondition(matrix, (x, y) => y.CompareTo(x), SumInRows);
    }

    /// <summary>
    /// Метод для сортировки двумерного массива по возрастанию минимального элемента в строке.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <returns>Отсортированный двумерный массив.</returns>
    public int[,] BubbleSortByMinElementsInRowAsc(int[,] matrix)
    {
        return BubbleSortByCondition(matrix, (x, y) => x.CompareTo(y), MinElements);
    }

    /// <summary>
    /// Метод для сортировки двумерного массива по убыванию минимального элемента в строке.
    /// </summary>
    /// <param name="matrix">Исходный двумерный массив.</param>
    /// <returns>Отсортированный двумерный массив.</returns>
    public int[,] BubbleSortByMinElementsInRowDesc(int[,] matrix)
    {
        return BubbleSortByCondition(matrix, (x, y) => y.CompareTo(x), MinElements);
    }

    /// <summary>
    /// Метод для изменения порядка двух строк в двумерном массиве.
    /// </summary>
    /// <param name="matrix">Двумерный массив.</param>
    /// <param name="row1">Индекс первой строки.</param>
    /// <param name="row2">Индекс второй строки.</param>
    private void SwapRows(int[,] matrix, int row1, int row2)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            (matrix[row2, i], matrix[row1, i]) = (matrix[row1, i], matrix[row2, i]);
        }
    }
    }
}