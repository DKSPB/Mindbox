using System;

namespace CalculateFigureArea.StandardFigures
{
    public class Circle : IFigure
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть больше нуля");
            }
            _radius = radius;
        }
        public double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }
    }
}
