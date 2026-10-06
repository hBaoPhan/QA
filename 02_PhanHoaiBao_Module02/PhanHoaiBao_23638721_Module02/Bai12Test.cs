using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai12Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int expectedResult = 7;
            int actualResult = o.Largest(new int[] { 1, 3, 5, 7, 4, 6 });
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase02()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.Largest(null);
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int expectedResult = 2147483647;
            int actualResult = o.Largest(new int[] {});
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase04()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int expectedResult = 7;
            int actualResult = o.Largest(new int[] {7});
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase05()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int expectedResult = 5;
            int actualResult = o.Largest(new int[] { -2147483648, 2, 1, 5 });
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase06()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int expectedResult = 2147483647;
            int actualResult = o.Largest(new int[] { 2147483647, 5, 99 });
            Assert.AreEqual(expectedResult, actualResult);
        }

  
    }
}
