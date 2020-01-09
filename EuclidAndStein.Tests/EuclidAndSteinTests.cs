using System;
using EuclidAndStein.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EuclidAndStein.Tests
{
    [TestClass]
    public class EuclidAndSteinTest
    {
        [TestMethod]
        public void EuclidGCD_Returns_Two()
        {
            // Act
            var actual = Solver.EuclidGCD(2, 4);

            // Assert
            Assert.AreEqual(2, actual);

        }

        [TestMethod]
        public void SteinGCD_Returns_Two()
        {
            // Act
            var actual = Solver.SteinGCD(2, 4);

            // Assert
            Assert.AreEqual(2, actual);

        }

        [TestMethod]
        public void ConvertToInt_Returns_One()
        {
            // Act
            var actual = Converter.ConvertToInt("1");

            // Assert
            Assert.AreEqual(1, actual[0]);

        }
    }
}
