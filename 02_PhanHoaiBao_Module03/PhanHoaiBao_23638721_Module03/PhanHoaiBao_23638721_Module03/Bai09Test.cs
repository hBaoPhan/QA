using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai09Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            bool actual = o.IsTriangle(-1, 2, 3);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            bool actual = o.IsTriangle(1, 2, 3);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            bool actual = o.IsTriangle(1, 4, 2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestCase04()
        {
            bool actual = o.IsTriangle(5, 2, 2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestCase05()
        {
            bool actual = o.IsTriangle(3, 4, 5);
            Assert.IsTrue(actual);
        }
    }
}
