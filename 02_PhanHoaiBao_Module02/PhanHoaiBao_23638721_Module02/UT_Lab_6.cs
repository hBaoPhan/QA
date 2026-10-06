using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class UT_Lab_6
    {
      
        private MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\csv\\UT_Lab_6.csv", "UT_Lab_6#csv", DataAccessMethod.Sequential)]
        [DeploymentItem("csv\\UT_Lab_6.csv", "csv")]
        public void Sum_TestAllCases_FromCSV()
        {
            // 1. Đọc dữ liệu đầu vào (n) và kết quả kỳ vọng (expected)
            int n = Convert.ToInt32(TestContext.DataRow["n"]);
            long expectedResult = Convert.ToInt64(TestContext.DataRow["expected"]);

            // 2. Gọi hàm Sum (tham số out bị bỏ qua bằng dấu _)
            long actualResult = o.Sum(n, out _);

            // 3. So sánh kết quả
            Assert.AreEqual(expectedResult, actualResult, $"Kết quả sai khi n = {n}");
        }
    }
}
