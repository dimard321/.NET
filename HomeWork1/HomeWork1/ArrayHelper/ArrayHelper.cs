using System;

namespace ArrayHelper
{
    public class BubbleSort
    {
        public static bool ASCSort(int[] array)
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

        public static bool DescSort(int[] array)
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

        public class ArrayOperations
        {

            public static int SumOfPositiveElements(int[,] array)
            {
                if (array == null)
                {
                    return -1;
                }

                int Row = array.GetLength(0);
                int Column = array.GetLength(1);
                int Sum = 0;

                for (int i = 0; i < Row; i++)  // Проходим по строкам
                {
                    for (int j = 0; j < Column; j++)  // Проходим по столбцам
                    {
                        if (array[i, j] > 0)  // Если текущий элемент положительный
                        {
                            Sum += array[i, j];  // Добавляем элемент к сумме
                        }
                    }
                }

                return Sum;  // Возвращаем сумму 
            }
        }
    }
}