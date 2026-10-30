using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Library;

namespace PhanHoaiBao_23638721_Module03
{
    [TestClass]
    public class Bai18Test
    {
        private Module03Methods o = new Module03Methods();

        [TestMethod]
        public void TestCase01_EmptyString()
        {
            // Chuỗi rỗng: điều kiện while false ngay từ đầu
            long expected = 0;
            long actual = o.HexToDec("");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02_Digits()
        {
            // Chuỗi chữ số thập phân "059" (0*256 + 5*16 + 9 = 89)
            long expected = 89;
            long actual = o.HexToDec("059");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03_Lowercase()
        {
            // Chuỗi ký tự thường "ace" (10*256 + 12*16 + 14 = 2766)
            long expected = 2766;
            long actual = o.HexToDec("ace");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase04_Uppercase()
        {
            // Chuỗi ký tự hoa "ACD" (10*256 + 12*16 + 13 = 2765)
            long expected = 2765;
            long actual = o.HexToDec("ACD");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase05_DefaultBranch()
        {
            // Chuỗi có ký tự ngoài hexa "1G" kích hoạt nhánh default
            long expected = 1;
            long actual = o.HexToDec("1G");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase06_AllCasesCombined()
        {
            // Kết hợp cả số, chữ hoa, chữ thường: "1A3f" -> 6719
            long expected = 6719;
            long actual = o.HexToDec("1A3f");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase07_NullString()
        {
            // Chuỗi null phòng thủ
            long expected = 0;
            long actual = o.HexToDec(null);
            Assert.AreEqual(expected, actual);
        }
    }
}
