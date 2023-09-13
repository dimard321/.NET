namespace LibraryForFigures
{
    /// <summary>
    /// Класс представляющий квадрат
    /// </summary>
    public class Square : GeometryFigure
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
        public override double CalculateArea()
        {
            return side * side;
        }

        /// <summary>
        /// Вычисляет периметр квадрата.
        /// </summary>
        /// <returns>Значение периметра квадрата.</returns>
        public override double CalculatePerimeter()
        {
            return 4 * side;
        }
    }
}
