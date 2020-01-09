using System;
using EuclidAndStein.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EuclidAndStein.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Euclid_GCD_Is_Equal_Two()
        {
            // Act
            var actual = Solver.EuclidGCD(2, 4);

            // Assert
            Assert.AreEqual(2, actual);

        }

        [TestMethod]
        public void Stein_GCD_Is_Equal_Two()
        {
            // Act
            var actual = Solver.SteinGCD(2, 4);

            // Assert
            Assert.AreEqual(2, actual);

        }

        [TestMethod]
        public void Converter_Returns_One()
        {
            // Act
            var actual = Converter.ConvertToInt("1");

            // Assert
            Assert.AreEqual(1, actual[0]);

        }
    }
}
