using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai13Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = true;
            bool actualResult = o.IsSymmetry(new int[] { 1, 3, 4, 3, 1 }, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = true;
            bool actualResult = o.IsSymmetry(new int[] { 1,2,2, 1 }, 4);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = false;
            bool actualResult = o.IsSymmetry(new int[] { 1, 2, 3, 4 }, 4);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase04()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.IsSymmetry(null, 0);
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
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.IsSymmetry(new int[] { 1, 2, 3, 4 }, -2);
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
            bool expectedResult = true;
            bool actualResult = o.IsSymmetry(new int[] { }, 0);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase07()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResult = true;
            bool actualResult = o.IsSymmetry(new int[] { 5 }, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase08()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.IsSymmetry(new int[] { 1, 2, 3, 4 }, -1);
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestCase09()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.IsSymmetry(new int[] { 1, 2, 3, 4 }, 5);
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
