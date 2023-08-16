using ArrayHelper;
using RectangleHelper;

namespace HomeWork1
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            var CorrectInput = false;
            do
            {
                Console.WriteLine("\nВыбор действия");
                Console.WriteLine("1. Сортировка пузырьком одномерного массива");
                Console.WriteLine("2. Сумма всех положительных элементов двумерного массива");
                Console.WriteLine("3. Работа с прямоугольником");
                Console.WriteLine("4. Выход");
                Console.Write("Введите номер действия: ");

                var choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BubbleSort();  //код для одномерного массива
                        break;
                    case 2:
                        SumOfPositiveTerms(); //код для двумерного массива
                        break;
                    case 3:
                        Rectangle();   //код для прямоугольника
                        break;
                    case 4:
                        CorrectInput = true;  //флаг для выхода 
                        break;
                    default:
                        Console.WriteLine("\n\nНекорректный выбор. Пожалуйста, выберите одну из доступных операций.");
                        break;
                }

            } while (!CorrectInput);
        }

        /// <summary>
        /// Выполняет сортировку пузырьком одномерного массива по возрастанию и убыванию.
        /// </summary>
        static void BubbleSort()
        {
            var InvalidNumber = true;
            int Size;

            do
            {
                Console.Write("\nВведите размер массива: ");
                InvalidNumber = !int.TryParse(Console.ReadLine(), out Size) || Size <= 0;
                if (InvalidNumber)
                {
                    Console.WriteLine("Некорректный размер. Пожалуйста, введите целое число.");
                }
            } while (InvalidNumber);

            var array = new double[Size];

            for (int i = 0; i < Size; i++)
            {
                do
                {
                    Console.Write($"Введите элемент {i + 1} из {Size}: ");
                    InvalidNumber = !double.TryParse(Console.ReadLine(), out array[i]);

                    if (InvalidNumber)
                    {
                        Console.WriteLine("Некорректное значение. Пожалуйста, введите число.");
                    }

                } while (InvalidNumber);
            }

            Console.WriteLine("\nВведенный массив:");
            for (int i = 0; i < Size; i++)
            {
                Console.Write(array[i] + " ");
            }

            var StayUntil = false;
            do
            {
                Console.WriteLine("\n\nВыберете действие:");
                Console.WriteLine("1. Сортировка по возрастанию");
                Console.WriteLine("2. Сортировка по убыванию");
                Console.WriteLine("3. Вернуться к предыдущим действиям");

                var ChoiceForBubble = int.Parse(Console.ReadLine());

                switch (ChoiceForBubble)
                {
                    case 1:
                        ArraySort.BubbleSort(array, SortType.ASC);
                        Console.WriteLine("\nСортировка по возрастанию:");
                        Console.WriteLine(string.Join(", ", array));
                        break;
                    case 2:
                        ArraySort.BubbleSort(array, SortType.DESC);
                        Console.WriteLine("\nСортировка по убыванию:");
                        Console.WriteLine(string.Join(", ", array));
                        break;
                    case 3:
                        StayUntil = true;  //флаг для выхода 
                        break;
                    default:
                        Console.WriteLine("\n\nНекорректный выбор. Пожалуйста, выберите одну из доступных операций.");
                        break;
                }

            } while (!StayUntil);
        }

        /// <summary>
        /// Выполняет ввод двумерного массива и вычисляет сумму положительных элементов.
        /// </summary>
        static void SumOfPositiveTerms()
        {
            var InvalidNumber = true;
            int rows, cols;

            do
            {
                Console.Write("Введите количество строк: ");
                InvalidNumber = !int.TryParse(Console.ReadLine(), out rows) || rows <= 0;
                if (InvalidNumber)
                {
                    Console.WriteLine("Некорректный размер. Пожалуйста, введите целое число.");
                }
            } while (InvalidNumber);

            do
            {
                Console.Write("Введите количество столбцов: ");
                InvalidNumber = !int.TryParse(Console.ReadLine(), out cols) || cols <= 0;
                if (InvalidNumber)
                {
                    Console.WriteLine("Некорректный размер. Пожалуйста, введите целое число.");
                }
            } while (InvalidNumber);

            double[,] TwoDimensionalArray = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    do
                    {
                        Console.Write($"Введите элемент [{i + 1}, {j + 1}]: ");
                        InvalidNumber = double.TryParse(Console.ReadLine(), out TwoDimensionalArray[i, j]);
                        if (!InvalidNumber)
                        {
                            Console.WriteLine("Некорректный значение. Пожалуйста, введите целое число.");
                        }
                    } while (!InvalidNumber);
                }
            }


            Console.WriteLine("Введенный двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(TwoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }


            var sum = SumOfPositiveElements.GetSumOfPositiveElements(TwoDimensionalArray);
            Console.WriteLine($"Сумма положительных элементов: {sum}");

        }

        /// <summary>
        /// Выполняет ввод размеров прямоугольника и вычисляет его периметр и площадь.
        /// </summary>
        static void Rectangle()
        {
            double width, height;
            var InvalidNumber = true;
            do
            {
                Console.Write("Введите ширину прямоугольника: ");
                InvalidNumber = !double.TryParse(Console.ReadLine(), out width) || width <= 0;
                if (InvalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите положительное число.");
                }
            } while (InvalidNumber);
            do
            {
                Console.Write("Введите высоту прямоугольника: ");
                InvalidNumber = !double.TryParse(Console.ReadLine(), out height) || height <= 0;

                if (InvalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите положительное число.");
                }

            } while (InvalidNumber);

            Rectangle rectangle = new Rectangle { Width = width, Height = height };

            var StayUntil = false; //не покидать цикл
            do
            {

                Console.WriteLine("\nВыберете действие:");
                Console.WriteLine("1. Высчитать периметр прямоугольника");
                Console.WriteLine("2. Высчитать площадь прямоугольника");
                Console.WriteLine("3. Вернуться к предыдущим действиям");

                var ChoiceForRectangle = int.Parse(Console.ReadLine());

                switch (ChoiceForRectangle)
                {
                    case 1:

                        double Perimeter = rectangle.Perimeter();
                        Console.WriteLine($"Периметр прямоугольника: {Perimeter}");
                        break;
                    case 2:
                        double Area = rectangle.Area();
                        Console.WriteLine($"Площадь прямоугольника: {Area}");
                        break;
                    case 3:
                        StayUntil = true;  //флаг для выхода 
                        break;

                    default:
                        Console.WriteLine("\n\nНекорректный выбор. Пожалуйста, выберите одну из доступных операций.");
                        break;
                }

            } while (!StayUntil);
        }
    }
}
