using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design.Serialization;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAlgebra
    {
        public void AssertEqual(double a, double b)
        {
            Assert.AreEqual(a, b, 0.0001);
        }

        public void AssertTuple(Tuple<double, double> tuple, double a, double b)
        {
            AssertEqual(tuple.Item1, a);
            AssertEqual(tuple.Item2, b);
        }

        [TestMethod]
        public void TestMethodSquareEquationa1b5c6()
        {
            //Arrange
            double a = 1, b = 5, c = 6;

            // Act
            var result = ClassLibrary1.AlgebraClass.SquareEquation(a, b, c);

            // Assert
            AssertTuple(result, -2, -3);
        }

        [TestMethod]
        public void TestMethodSquareEquationa2b4c2()
        {
            // Arrange
            double a = 2, b = 4, c = 2;

            // Act
            var result = ClassLibrary1.AlgebraClass.SquareEquation(a, b, c);

            // Assert
            AssertTuple(result, -1, -1);
        }

        [TestMethod]
        public void TestMethodSquareEquationa3b18c27()
        {
            // Arrange
            double a = 3, b = -18, c = 27;

            // Act
            var result = ClassLibrary1.AlgebraClass.SquareEquation(a, b, c);

            // Assert
            AssertTuple(result, 3, 3);
        }

        [TestMethod]
        public void TestMethodSquareEquationa1b2c1()
        {
            // Arrange
            double a = 1, b = 2, c = 1;

            // Act
            var result = ClassLibrary1.AlgebraClass.SquareEquation(a, b, c);

            // Assert
            AssertTuple(result, -1, -1);
        }

        public void TestMethodSquareEquationa1b4c5()
        {
            // Arrange
            double a = 1, b = -4, c = 5;

            // Act
            var result = ClassLibrary1.AlgebraClass.SquareEquation(a, b, c);

            // Assert
            AssertTuple(result, 1, 5);
        }

        public void TestMethodSquareEquationa1b2c10()
        {
            // Arrange
            double a = 1, b = -2, c = 10;

            // Act
            var result = ClassLibrary1.AlgebraClass.SquareEquation(a, b, c);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestMethodSolveLinearEquation_returnPositiveInf()
        {
            //Arrange
            double a = 0, b = 0;

            //Act
            var result = ClassLibrary1.AlgebraClass.SolveLinearEquation(a, b);

            //Assert
            Assert.AreEqual(double.PositiveInfinity, result);
        }

        [TestMethod]
        public void TestMethodSolveLinearEquation_returnNaN()
        {
            //Arrange
            double a = 0, b = 5;

            //Act
            var result = ClassLibrary1.AlgebraClass.SolveLinearEquation(a, b);

            //Assert
            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void TestMethodSolveLinearEquation_returnResult()
        {
            //Arrange
            double a = 3, b = -6;

            //Act
            var result = ClassLibrary1.AlgebraClass.SolveLinearEquation(a, b);

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethodSeriesSumReturnSums()
        {
            double a = 1, b = 2, c = 3, d = 4, e = 5;

            var result = ClassLibrary1.AlgebraClass.SeriesSum(a, b, c, d, e);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMethodMaxSeriesSum()
        {
            double a = 1, b = 2, c = 3, d = 4, e = 5;

            var result = ClassLibrary1.AlgebraClass.MaxSeriesSum(a, b, c, d, e);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethodAverageSeriesSum()
        {
            double a = 1, b = 2, c = 3, d = 4, e = 5;

            var result = ClassLibrary1.AlgebraClass.AverageSeriesSum(a, b, c, d, e);

            Assert.AreEqual(3, result);
        }
    }
}
