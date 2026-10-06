using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class Bai05Test
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long expectedResult = 6;
            long actualResult = o.BinToDec("110");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Testcase05()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.BinToDec("102bfg");
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
