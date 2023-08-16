using System;

namespace ArrayHelper
{
    /// <summary>
    /// Предоставляет методы для сортировки массива методом пузырька.
    /// </summary>
    public class ArraySort
    {
        /// <summary>
        /// Сортирует массив пузырьком в указанном порядке.
        /// </summary>
        /// <param name="array">Массив для сортировки.</param>
        /// <param name="sortType">Порядок сортировки (по возрастанию или убыванию).</param>
        public static void BubbleSort(double[] array, SortType sortType)
        {
            switch (sortType)
            {
                case SortType.ASC:
                    BubbleSortAsc(array);
                    break;
                case SortType.DESC:
                    BubbleSortDesc(array);
                    break;
            }
        }
        /// <summary>
        /// Сортирует массив пузырьком по возрастанию.
        /// </summary>
        /// <param name="array">Массив для сортировки.</param>
        public static void BubbleSortAsc(double[] array)
        {
            var n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
        }
        /// <summary>
        /// Сортирует массив пузырьком по убыванию.
        /// </summary>
        /// <param name="array">Массив для сортировки.</param>
        public static void BubbleSortDesc(double[] array)
        {

            var n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
        }
    }
}
   