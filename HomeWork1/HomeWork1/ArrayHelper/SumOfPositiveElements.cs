using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{
    public class SumOfPositiveElements
    {
        public static int GetSumOPositiveElements(int[,] array)
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
