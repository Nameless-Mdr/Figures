using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Figures.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Get_Perimeter_ReturnsValue()
        {
            // arrange
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;

            var expected = side1 + side2 + side3;

            // act
            var triangle = new Triangle(side1, side2, side3);
            var result = triangle.Perimeter();

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Get_Square_ReturnsValue()
        {
            // arrange
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;

            var p = (side1 + side2 + side3) / 2;

            var expected = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

            // act
            var triangle = new Triangle(side1, side2, side3);
            var result = triangle.Square();

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}
