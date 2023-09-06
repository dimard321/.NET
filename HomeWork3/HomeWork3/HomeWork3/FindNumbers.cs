using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace HomeWork3
{
    /// <summary>
    /// Класс для поиска и записи номеров телефонов
    /// </summary>
    public static class FindNumbers
    {
        /// <summary>
        /// Метод для чтения телефонных номеров из файла.
        /// </summary>
        /// <param name="inputFilePath">Путь к файлу, из которого нужно считать номера.</param>
        /// <returns>Список найденных номеров телефонов.</returns>
        public static List<string> ReadPhoneNumbers(string inputFilePath)
        {
            List<string> phoneNumbers = new List<string>();

            try
            {
                var inputText = File.ReadAllText(inputFilePath);

                // Регулярное выражение для поиска телефонных номеров
                Regex regex = new Regex(@"\+?\d+ ?\(\d+\) ?\d+-?\d+-?\d+");

                MatchCollection matches = regex.Matches(inputText);
                foreach (Match match in matches)
                {
                    phoneNumbers.Add(match.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
            return phoneNumbers;
        }
        /// <summary>
        /// Метод для записи телефонных номеров в файл.
        /// </summary>
        /// <param name="phoneNumbers">Список номеров телефонов для записи.</param>
        /// <param name="outputFilePath">Путь к файлу, в который нужно записать номера.</param>
        public static void WritePhoneNumbersToFile(List<string> phoneNumbers, string outputFilePath)
        {
            try
            {
                File.WriteAllLines(outputFilePath, phoneNumbers);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи файла: {ex.Message}");
            }
        }
        /// <summary>
        /// Находит телефонные номера, записывает их в файл
        /// </summary>
        public static void FindPhoneNumbers()
        {
            var extractableFile = ("Text.txt");
            var insertedFile = ("Numbers.txt");

            List<string> phoneNumbers = ReadPhoneNumbers(extractableFile);
            WritePhoneNumbersToFile(phoneNumbers, insertedFile);
            Console.WriteLine("Копирование успешно выполнено. Вот найденые номера\n");
            foreach (string phoneNumber in phoneNumbers)
            {
                Console.WriteLine(phoneNumber);
            }
            Console.WriteLine("");//это чтобы пропуск был после номеров
        }
    }
}
