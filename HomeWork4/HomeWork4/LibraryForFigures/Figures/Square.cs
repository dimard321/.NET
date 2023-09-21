using LibraryForFigures.Interface;

namespace LibraryForFigures.Figures
{
    /// <summary>
    /// Класс представляющий квадрат
    /// </summary>
    public class Square : IFigure
    {
        /// <summary>
        /// Сторона квадрата
        /// </summary>
        double side;

        /// <summary>
        /// Инициализирует новый экземпляр квадрата с указанной длиной стороны.
        /// </summary>
        /// <param name="side">Длина стороны квадрата.</param>
        public Square(double side)
        {
            this.side = side;
        }

        /// <summary>
        /// Вычисляет площадь квадрата.
        /// </summary>
        /// <returns>Значение площади квадрата.</returns>
        public double CalculateArea()
        {
            return side * side;
        }

        /// <summary>
        /// Вычисляет периметр квадрата.
        /// </summary>
        /// <returns>Значение периметра квадрата.</returns>
        public double CalculatePerimeter()
        {
            return 4 * side;
        }
    }
}
