using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai04Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            int expected = 0;
            int actual = o.Max(0, 0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            int expected = 4;
            int actual = o.Max(2, 3, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            int expected = 3;
            int actual = o.Max(3, 2, 1);
            Assert.AreEqual(expected, actual);
        }
    }
}
