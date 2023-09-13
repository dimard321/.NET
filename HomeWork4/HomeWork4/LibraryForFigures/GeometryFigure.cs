namespace LibraryForFigures
{
    /// <summary>
    /// Абстрактный базовый класс для геометрических фигур
    /// </summary>
    public abstract class GeometryFigure
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public abstract double CalculateArea();
        /// <summary>
        /// Вычисляет периметр фигуры.
        /// </summary>
        /// <returns>Периметр фигуры.</returns>
        public abstract double CalculatePerimeter();
    }
}