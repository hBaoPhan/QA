using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai13Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            Assert.IsFalse(o.PasswordCheck("Abc1"));
        }

        [TestMethod]
        public void TestCase02()
        {
            Assert.IsFalse(o.PasswordCheck("Abcdef123456"));
        }

        [TestMethod]
        public void TestCase03()
        {
            Assert.IsFalse(o.PasswordCheck("Password"));
        }

        [TestMethod]
        public void TestCase04()
        {
            Assert.IsTrue(o.PasswordCheck("Pass123"));
        }
    }
}
