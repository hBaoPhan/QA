using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai11Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "Truong dai hoc cong nghiep";
            String actualResult = o.ThayThe("Truong dh cong nghiep", "dh", "dai hoc");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abcdef";
            String actualResult = o.ThayThe("abcdef", "xyz", "123");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "abc";
            String actualResult = o.ThayThe("abc", "", "xyz");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase04()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.ThayThe("", "", "");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase05()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.ThayThe(null, "a", "b");
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
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.ThayThe("a", null, "b");
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestCase07()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.ThayThe("a", "b", null);
            }
            catch (Exception ex)
            {
                // Catches the exception
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestCase08()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "hi world";
            String actualResult = o.ThayThe("hello world", "hello", "hi");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase09()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "hello you";
            String actualResult = o.ThayThe("hello world", "world", "you");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "hello you";
            String actualResult = o.ThayThe("hello world", "world", "you");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "def";
            String actualResult = o.ThayThe("abc", "abc", "def");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.ThayThe("a", "a", "");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "a";
            String actualResult = o.ThayThe("a", "abc", "x");
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
