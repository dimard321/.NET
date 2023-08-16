namespace ArrayHelper
{
    public class SumOfPositiveElements
    {
        /// <summary>
        /// Метод для подсчета суммы положительных членов двумерного массива
        /// </summary>
        /// <param name="array">Двумерный массив для подсчета</param>
        /// <returns>Сумма положительных элементов</returns>
        public static double GetSumOfPositiveElements(double[,] array)
        {
            if (array is null)
            {
                return -1;
            }

            var row = array.GetLength(0);
            var column = array.GetLength(1);
            var sum = 0.0;

            for (int i = 0; i < row; i++)  // Проходим по строкам
            {
                for (int j = 0; j < column; j++)  // Проходим по столбцам
                {
                    if (array[i, j] > 0)  // Если текущий элемент положительный
                    {
                        sum += array[i, j];  // Добавляем элемент к сумме
                    }
                }
            }

            return sum;  // Возвращаем сумму 
        }
    }
}
