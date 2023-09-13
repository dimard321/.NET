using LibraryForFigures;

namespace Figures
{
    /// <summary>
    /// Главный класс программы
    /// </summary>
    class Figures
    {
        /// <summary>
        /// Главный метод программы предоставляеющий пользователю выбор 
        /// </summary>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите фигуру для расчета:");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Треугольник");
                Console.WriteLine("3. Квадрат");
                Console.WriteLine("4. Прямоугольник");
                Console.WriteLine("5. Выйти");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch ((ActionForFigures)choice)
                    {
                        case ActionForFigures.Circle:
                            double circleRadius;
                            do
                            {
                                Console.Write("Введите радиус круга: ");
                            } while (!double.TryParse(Console.ReadLine(), out circleRadius) || circleRadius < 0);

                            Circle circle = new Circle(circleRadius);
                            Console.WriteLine("Площадь круга: " + circle.CalculateArea() + ", Периметр круга: " + circle.CalculatePerimeter());
                            break;

                        case ActionForFigures.Triangle:
                            double sideA = 0, sideB = 0, sideC = 0;
                            do
                            {
                                Console.Write("Введите длины сторон треугольника (через пробел): ");
                                string[] triangleSides = Console.ReadLine().Split();
                                if (triangleSides.Length != 3 ||
                                    !double.TryParse(triangleSides[0], out sideA) || sideA <= 0 ||
                                    !double.TryParse(triangleSides[1], out sideB) || sideB <= 0 ||
                                    !double.TryParse(triangleSides[2], out sideC) || sideC <= 0)
                                {
                                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                                }
                            } while (sideA <= 0 || sideB <= 0 || sideC <= 0);
                            Triangle triangle = new Triangle(sideA, sideB, sideC);
                            Console.WriteLine("Площадь треугольника: " + triangle.CalculateArea() + ", Периметр треугольника: " + triangle.CalculatePerimeter());
                            break;

                        case ActionForFigures.Square:
                            double squareSide;
                            do
                            {
                                Console.Write("Введите длину стороны квадрата: ");
                            } while (!double.TryParse(Console.ReadLine(), out squareSide) || squareSide < 0);
                            Square square = new Square(squareSide);
                            Console.WriteLine("Площадь квадрата: " + square.CalculateArea() + ", Периметр квадрата: " + square.CalculatePerimeter());
                            break;

                        case ActionForFigures.Rectangle:
                            double length = 0, width = 0;
                            do
                            {
                                Console.Write("Введите длину и ширину прямоугольника (через пробел): ");
                                string[] rectangleSize = Console.ReadLine().Split();
                                if (rectangleSize.Length != 2 ||
                                    !double.TryParse(rectangleSize[0], out length) || length <= 0 ||
                                    !double.TryParse(rectangleSize[1], out width) || width <= 0)
                                {
                                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                                }
                            } while (length <= 0 || width <= 0);
                            Rectangle rectangle = new Rectangle(length, width);
                            Console.WriteLine("Площадь прямоугольника: " + rectangle.CalculateArea() + ", Периметр прямоугольника: " + rectangle.CalculatePerimeter());
                            break;

                        case ActionForFigures.Exit:
                            Console.WriteLine("Программа завершена.");
                            return;

                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введите число.");
                }
            }
        }
    }
}