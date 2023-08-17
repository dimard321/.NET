using ArrayHelper;
using RectangleHelper;

namespace HomeWork1
{
    /// <summary>
    /// Основной класс программы в котором продемонстрирована реализация библиотек классов и интерфейса
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            var сorrectInput = false;
            do
            {
                Console.WriteLine("\nВыбор действия");
                Console.WriteLine("1. Сортировка пузырьком одномерного массива");
                Console.WriteLine("2. Сумма всех положительных элементов двумерного массива");
                Console.WriteLine("3. Работа с прямоугольником");
                Console.WriteLine("4. Выход");
                Console.Write("Введите номер действия: ");

                if (int.TryParse(Console.ReadLine(), out int choice) && Enum.IsDefined(typeof(MainMenuChoice), choice))
                {
                    MainMenuChoice mainMenuChoice = (MainMenuChoice)choice;

                    switch (mainMenuChoice)
                    {
                        case MainMenuChoice.BubbleSort:
                            BubbleSort();
                            break;
                        case MainMenuChoice.SumOfPositiveTerms:
                            SumOfPositiveTerms(); //код для двумерного массива
                            break;
                        case MainMenuChoice.Rectangle:
                            Rectangle();   //код для прямоугольника
                            break;
                        case MainMenuChoice.Exit:
                            сorrectInput = true;  //флаг для выхода 
                            break;
                        default:
                            Console.WriteLine("\n\nНекорректный выбор. Пожалуйста, выберите одну из доступных операций.");
                            break;
                    }
                }
            } while (!сorrectInput);
        }

        /// <summary>
        /// Выполняет сортировку пузырьком одномерного массива по возрастанию и убыванию.
        /// </summary>
        static void BubbleSort()
        {
            var invalidNumber = true;
            int size;

            do
            {
                Console.Write("\nВведите размер массива: ");
                invalidNumber = !int.TryParse(Console.ReadLine(), out size) || size <= 0;
                if (invalidNumber)
                {
                    Console.WriteLine("Некорректный размер. Пожалуйста, введите целое число.");
                }
            } while (invalidNumber);

            var array = new double[size];

            for (int i = 0; i < size; i++)
            {
                do
                {
                    Console.Write($"Введите элемент {i + 1} из {size}: ");
                    invalidNumber = !double.TryParse(Console.ReadLine(), out array[i]);

                    if (invalidNumber)
                    {
                        Console.WriteLine("Некорректное значение. Пожалуйста, введите число.");
                    }

                } while (invalidNumber);
            }

            Console.WriteLine("\nВведенный массив:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            var stayUntil = false;
            do
            {
                Console.WriteLine("\n\nВыберете действие:");
                Console.WriteLine("1. Сортировка по возрастанию");
                Console.WriteLine("2. Сортировка по убыванию");
                Console.WriteLine("3. Вернуться к предыдущим действиям");

                if (int.TryParse(Console.ReadLine(), out int choice) && Enum.IsDefined(typeof(BubbleSortType), choice))
                {
                    BubbleSortType choiceForBubble = (BubbleSortType)choice;

                    switch (choiceForBubble)
                    {
                        case BubbleSortType.ASC:
                            ArraySort.BubbleSort(array, SortType.ASC);
                            Console.WriteLine("\nСортировка по возрастанию:");
                            Console.WriteLine(string.Join(" ", array));
                            break;
                        case BubbleSortType.DESC:
                            ArraySort.BubbleSort(array, SortType.DESC);
                            Console.WriteLine("\nСортировка по убыванию:");
                            Console.WriteLine(string.Join(" ", array));
                            break;
                        case BubbleSortType.Back:
                            stayUntil = true;
                            break;
                        default:
                            Console.WriteLine("\n\nНекорректный выбор. Пожалуйста, выберите одну из доступных операций.");
                            break;
                    }

                }
            } while (!stayUntil);
        }

        /// <summary>
        /// Выполняет ввод двумерного массива и вычисляет сумму положительных элементов.
        /// </summary>
        static void SumOfPositiveTerms()
        {
            var invalidNumber = true;
            int rows, cols;

            do
            {
                Console.Write("Введите количество строк: ");
                invalidNumber = !int.TryParse(Console.ReadLine(), out rows) || rows <= 0;
                if (invalidNumber)
                {
                    Console.WriteLine("Некорректный размер. Пожалуйста, введите целое число.");
                }
            } while (invalidNumber);

            do
            {
                Console.Write("Введите количество столбцов: ");
                invalidNumber = !int.TryParse(Console.ReadLine(), out cols) || cols <= 0;
                if (invalidNumber)
                {
                    Console.WriteLine("Некорректный размер. Пожалуйста, введите целое число.");
                }
            } while (invalidNumber);

            double[,] twoDimensionalArray = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    do
                    {
                        Console.Write($"Введите элемент [{i + 1}, {j + 1}]: ");
                        invalidNumber = double.TryParse(Console.ReadLine(), out twoDimensionalArray[i, j]);
                        if (!invalidNumber)
                        {
                            Console.WriteLine("Некорректный значение. Пожалуйста, введите целое число.");
                        }
                    } while (!invalidNumber);
                }
            }

            Console.WriteLine("Введенный двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(twoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            var sum = SumOfPositiveElements
                .GetSumOfPositiveElements(twoDimensionalArray);
            Console.WriteLine($"Сумма положительных элементов: {sum}");
        }

        /// <summary>
        /// Выполняет ввод размеров прямоугольника и вычисляет его периметр и площадь.
        /// </summary>
        static void Rectangle()
        {
            double width, height;
            var invalidNumber = true;
            do
            {
                Console.Write("Введите ширину прямоугольника: ");
                invalidNumber = !double.TryParse(Console.ReadLine(), out width) || width <= 0;
                if (invalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите положительное число.");
                }
            } while (invalidNumber);
            do
            {
                Console.Write("Введите высоту прямоугольника: ");
                invalidNumber = !double.TryParse(Console.ReadLine(), out height) || height <= 0;

                if (invalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите положительное число.");
                }
            } while (invalidNumber);

            Rectangle rectangle = new Rectangle { Width = width, Height = height };

            var stayUntil = false; //не покидать цикл
            do
            {
                Console.WriteLine("\nВыберете действие:");
                Console.WriteLine("1. Высчитать периметр прямоугольника");
                Console.WriteLine("2. Высчитать площадь прямоугольника");
                Console.WriteLine("3. Вернуться к предыдущим действиям");

                if (int.TryParse(Console.ReadLine(), out int choice) && Enum.IsDefined(typeof(RectangleOperations), choice))
                {
                    RectangleOperations caseForRectangle = (RectangleOperations)choice;
                    switch (caseForRectangle)
                    {
                        case RectangleOperations.GetPerimetr:
                            double Perimeter = rectangle.Perimeter();
                            Console.WriteLine($"Периметр прямоугольника: {Perimeter}");
                            break;
                        case RectangleOperations.GetArea:
                            double Area = rectangle.Area();
                            Console.WriteLine($"Площадь прямоугольника: {Area}");
                            break;
                        case RectangleOperations.back:
                            stayUntil = true;  //флаг для выхода 
                            break;
                        default:
                            Console.WriteLine("\n\nНекорректный выбор. Пожалуйста, выберите одну из доступных операций.");
                            break;
                    }

                }
            } while (!stayUntil);
        }
    }
}
