using Test01;
using Xunit;



namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Testsumnumber()
        {
            Assert.Equal(8, Mymath.Sumnumber(5, 3));
        }
        [Fact]
        public void TestYearLeapIsTrue()
        {
            Assert.True(Mymath.CheckingLeapYear(2024));
        }
        [Fact]
        public void TestYearLeapIsFalse()
        {
            Assert.False(Mymath.CheckingLeapYear(2023));
        }
        [Fact]
        public void TestSNTIsTrue()
        {
            Assert.True(Mymath.CheckingSNT(13));
        }
        [Fact]
        public void TestSNTIsFalse()
        {
            Assert.False(Mymath.CheckingSNT(6));
        }

        [Fact]
        public void TestTamGiacIsTrue()
        {
            Assert.True(Mymath.KiemTraDoDaiTamGiac(4,5,3));
        }
        [Fact]
        public void TestTamGiacIsFalse()
        {
            Assert.False(Mymath.KiemTraDoDaiTamGiac(2,3,0));
        }

        [Fact]
        public void TestTamGiacVuongIsTrue()
        {
            Assert.True(Mymath.KiemTraTamGiacVuong(4,5,3));
        }

        [Fact]
        public void TesttinhtongSNT()
        {
            Assert.Equal(17,Mymath.TinhTongSNT(1,10));
        }
        [Fact]
        public void TestDemSNT()
        {
            Assert.Equal(4, Mymath.DemSNT(1,10));
        }
        [Fact]
        public void TesttinhTBCSNT()
        {
            Assert.Equal(4.25, Mymath.TinhTBCSNT(1, 10));
        }
        [Fact]
        public void TestgiaiPTBN()
        {
            Assert.Equal(0,Mymath.GiaiPTBN(1,0));
        }




    }
}