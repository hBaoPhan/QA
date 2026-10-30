using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai06Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            double expected = 6;
            double actual = o.Average(6, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            double expected = 3;
            double actual = o.Average(6, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            double expected = 0;
            double actual = o.Average(6, -1);
            Assert.AreEqual(expected, actual);
        }
    }
}
