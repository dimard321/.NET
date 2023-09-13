namespace LibraryForFigures
{
    /// <summary>
    /// Класс представляющий треугольник
    /// </summary>
    public class Triangle : GeometryFigure
    {
        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        double sideA;
        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        double sideB;
        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        double sideC;

        /// <summary>
        /// Инициализирует новый экземпляр треугольника с указанными длинами его сторон.
        /// </summary>
        /// <param name="sideA">Длина первой стороны треугольника.</param>
        /// <param name="sideB">Длина второй стороны треугольника.</param>
        /// <param name="sideC">Длина третьей стороны треугольника.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <returns>Значение площади треугольника.</returns>
        public override double CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        /// <summary>
        /// Вычисляет периметр треугольника.
        /// </summary>
        /// <returns>Значение периметра треугольника.</returns>
        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
