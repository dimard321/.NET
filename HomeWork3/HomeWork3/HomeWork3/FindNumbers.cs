using System.Text.RegularExpressions;

namespace HomeWork3
{
    /// <summary>
    /// Класс для поиска и записи номеров телефонов
    /// </summary>
    public static class FindNumbers
    {
        /// <summary>
        /// Находит номера телефонов в тексте, записывает их в файл и выводит на консоль
        /// </summary>
        public static void FindAndWritePhoneNumbers()
        {
            string inputFilePath = "Text.txt";
            string outputFilePath = "Numbers.txt";

            string inputText = File.ReadAllText(inputFilePath);

            List<string> phoneNumbers = FindPhoneNumbers(inputText);

            WritePhoneNumbersToFile(phoneNumbers, outputFilePath);

            Console.WriteLine("\nНайденные номера телефонов:");
            foreach (string phoneNumber in phoneNumbers)
            {
                Console.WriteLine(phoneNumber);
            }
        }

        /// <summary>
        /// Находит номера телефонов в тексте с использованием регулярных выражений
        /// </summary>
        /// <param name="text">Текст для поиска</param>
        /// <returns>Список найденных номеров телефонов</returns>
        public static List<string> FindPhoneNumbers(string text)
        {
            List<string> phoneNumbers = new List<string>();
            Regex regex = new Regex(@"\+?\d+ ?\(\d+\) ?\d+-?\d+-?\d+");

            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                phoneNumbers.Add(match.Value);
            }

            return phoneNumbers;
        }

        /// <summary>
        /// Записывает список номеров телефонов в файл
        /// </summary>
        /// <param name="phoneNumbers">Список номеров телефонов</param>
        /// <param name="filePath">Путь к файлу для записи</param>
        public static void WritePhoneNumbersToFile(List<string> phoneNumbers, string filePath)
        {
            File.WriteAllLines(filePath, phoneNumbers);
        }
    }
}
