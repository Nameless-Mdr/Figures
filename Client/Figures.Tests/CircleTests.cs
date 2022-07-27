using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Figures.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Get_Perimeter_ReturnsValue()
        {
            // arrange
            var radius = 5;

            var expected = Math.PI * radius * 2;

            // act
            var circle = new Circle(radius);
            var result = circle.Perimeter();

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Get_Square_ReturnsValue()
        {
            // arrange
            var radius = 5;

            var expected = Math.PI * radius * radius;

            // act
            var circle = new Circle(radius);
            var result = circle.Square();

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}
