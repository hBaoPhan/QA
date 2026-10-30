using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai15Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            Assert.IsFalse(o.EmailCheck("user@domain"));
        }

        [TestMethod]
        public void TestCase02()
        {
            Assert.IsFalse(o.EmailCheck("user..name@domain.com"));
        }

        [TestMethod]
        public void TestCase03()
        {
            Assert.IsFalse(o.EmailCheck("userdomain.com"));
        }

        [TestMethod]
        public void TestCase04()
        {
            Assert.IsFalse(o.EmailCheck("user@.domain.com"));
        }

        [TestMethod]
        public void TestCase05()
        {
            Assert.IsTrue(o.EmailCheck("user@gmail.com"));
        }
    }
}
