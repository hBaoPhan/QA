using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;
using System;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai10Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCase01()
        {
            o.CalculateBill(-10, 10, 15, 20);
        }

        [TestMethod]
        public void TestCase02()
        {
            float expected = 800;
            float actual = o.CalculateBill(80, 10, 15, 20);
            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void TestCase03()
        {
            float expected = 1300;
            float actual = o.CalculateBill(120, 10, 15, 20);
            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void TestCase04()
        {
            float expected = 1950;
            float actual = o.CalculateBill(160, 10, 15, 20);
            Assert.AreEqual(expected, actual, 0.001f);
        }
    }
}
