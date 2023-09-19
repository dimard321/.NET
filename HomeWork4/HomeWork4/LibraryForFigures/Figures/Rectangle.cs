using LibraryForFigures.Interface;

namespace LibraryForFigures.Figures
{
    /// <summary>
    /// Класс представляющий прямоугольник
    /// </summary>
    public class Rectangle : IFigure
    {
        /// <summary>
        /// Длина прямоугольника
        /// </summary>
        private double length;
        /// <summary>
        /// ширина прямоугольника
        /// </summary>
        private double width;

        /// <summary>
        /// Инициализирует прямоугольник с длиной и шириной
        /// </summary>
        /// <param name="length">Длина прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        /// <summary>
        /// Вычисляет площадь прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника.</returns>
        public double CalculateArea()
        {
            return length * width;
        }
        /// <summary>
        /// Вычисляет периметр прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника.</returns>
        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
}
