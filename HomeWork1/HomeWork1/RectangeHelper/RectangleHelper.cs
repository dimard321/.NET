namespace RectangleHelper
{
    /// <summary>
    /// Представляет методы для вычисления периметра и площади прямоугольника
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Получает или устанавливает ширину прямоугольника.
        /// </summary>
        public double Width { get; set; } 

        /// <summary>
        /// Получает или устанавливает высоту прямоугольника.
        /// </summary>
        public double Height { get; set; } 

        /// <summary>
        /// Вычисляет периметр прямоугольника.
        /// </summary>
        /// <returns>Периметр прямоугольника.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если размеры прямоугольника некорректны.</exception>
        public double Perimeter()
        {
            if (Width <= 0 || Height <= 0)
            {
                throw new InvalidOperationException("Некорректные размеры прямоугольника");
                
            }

            return 2 * (Width + Height);
        }
        /// <summary>
        /// Вычисляет площадь прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если размеры прямоугольника некорректны.</exception>
        public double Area()
        {
            if (Width <= 0 || Height <= 0)
            {
                throw new InvalidOperationException("Некорректные размеры прямоугольника");
                
            }

            return Width * Height;
        }
    }
}