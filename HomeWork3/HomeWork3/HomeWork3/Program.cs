using HomeWork3;
using System.Numerics;

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

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Расчет средней длины слов");
            Console.WriteLine("2. Удвоение символов в строке");
            Console.WriteLine("3. Сложение больших чисел");
            Console.WriteLine("4. Переворот слов в строке");
            Console.WriteLine("5. Поиск номера телефона");
            Console.WriteLine("6. Выход");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Пожалуйста, введите числовой выбор.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите текст:");
                    var text = Console.ReadLine();
                    var averageWordLength = AverageLength.CalculateAverageLength(text);
                    Console.WriteLine($"Средняя длина слов: {averageWordLength}\n");
                    break;
                case 2:
                    Console.WriteLine("Введите первую строку:");
                    var firstString = Console.ReadLine();
                    Console.WriteLine("Введите вторую строку для добавления:");
                    var addeParameters = Console.ReadLine();
                    var doubledString = DoubleParams.DoubleParameters(firstString, addeParameters);
                    Console.WriteLine($"Соединение параметров: {doubledString}\n");
                    break;
                case 3:
                    string number1, number2;
                    do
                    {
                        Console.WriteLine("Введите первое число:");
                        number1 = Console.ReadLine();
                        if (!BigInteger.TryParse(number1, out _))
                        {
                            Console.WriteLine("Неверное значение. Пожалуйста введите число.");
                        }
                    } 
                    while (!BigInteger.TryParse(number1, out _));

                    do
                    {
                        Console.WriteLine("Введите второе число:");
                        number2 = Console.ReadLine();
                        if (!BigInteger.TryParse(number2, out _))
                        {
                            Console.WriteLine("Неверное значение. Пожалуйста введите число.");
                        }
                    } 
                    while (!BigInteger.TryParse(number2, out _));

                    var sum = LargeNumber.LargeNumbers(number1, number2);
                    Console.WriteLine($"Сумма чисел: {sum}");
                    break;
                case 4:
                    Console.WriteLine("Введите предложение:");
                    var sentence = Console.ReadLine();
                    var reversedWords = Reverse.ReverseWords(sentence);
                    Console.WriteLine($"Разворот слов: {reversedWords} \n");
                    break;
                case 5:
                    FindNumbers.FindPhoneNumbers();
                    break;
                case 6:
                    Console.WriteLine("Выход");
                    return;
                default:
                    Console.WriteLine("Некорректное значение. Пожалуйста выберите действие из списка.");
                    break;
            }
        }
    }
}
