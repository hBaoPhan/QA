using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai12Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            Assert.IsFalse(o.IsLeapYear(999));
        }

        [TestMethod]
        public void TestCase02()
        {
            Assert.IsTrue(o.IsLeapYear(2000));
        }

        [TestMethod]
        public void TestCase03()
        {
            Assert.IsFalse(o.IsLeapYear(1900));
        }

        [TestMethod]
        public void TestCase04()
        {
            Assert.IsTrue(o.IsLeapYear(2024));
        }

        [TestMethod]
        public void TestCase05()
        {
            Assert.IsFalse(o.IsLeapYear(2023));
        }
    }
}
