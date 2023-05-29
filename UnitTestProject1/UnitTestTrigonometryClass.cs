using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestTrigonometryClass
    {
        [TestMethod]
        public void TestMethodCalculateSins()
        {
            double x1 = 4;

            var res = ClassLibrary1.TrigonometryClass.CalculateSins(x1);
            double trueRes = -0.756802495307928;
            double delta = 0.001;
            Assert.AreEqual(trueRes, res, delta);
        }

        [TestMethod]
        public void TestMethodCalculateCos()
        {
            double x1 = 4;

            var res = ClassLibrary1.TrigonometryClass.CalculateCos(x1);
            double trueRes = -0.653643620863612;
            double delta = 0.001;
            Assert.AreEqual(trueRes, res, delta);
        }

        [TestMethod]
        public void TestMethodCalculateTg()
        {
            double x1 = 4;

            var res = ClassLibrary1.TrigonometryClass.CalculateTg(x1);
            double trueRes = 1.15782128234958;
            double delta = 0.001;
            Assert.AreEqual(trueRes, res, delta);
        }

        [TestMethod]
        public void TestMethodCalculateCtg()
        {
            double x1 = 4;

            var res = ClassLibrary1.TrigonometryClass.CalculateCtg(x1);
            double trueRes = 0.863691154450617;
            double delta = 0.001;
            Assert.AreEqual(trueRes, res, delta);
        }

        [TestMethod]
        public void TestMethodCalculateAsin()
        {
            double x1 = 0.2;

            var res = ClassLibrary1.TrigonometryClass.CalculateAsin(x1);
            double trueRes = 0.201357920790331;
            double delta = 0.001;
            Assert.AreEqual(trueRes, res, delta);
        }
    }
}
