using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class UT_Lab04
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "aef";
            String actualResult = o.HuyChuoi("abcdef",1,3);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", -2, 3);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", 7, 3);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase04()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", 4, -2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase05()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", 2, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase06()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "a";
            String actualResult = o.HuyChuoi("a", 0, 0);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase07()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", 0, 0);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase08()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcde";
            String actualResult = o.HuyChuoi("abcdef", 5, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase09()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", 1, 3);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", -1, 2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", 6, 2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", 3, -1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.HuyChuoi("abcdef", 3, 4);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
