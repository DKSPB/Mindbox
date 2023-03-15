using System;
using System.Linq;

namespace CalculateFigureArea.StandardFigures
{
    public class Triangle : IFigure
    {
        private readonly double _sideA;

        private readonly double _sideB;

        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA <=0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Все стороны треугольника должны быть больше 0");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public double CalculateArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;

            double triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));

            return triangleArea;
        }

        public bool IsRightTriangle()
        {
            return ((_sideA * _sideA + _sideB * _sideB == _sideC * _sideC) ||
                (_sideA * _sideA + _sideC * _sideC == _sideB * _sideB) || 
                (_sideC * _sideC + _sideB * _sideB == _sideA * _sideA)) is true;
        }
    }
}
