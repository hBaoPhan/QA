using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai14Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            Assert.IsFalse(o.IsValidDate(2024, 13, 10));
        }

        [TestMethod]
        public void TestCase02()
        {
            Assert.IsFalse(o.IsValidDate(2024, 5, 0));
        }

        [TestMethod]
        public void TestCase03()
        {
            Assert.IsFalse(o.IsValidDate(2023, 2, 29));
        }

        [TestMethod]
        public void TestCase04()
        {
            Assert.IsTrue(o.IsValidDate(2024, 2, 29));
        }
    }
}
