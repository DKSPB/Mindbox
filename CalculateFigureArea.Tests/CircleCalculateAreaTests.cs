using NUnit.Framework;
using CalculateFigureArea.StandardFigures;
using System;

namespace CalculateFigureArea.Tests
{
    /// <summary>
    /// ����� ���������� ������� ������ "����"
    /// </summary>
    [TestFixture]
    public class CircleCalculateAreaTest
    {
        /// <summary>
        ///  ��������� ������, ��� ������� ������ ������������� ��� ����� 0
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
        /// ��������� ������, ��� ������� ������ �������������
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