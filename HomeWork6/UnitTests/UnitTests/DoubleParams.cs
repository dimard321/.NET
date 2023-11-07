using System.Text;

namespace UnitTests
{
    /// <summary>
    /// Класс для дублирования символов в строке
    /// </summary>
    public static class DoubleParams
    {
        /// <summary>
        /// Удваивает указанные символы в строке.
        /// </summary>
        /// <param name="input">Исходная строка</param>
        /// <param name="charactersToDouble">Символы, которые нужно удвоить</param>
        /// <returns>Строка с удвоенными символами</returns>
        public static string DoubleParameters(string input, string charactersToDouble)
        {
            StringBuilder result = new StringBuilder();

            foreach (var a in input)
            {
                result.Append(a);
                if (charactersToDouble.Contains(a) && a != ' ')
                {
                    result.Append(a);
                }
            }

            return result.ToString();
        }
    }
}
