using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using MethodLibrary;

namespace PhanHoaiBao_23638721_Module02
{
    [TestClass]
    public class UT_Lab_5
    {
        private MethodLibrary.MethodLibrary lib = new MethodLibrary.MethodLibrary();
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
      "|DataDirectory|\\csv\\UT_Lab_5.csv", "UT_Lab_5#csv", DataAccessMethod.Sequential)]
        [DeploymentItem("csv\\UT_Lab_5.csv", "csv")]
        public void ThayThe_TestAllCases_FromCSV()
        {
            // 1. Đọc dữ liệu thô từ CSV
            string s1Raw = Convert.ToString(TestContext.DataRow["s1"]);
            string s2Raw = Convert.ToString(TestContext.DataRow["s2"]);
            string s3Raw = Convert.ToString(TestContext.DataRow["s3"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);

            // 2. Ép chuỗi "null" thành giá trị null thực tế trong C#
            string s1 = (s1Raw == "null") ? null : s1Raw;
            string s2 = (s2Raw == "null") ? null : s2Raw;
            string s3 = (s3Raw == "null") ? null : s3Raw;

            // 3. Xử lý test dựa trên Expected
            if (expected.StartsWith("Lỗi"))
            {
                // Nếu CSV ghi là "Lỗi...", ta kỳ vọng hàm quăng ra Exception
                var exception = Assert.ThrowsException<Exception>(() => lib.ThayThe(s1, s2, s3));

                // Kiểm tra câu thông báo lỗi có giống trong CSV không
                Assert.AreEqual(expected, exception.Message, $"Thông báo lỗi không khớp! s1=[{s1}], s2=[{s2}], s3=[{s3}]");
            }
            else
            {
                // Trường hợp chạy bình thường không có lỗi
                string actual = lib.ThayThe(s1, s2, s3);
                Assert.AreEqual(expected, actual, $"Kết quả sai! s1=[{s1}], s2=[{s2}], s3=[{s3}]");
            }
        }
    }
}