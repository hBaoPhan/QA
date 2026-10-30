using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai17Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01()
        {
            // Ký tự trùng ngay tại vị trí đầu i = 0 (Nhánh Yes tại i = 0)
            int expected = 0;
            int actual = o.IsInString('s');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            // Ký tự trùng tại vị trí i > 0 (Duyệt qua ít nhất 1 lần No rồi Yes)
            int expected = 1;
            int actual = o.IsInString('t');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            // Ký tự không có trong chuỗi (Duyệt hết chuỗi đến '\0', vòng lặp kết thúc)
            int expected = Module03Methods.MAX_INT; // 32767
            int actual = o.IsInString('x');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase04_StatementCoverageUppercase()
        {
            // Kiểm tra với chuỗi hoa "Statement Coverage"
            int expected = 0;
            int actual = o.IsInString('S', "Statement Coverage");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase05_FoundMidString()
        {
            // Tìm ký tự 'a' tại vị trí index 2
            int expected = 2;
            int actual = o.IsInString('a');
            Assert.AreEqual(expected, actual);
        }
    }
}
