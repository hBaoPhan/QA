using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai07Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            byte expected = 31;
            byte actual = o.DaysInMonth(2026, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            byte expected = 30;
            byte actual = o.DaysInMonth(2026, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            byte expected = 29;
            byte actual = o.DaysInMonth(2000, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase04()
        {
            byte expected = 28;
            byte actual = o.DaysInMonth(1900, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase05()
        {
            byte expected = 29;
            byte actual = o.DaysInMonth(2024, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase06()
        {
            byte expected = 28;
            byte actual = o.DaysInMonth(2023, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase07()
        {
            byte expected = 0;
            byte actual = o.DaysInMonth(2026, 13);
            Assert.AreEqual(expected, actual);
        }
    }
}
