using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai09Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long expectedResult = 1;
            long actualResult = o.Sum(-1, out _);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long expectedResult = 1;
            long actualResult = o.Sum(0, out _);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long expectedResult = 6;
            long actualResult = o.Sum(5, out _);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
