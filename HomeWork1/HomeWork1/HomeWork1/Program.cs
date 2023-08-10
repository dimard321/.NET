using ArrayHelper;
using RectangleHelper;

namespace HomeWork1
{
    class Program
    {


        public static void Main(string[] args)
        {

            bool CorrectInput = false;

            do
            {
                Console.WriteLine("\nВыбор действия");
                Console.WriteLine("Сортировка пузырьком одномерного массива: Нажмите 1");
                Console.WriteLine("Сумма всех положительных элементов двумерного массива: Нажмите 2");
                Console.WriteLine("Работа с прямоугольником: Нажмите 3");
                Console.WriteLine("Выход: Нажмите 4");
                Console.Write("Введите номер действия: ");

                int choice = int.Parse(Console.ReadLine());

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
                        Console.WriteLine("\n\nНекорректное выбор. Пожалуйста, выберите одну из доступных операций.");
                        break;
                }

            } while (!CorrectInput);
        }

        static void BubbleSort()
        {
            bool InvalidNumber;
            int Size;
            do {
                Console.Write("\nВведите размер массива: ");
                InvalidNumber = int.TryParse(Console.ReadLine(), out Size);
                if (!InvalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите целое число.");
                }
            }while(!InvalidNumber);



            int[] array = new int[Size];

            for (int i = 0; i < Size; i++)
            {
                
                do
                {
                    Console.Write($"Введите элемент {i + 1} из {Size}: ");
                    InvalidNumber = int.TryParse(Console.ReadLine(), out array[i]); //попытка преобразования в int

                    if (!InvalidNumber)
                    {
                        Console.WriteLine("Некорректный значение. Пожалуйста, введите целое число.");
                    }
                } while (!InvalidNumber);
            }


            Console.WriteLine("\nВведенный массив:");
            for (int i = 0; i < Size; i++)
            {
                Console.Write(array[i] + " ");
            }

            bool StayUntil = false;
            do
            {
                Console.WriteLine("\n\nВыберете действие:");
                Console.WriteLine("Сортировка по возрастанию: Нажмите 1");
                Console.WriteLine("Сортировка по убыванию: Нажмите 2");
                Console.WriteLine("Вернуться к предыдущим действиям: Нажмите 3");

                int ChoiceForBubble = int.Parse(Console.ReadLine());



                switch (ChoiceForBubble)
                {
                    case 1:
                        ArraySort.BubbleSort(array,SortType.ASC);
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

            } while (!StayUntil); //пока не станет true(кейс 3)

        }


        static void SumOfPositiveTerms()
        {
            bool InvalidNumber;
            int rows, cols;
            do
            {
                Console.Write("Введите количество строк: ");
                InvalidNumber = int.TryParse(Console.ReadLine(), out rows);
                if (!InvalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите целое число.");
                }
            } while (!InvalidNumber);
            do
            {
                Console.Write("Введите количество столбцов: ");
                InvalidNumber = int.TryParse(Console.ReadLine(), out cols);
                if (!InvalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите целое число.");
                }
            } while (!InvalidNumber);
                int[,] TwoDimensionalArray = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                    do
                    {
                        Console.Write($"Введите элемент [{i + 1}, {j + 1}]: ");
                        InvalidNumber = int.TryParse(Console.ReadLine(), out TwoDimensionalArray[i, j]);
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


            int sum = SumOfPositiveElements.GetSumOPositiveElements(TwoDimensionalArray);
            Console.WriteLine($"Сумма положительных элементов: {sum}");

        }


        static void Rectangle()
        {
            double width, height;
            bool InvalidNumber;
            do
            {
                Console.Write("Введите ширину прямоугольника: ");
                InvalidNumber = double.TryParse(Console.ReadLine(), out width);
                if (!InvalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите целое число.");
                }

                Console.Write("Введите высоту прямоугольника: ");
                InvalidNumber = double.TryParse(Console.ReadLine(), out height);
                
                if (!InvalidNumber)
                {
                    Console.WriteLine("Некорректный значение. Пожалуйста, введите целое число.");
                }

            }while (!InvalidNumber);

             Rectangle rectangle = new Rectangle { Width = width, Height = height };

            bool StayUntil = false; //не покидать цикл
            do
            {

                Console.WriteLine("\nВыберете действие:");
                Console.WriteLine("Высчитать периметр прямоугольника: Нажмите 1");
                Console.WriteLine("Высчитать площадь прямоугольника: Нажмите 2");
                Console.WriteLine("Вернуться к предыдущим действиям: Нажмите 3");

                int ChoiceForRectangle = int.Parse(Console.ReadLine());

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
