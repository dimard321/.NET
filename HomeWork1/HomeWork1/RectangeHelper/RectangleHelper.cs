using System;

namespace RectangleHelper
{
    public class Rectangle
    {
        
        public double Width { get; set; } //хранение ширины прямоугольника
        public double Height { get; set; } //хранение ширины прямоугольника

        public double Perimeter()
        {
            if (Width <= 0 || Height <= 0)
            {
                throw new InvalidOperationException("Некорректные размеры прямоугольника");
                
            }

            return 2 * (Width + Height);
        }

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