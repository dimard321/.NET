using System;

namespace ArrayHelper
{
    public class ArraySort
    {
        public static bool BubbleSort(int[] array, SortType sortType)
        {
            var result = false;
            switch(sortType)
            {
                case SortType.ASC:
                    result = BubbleSortAsc(array);
                    break;
                case SortType.DESC:
                    result = BubbleSortDesc(array);
                    break;
                default:
                    return result;
            }
            return result;
        }
        public static bool BubbleSortAsc(int[] array)
        {
            if (array == null)
            {
                return false;
            }

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)  // Проходим по всем элементам 
            {
                for (int j = 0; j < n - i - 1; j++)  //цикл для сравнения и перемещения элементов
                {
                    if (array[j] > array[j + 1])  // Если текущий элемент больше следующего
                    {
                        int per = array[j];      // Создаем временную переменную
                        array[j] = array[j + 1];  // Замена текущего элемента на следующий
                        array[j + 1] = per;      // Замена следующего элемента на временную переменную
                    }
                }
            }
            return true;
        }

        public static bool BubbleSortDesc(int[] array)
        {
            if (array == null)
            {
                return false;
            }
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int per = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = per;
                    }
                }
            }
            return true;
        }
    }
    
}