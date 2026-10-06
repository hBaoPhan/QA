using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai06Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "Equilateral";
            String actualResult = o.Triangle(5,5,5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "Isosceles";
            String actualResult = o.Triangle(5, 5, 3);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "Isosceles";
            String actualResult = o.Triangle(3, 5, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase04()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "Isosceles";
            String actualResult = o.Triangle(3, 5, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase05()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "Scalene";
            String actualResult = o.Triangle(3, 4, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase06()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(-1, 4, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase07()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(4, -1, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase08()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(4, 5, -1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase09()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(1, 2, 5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(5, 1, 2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(1, 5, 3);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(0, 1, 2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(1, 0, 2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase14()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(1, 2, 0);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase15()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(1, 2, 3);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase16()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(1, 3, 2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCase17()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String expectedResult = "";
            String actualResult = o.Triangle(3, 1, 2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
