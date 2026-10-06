using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai04Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = true;
            bool actualResult = o.IsLeapYear(2000);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = true;
            bool actualResult = o.IsLeapYear(2024);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = false;
            bool actualResult = o.IsLeapYear(1900);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase04()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = false;
            bool actualResult = o.IsLeapYear(2023);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Testcase05()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.IsLeapYear(1581);
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestCase06()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = false;
            bool actualResult = o.IsLeapYear(1582);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Testcase07()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.IsLeapYear(1581);
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
