using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai03Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = true;
            bool actualResult = o.primeCheck(3);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = false;
            bool actualResult = o.primeCheck(4);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void Testcase03()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.primeCheck(-100);
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod()]
        public void Testcase04()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.primeCheck(1005);
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestCase05()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = true;
            bool actualResult = o.primeCheck(0);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase06()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = false;
            bool actualResult = o.primeCheck(1000);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void Testcase07()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.primeCheck(-1);
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod()]
        public void Testcase08()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.primeCheck(1001);
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

    }
}
