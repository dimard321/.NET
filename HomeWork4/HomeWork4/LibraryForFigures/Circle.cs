namespace LibraryForFigures
{
    /// <summary>
    /// Класс представляющий окружность
    /// </summary>
    public class Circle : GeometryFigure
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        private double Radius;

        /// <summary>
        /// Инициализирует новый круг с заданным радиусом.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь окружности.
        /// </summary>
        /// <returns>Площадь окружности.</returns>
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Вычисляет периметр окружности.
        /// </summary>
        /// <returns>Периметр окружности.</returns>
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
