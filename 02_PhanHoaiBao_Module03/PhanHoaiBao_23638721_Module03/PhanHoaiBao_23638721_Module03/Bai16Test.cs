using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai16Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            sbyte expected = -1;
            sbyte actual = o.BodyCheck(0, 60);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            sbyte expected = -1;
            sbyte actual = o.BodyCheck(170, -5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            sbyte expected = 2;
            sbyte actual = o.BodyCheck(170, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase04()
        {
            sbyte expected = 1;
            sbyte actual = o.BodyCheck(160, 65);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase05()
        {
            sbyte expected = 0;
            sbyte actual = o.BodyCheck(170, 55);
            Assert.AreEqual(expected, actual);
        }
    }
}
