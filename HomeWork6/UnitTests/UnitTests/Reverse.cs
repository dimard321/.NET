namespace UnitTests
{
    /// <summary>
    /// Класс для переворота строки
    /// </summary>
    public static class Reverse
    {
        /// <summary>
        /// Переворачивает слова в строке
        /// </summary>
        /// <param name="sentence">Исходная строка</param>
        /// <returns>Строка с перевернутыми словами</returns>
        public static string ReverseWords(string sentence)
        {
            var words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
