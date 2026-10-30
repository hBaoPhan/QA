using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai08Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            string expected = "Khong phai pt";
            string actual = o.SolveQuadratic(0, 2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            string expected = "PT vô nghiệm";
            string actual = o.SolveQuadratic(1, 1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            string expected = "1.00";
            string actual = o.SolveQuadratic(1, -2, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase04()
        {
            string expected = "1.00,2.00";
            string actual = o.SolveQuadratic(1, -3, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
