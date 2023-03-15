using NUnit.Framework;
using CalculateFigureArea.StandardFigures;
using System;

namespace CalculateFigureArea.Tests
{
    /// <summary>
    /// Тесты вычисления площади фигуры "Треугольник"
    /// </summary>
    [TestFixture]
    public class TriangleCalculateAreaTests
    {
        /// <summary>
        ///  Проверяет случай, при котором длина хотя бы одной из сторон отрицательна или равна 0
        /// </summary>
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1.1, 0, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -2.3, 10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 0, -10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-2, -3.4, -0));
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        [Test]
        public void IsRightTriangle()
        {
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5;

            bool controlValue = true;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRight = triangle.IsRightTriangle();

            Assert.That(isRight == controlValue);
        }

        /// <summary>
        /// Проверка, является ли треугольник не прямоугольным
        /// </summary>
        [Test]
        public void IsNotRightTriangle()
        {
            double sideA = 2.0;
            double sideB = 4.0;
            double sideC = 5;

            bool controlValue = false;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRight = triangle.IsRightTriangle();

            Assert.That(isRight == controlValue);
        }

        /// <summary>
        /// Тестирует вычисление площади тиугольника
        /// </summary>
        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            double triangleArea = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(6, triangleArea);
        }
    }
}
