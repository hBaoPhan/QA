using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai05Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            Assert.AreEqual("Not a Triangle", o.Triangle(1, 2, 3));
        }

        [TestMethod]
        public void TestCase02()
        {
            Assert.AreEqual("Not a Triangle", o.Triangle(3, 1, 2));
        }

        [TestMethod]
        public void TestCase03()
        {
            Assert.AreEqual("Not a Triangle", o.Triangle(1, 3, 2));
        }

        [TestMethod]
        public void TestCase04()
        {
            Assert.AreEqual("Triangle is Scalene", o.Triangle(4, 5, 6));
        }

        [TestMethod]
        public void TestCase05()
        {
            Assert.AreEqual("Triangle is Isosceles", o.Triangle(2, 2, 3));
        }

        [TestMethod]
        public void TestCase06()
        {
            Assert.AreEqual("Not a Triangle", o.Triangle(2, 4, 2));
        }

        [TestMethod]
        public void TestCase07()
        {
            Assert.AreEqual("Triangle is Isosceles", o.Triangle(2, 3, 2));
        }

        [TestMethod]
        public void TestCase08()
        {
            Assert.AreEqual("Not a Triangle", o.Triangle(4, 2, 2));
        }

        [TestMethod]
        public void TestCase09()
        {
            Assert.AreEqual("Triangle is Isosceles", o.Triangle(3, 2, 2));
        }

        [TestMethod]
        public void TestCase10()
        {
            Assert.AreEqual("Triangle is Equilateral", o.Triangle(3, 3, 3));
        }
    }
}
