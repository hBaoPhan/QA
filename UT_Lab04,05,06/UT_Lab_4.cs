using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using MethodLibrary;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class UT_Lab_4
    {
        private MethodLibrary.MethodLibrary lib = new MethodLibrary.MethodLibrary();
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\csv\\UT_Lab_4.csv", "UT_Lab_4#csv", DataAccessMethod.Sequential)]
        [DeploymentItem("csv\\UT_Lab_4.csv", "csv")]
        public void HuyChuoi_TestAllCases_FromCSV()
        {
            string s = TestContext.DataRow["s"].ToString();
            int n = int.Parse(TestContext.DataRow["n"].ToString());
            int p = int.Parse(TestContext.DataRow["p"].ToString());
            string expected = TestContext.DataRow["expected"].ToString();

            string actual = lib.HuyChuoi(s, n, p);
            Assert.AreEqual(expected, actual, $"s={s}, n={n}, p={p}");
        }

        [TestMethod]
        public void HuyChuoi_InvalidType_n()
        {
            Assert.ThrowsException<FormatException>(() => int.Parse("a"));
        }

        [TestMethod]
        public void HuyChuoi_InvalidType_p()
        {
            Assert.ThrowsException<FormatException>(() => int.Parse("b"));
        }
    }
}