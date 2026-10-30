using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai01Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            int expected = 0;
            int actual = o.getPositionOf2Cir(5, 5, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            int expected = 1;
            int actual = o.getPositionOf2Cir(3, 5, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            int expected = 2;
            int actual = o.getPositionOf2Cir(5, 3, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase04()
        {
            int expected = 3;
            int actual = o.getPositionOf2Cir(5, 3, 4);
            Assert.AreEqual(expected, actual);
        }
    }
}
