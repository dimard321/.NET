namespace LibraryForFigures.Interface
{
    /// <summary>
    /// Абстрактный базовый класс для геометрических фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateArea();
        /// <summary>
        /// Вычисляет периметр фигуры.
        /// </summary>
        /// <returns>Периметр фигуры.</returns>
        public double CalculatePerimeter();
    }
}