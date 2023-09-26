namespace UnitTests
{
    /// <summary>
    /// Класс для посчета средней длины слов в предложении
    /// </summary>
    public static class AverageLength
    {
        /// <summary>
        /// Рассчитывает среднюю длину слова в тексте
        /// </summary>
        /// <param name="text">Входной текст</param>
        /// <returns>Средняя длина слова</returns>
        public static double CalculateAverageLength(string text)
        {
            var words = text.Split(new char[] { ' ', '.', ',', '!', '?', '@', '$', '%' }, StringSplitOptions.RemoveEmptyEntries);
            int totalLength = words.Sum(word => word.Length);
            return (double)totalLength / words.Length;
        }
    }
}
