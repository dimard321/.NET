using LibraryStringToInt;
using NLog;

namespace UI
{
    /// <summary>
    /// Главный класс протграмы
    /// </summary>
    class Program
    {
        /// <summary>
        /// Логгер для записи событий и ошибок
        /// </summary>
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Главный метод программы 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var converter = new Converter(logger);

            Console.Write("Введите строку для преобразования: ");
            var input = Console.ReadLine();

            try
            {
                var result = converter.Convert(input);
                Console.WriteLine($"Преобразование выполнено");
            }
            catch
            {
                Console.WriteLine($"Ошибка. Для ознакомления загляните в файл errors");
            }
        }
    }
}
