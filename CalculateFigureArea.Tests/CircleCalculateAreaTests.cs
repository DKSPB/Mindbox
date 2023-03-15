using NUnit.Framework;
using CalculateFigureArea.StandardFigures;
using System;

namespace CalculateFigureArea.Tests
{
    /// <summary>
    /// Тесты вычисления площади фигуры "Круг"
    /// </summary>
    [TestFixture]
    public class CircleCalculateAreaTest
    {
        /// <summary>
        ///  Проверяет случай, при котором радиус отрицательный или равен 0
        /// </summary>
        [Test]
        public void CircleNegativeOrZeroRadiusTest()
        {
            double circleRadius = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(circleRadius));

            circleRadius = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(circleRadius));
        }

        /// <summary>
        /// Проверяет случай, при котором радиус положительный
        /// </summary>
        [Test]
        public void CirclePositiveRadiusTest()
        {
            double circleRadius = 5;

            Circle circle = new Circle(circleRadius);

            double area = circle.CalculateArea();

            double controlValue = 78.54;
            Assert.That(area == controlValue);
        }
    }
}