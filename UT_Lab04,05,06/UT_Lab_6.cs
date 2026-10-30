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
        public void BinToDec_TestAllCases_FromCSV()
        {
            // 1. Đọc dữ liệu
            string bin = Convert.ToString(TestContext.DataRow["bin"]);
            string expectedStr = Convert.ToString(TestContext.DataRow["expected"]);

            // 2. Chặn lỗi đọc CSV để in ra màn hình
            if (string.IsNullOrWhiteSpace(expectedStr))
            {
                Assert.Fail($"[LỖI ĐỌC CSV] Cột expected bị rỗng! Cột bin đang chứa giá trị: [{bin}]. Vui lòng kiểm tra lại dấu phẩy trong CSV.");
            }

            // 3. Phân luồng xử lý
            if (expectedStr.Trim().Equals("Exception", StringComparison.OrdinalIgnoreCase))
            {
                Exception expectedException = null;
                try
                {
                    o.BinToDec(bin);
                }
                catch (Exception ex)
                {
                    expectedException = ex;
                }
                Assert.IsNotNull(expectedException, $"Kỳ vọng văng lỗi với đầu vào bin=[{bin}] nhưng code chạy bình thường!");
            }
            else
            {
                // 4. Bọc an toàn chỗ parse số để báo lỗi rõ ràng
                long expectedResult = 0;
                try
                {
                    expectedResult = Convert.ToInt64(expectedStr.Trim());
                }
                catch (FormatException)
                {
                    Assert.Fail($"[LỖI ÉP KIỂU] Không thể chuyển chữ [{expectedStr}] thành số. Dữ liệu cột bin là [{bin}]");
                }

                long actualResult = o.BinToDec(bin);
                Assert.AreEqual(expectedResult, actualResult, $"Kết quả sai với đầu vào bin=[{bin}]");
            }
        }
    }
}
