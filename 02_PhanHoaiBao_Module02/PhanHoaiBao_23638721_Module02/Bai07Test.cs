using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhanHoaiBao_23638721_Module02

{
    [TestClass]
    public class Bai07Test
    {
        [TestMethod()]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1, x2;
            string kqMongDoi = "Vô số nghiệm";

            // Gọi trực tiếp qua biến o vì hàm trong DLL không biên dịch ở dạng static
            string kqThucTe = o.SolveQuadratic(0, 0, 0, out x1, out x2);

            Assert.AreEqual(kqMongDoi, kqThucTe);
            Assert.IsTrue(float.IsNaN(x1));
            Assert.IsTrue(float.IsNaN(x2));
        }

        [TestMethod()]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1, x2;
            string kqMongDoi = "Vô nghiệm";

            string kqThucTe = o.SolveQuadratic(0, 0, 1, out x1, out x2);

            Assert.AreEqual(kqMongDoi, kqThucTe);
            Assert.IsTrue(float.IsNaN(x1));
            Assert.IsTrue(float.IsNaN(x2));
        }

        [TestMethod()]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1, x2;
            string kqMongDoi = "Có 1 nghiệm";

            string kqThucTe = o.SolveQuadratic(0, 2, -4, out x1, out x2);

            Assert.AreEqual(kqMongDoi, kqThucTe);
            Assert.AreEqual(2.0f, x1);
            Assert.AreEqual(2.0f, x2);
        }

        [TestMethod()]
        public void TestCase04()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1, x2;
            string kqMongDoi = "Có 2 nghiệm phân biệt";

            string kqThucTe = o.SolveQuadratic(1, 3, 2, out x1, out x2);

            Assert.AreEqual(kqMongDoi, kqThucTe);
            Assert.AreEqual(-1.0f, x1);
            Assert.AreEqual(-2.0f, x2);
        }

        [TestMethod()]
        public void TestCase05()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1, x2;
            string kqMongDoi = "Có nghiệm kép";

            string kqThucTe = o.SolveQuadratic(1, 2, 1, out x1, out x2);

            Assert.AreEqual(kqMongDoi, kqThucTe);
            Assert.AreEqual(-1.0f, x1);
            Assert.AreEqual(-1.0f, x2);
        }

        [TestMethod()]
        public void TestCase06()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            float x1, x2;
            string kqMongDoi = "Vô nghiệm";

            string kqThucTe = o.SolveQuadratic(1, 1, 1, out x1, out x2);

            Assert.AreEqual(kqMongDoi, kqThucTe);
            Assert.IsTrue(float.IsNaN(x1));
            Assert.IsTrue(float.IsNaN(x2));
        }
    }
} 
