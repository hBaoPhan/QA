using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai08Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 16324.0;
            double actualResult = o.TinhTienDien(50,60);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 98483;
            double actualResult = o.TinhTienDien(0, 60);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 215050;
            double actualResult = o.TinhTienDien(0, 125);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase04()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 485705;
            double actualResult = o.TinhTienDien(0, 250);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase05()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 677847.5;
            double actualResult = o.TinhTienDien(0, 325);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase06()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 1097772.5;
            double actualResult = o.TinhTienDien(0, 475);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase07()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = -1;
            double actualResult = o.TinhTienDien(-10, 60);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase08()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = -1;
            double actualResult = o.TinhTienDien(60, 50);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase09()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = -1;
            double actualResult = o.TinhTienDien(60, -10);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 0;
            double actualResult = o.TinhTienDien(0, 0);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 81620;
            double actualResult = o.TinhTienDien(0, 50);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 83360.3;
            double actualResult = o.TinhTienDien(0, 51);
            Assert.AreEqual(expectedResult, actualResult, 0.1);
        }

        [TestMethod]
        public void TestCase13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 165935;
            double actualResult = o.TinhTienDien(0, 100);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase14()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 167899.6;
            double actualResult = o.TinhTienDien(0, 101);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase15()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 362395;
            double actualResult = o.TinhTienDien(0, 200);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase16()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 364861.2;
            double actualResult = o.TinhTienDien(0, 201);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase17()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 609015;
            double actualResult = o.TinhTienDien(0, 300);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase18()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 611768.3;
            double actualResult = o.TinhTienDien(0, 301);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase19()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 884345;
            double actualResult = o.TinhTienDien(0, 400);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase20()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = 887190.7;
            double actualResult = o.TinhTienDien(0, 401);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase21()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = -1;
            double actualResult = o.TinhTienDien(-1, 50);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase22()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = -1;
            double actualResult = o.TinhTienDien(50, -1);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestCase23()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            double expectedResult = -1;
            double actualResult = o.TinhTienDien(55, 54);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }
    }
}
