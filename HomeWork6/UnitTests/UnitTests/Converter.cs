using System.Numerics;
using NLog;

namespace UnitTests
{
    /// <summary>
    /// Класс для преобразования строки в целое число
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// Логгер для записи событий и ошибок
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Инициализирует экземпляр класса Converter с заданным логгером
        /// </summary>
        /// <param name="logger">Логгер для записи событий и ошибок</param>
        public Converter(ILogger logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Метод для преобразования строки в целое число
        /// </summary>
        /// <param name="input">Входная строка для преобразования</param>
        /// <returns>Результат преобразования в виде целого числа BigInteger</returns>
        /// <exception cref="ArgumentException">Вызывается если входная строка пуста или содержит только пробелы</exception>
        /// <exception cref="FormatException">Вызывается если в строке обнаружен недопустимый символ</exception>
        public BigInteger Convert(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                _logger.Error("Входная строка пуста или содержит только пробелы.");
                throw new ArgumentException("Входная строка пуста или содержит только пробелы.");
            }

            BigInteger result = 0;
            var index = 0;
            var negativeNum = false;

            if (input[0] == '-')
            {
                negativeNum = true;
                index = 1;
            }
            else if (input[0] == '+')
            {
                index = 1;
            }

            for (int i = index; i < input.Length; i++)
            {
                var charIsNum = input[i];

                if (char.IsDigit(charIsNum))
                {
                    var valueIsNum = charIsNum - '0';
                    result = result * 10 + valueIsNum;
                }
                else
                {
                    _logger.Error($"В строке обнаружен недопустимый символ '{charIsNum}' в позиции {i}.");
                    throw new FormatException($"В строке обнаружен недопустимый символ '{charIsNum}' в позиции {i}.");
                }
            }
            _logger.Info($"Преобразование строки в целое число: {result}");
            return negativeNum ? -result : result;
        }
    }
}
