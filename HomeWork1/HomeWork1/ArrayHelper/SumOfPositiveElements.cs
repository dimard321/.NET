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

            var Row = array.GetLength(0);
            var Column = array.GetLength(1);
            var Sum = 0.0;

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
