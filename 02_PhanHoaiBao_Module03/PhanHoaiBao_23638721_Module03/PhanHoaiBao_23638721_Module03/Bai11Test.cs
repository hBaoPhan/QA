using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;
using System;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai11Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCase01()
        {
            o.IsPointInRectangle(5, 2, 3, 4, 4, 3);
        }

        [TestMethod]
        public void TestCase02()
        {
            bool actual = o.IsPointInRectangle(1, 1, 5, 5, 6, 3);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            bool actual = o.IsPointInRectangle(1, 1, 5, 5, 3, 6);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestCase04()
        {
            bool actual = o.IsPointInRectangle(1, 1, 5, 5, 3, 3);
            Assert.IsTrue(actual);
        }
    }
}
