using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai03Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            double mean;
            int actual = o.MaxAndMean(3, 2, 1, out mean);
            Assert.AreEqual(3, actual);
            Assert.AreEqual(2.0, mean, 0.001);
        }

        [TestMethod]
        public void TestCase02()
        {
            double mean;
            int actual = o.MaxAndMean(2, 1, 3, out mean);
            // Theo đúng code trong PDF dòng 9 (Maximum = B):
            Assert.AreEqual(1, actual);
            Assert.AreEqual(2.0, mean, 0.001);
        }

        [TestMethod]
        public void TestCase03()
        {
            double mean;
            int actual = o.MaxAndMean(1, 3, 2, out mean);
            Assert.AreEqual(3, actual);
            Assert.AreEqual(2.0, mean, 0.001);
        }

        [TestMethod]
        public void TestCase04()
        {
            double mean;
            int actual = o.MaxAndMean(1, 2, 3, out mean);
            Assert.AreEqual(3, actual);
            Assert.AreEqual(2.0, mean, 0.001);
        }
    }
}
