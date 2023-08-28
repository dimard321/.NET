using HomeWork3;

/// <summary>
/// Главный класс программы
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы
    /// </summary>
    /// <param name="args">Аргументы командной строки</param>
    static void Main(string[] args)
    {
        // Расчет средней длины слова
        var text = "Это какой то тект, за счет которого, будет высчитываться средняя длина слова";
        var averageWordLength = AverageLength.CalculateAverageLength(text);
        Console.WriteLine($"Средняя длина слов: {averageWordLength}");

        // Удвоение символов в строке
        var originalString = "omg i love shrek";
        var addeParameters = "o kek";
        var doubledString = DoubleParams.DoubleParameters(originalString, addeParameters);
        Console.WriteLine($"\nСоединение параметров: {doubledString}");

        // Сложение больших чисел
        var number1 = "123456789124658769312345678901234567890";
        var number2 = "9876987654767827293716768213355778679";
        var sum = LargeNumber.LargeNumbers(number1, number2);
        Console.WriteLine($"\nСумма больших чисел: {sum}");

        // Переворот слов в строке
        var sentence = "Иногда само понятие принципов тебе важнее, чем жизнь по ним.";
        var reversedWords = Reverse.ReverseWords(sentence);
        Console.WriteLine($"\nРазворот слов: {reversedWords}");

        //Поиск номера телефона
        FindNumbers.FindAndWritePhoneNumbers();
    }
}