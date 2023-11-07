namespace UnitTests
{
    /// <summary>
    /// Класс для посчета большого числа
    /// </summary>
    public static class LargeNumber
    {
        /// <summary>
        /// Складывает два больших числа, представленных строками
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="number2">Второе число</param>
        /// <returns>Результат сложения</returns>
        public static string LargeNumbers(string number1, string number2)
        {
            var maxLength = Math.Max(number1.Length, number2.Length);
            number1 = number1.PadLeft(maxLength, '0');
            number2 = number2.PadLeft(maxLength, '0');

            var transfer = 0;
            string result = "";

            for (var i = maxLength - 1; i >= 0; i--)
            {
                var sum = (number1[i] - '0') + (number2[i] - '0') + transfer;
                transfer = sum / 10;
                result = (sum % 10) + result;
            }

            if (transfer > 0)
                result = transfer + result;

            return result;
        }
    }
}
