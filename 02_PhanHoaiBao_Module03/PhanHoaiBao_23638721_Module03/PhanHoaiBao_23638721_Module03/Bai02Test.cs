using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai02Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            char expected = 'A';
            char actual = o.CheckXYZ(1, 5, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            char expected = 'A';
            char actual = o.CheckXYZ(2, 5, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            char expected = 'B';
            char actual = o.CheckXYZ(5, 8, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase04()
        {
            char expected = 'C';
            char actual = o.CheckXYZ(5, 15, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase05()
        {
            char expected = 'D';
            char actual = o.CheckXYZ(5, 15, 8);
            Assert.AreEqual(expected, actual);
        }
    }
}
