using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestGeomatryClass
    {
        [TestMethod]
        public void TestMethodAreaTriangle() 
        {
            double a = 10, b = 15, c = 10;

            var result = ClassLibrary1.GeometryClass.AreaTriangle(a, b, c);
            double trueResult = 49.6078370824611;
            double delta = 0.0001;
            Assert.AreEqual(trueResult, result, delta);
        }

        [TestMethod]
        public void TestMethodCalculateRightTriangleAreafirst()
        {
            double leg1 = 5, leg2 = 10;

            var results = ClassLibrary1.GeometryClass.CalculateRightTriangleArea(leg1, leg2);

            Assert.AreEqual(25, results);
        }

        [TestMethod]
        public void TestMethodCalculateRightTriangleAreasecond()
        {
            double leg1 = 2, leg2 = 10;

            var results = ClassLibrary1.GeometryClass.CalculateRightTriangleArea(leg1, leg2);

            Assert.AreEqual(10, results);
        }

        [TestMethod]
        public void TestMethodCalculateRightTriangleAreaThirth()
        {
            double leg1 = 5, leg2 = 5;

            var results = ClassLibrary1.GeometryClass.CalculateRightTriangleArea(leg1, leg2);

            Assert.AreEqual(12.5, results);
        }

        [TestMethod]
        public void TestMethodAreaRectangle()
        {
            double len = 5, widht = 10;

            var result = ClassLibrary1.GeometryClass.AreaRectangle(len, widht);

            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestMEthodCalculateCircleArea()
        {
            double radius = 8;

            var res = ClassLibrary1.GeometryClass.CalculateCircleArea(radius);
            double trueRes = 201.061929829747;
            double delta = 0.001;
            Assert.AreEqual(trueRes, res, delta);
        }

        [TestMethod]
        public void TestMethodTrapezeSquare()
        {
            double a = 9, b = 6, h = 3;

            var res = ClassLibrary1.GeometryClass.TrapezeSquare(a, b, h);
            double delta = 0.001;
            double trueRes = 10;
            Assert.AreEqual(trueRes, res, delta);
        }
    }
}
