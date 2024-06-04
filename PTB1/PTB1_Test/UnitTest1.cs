using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PTB1;

namespace PTB1_Test
{
    [TestClass]
    public class UnitTest1
    {
        private Giai c;
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            c = new Giai(10.0, 5.0);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= -0.5
        public void Test_PTB1_06_KhongSonBinh()
        {
            double expected, actual;
            
            expected = -0.5;
            actual = c.Solve();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_NgoaiLe1_06_KhongSonBinh()
        {
            Giai c = new Giai(0.0, 0.0);


            Assert.ThrowsException<ArgumentException>(() => c.Solve());

        }
        [TestMethod]
        public void Test_NgoaiLe2_06_KhongSonBinh()
        {
            Giai c = new Giai(0.0, 9.3);
            

            Assert.ThrowsException<ArgumentException>(() => c.Solve());

        }
        
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test_With_Data_06_KhongSonBinh()
        {
            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());

            string expected = TestContext.DataRow[2].ToString();

            Giai c = new Giai(a, b);

            if ((a == 0.0 && b == 0.0) || (a == 0.0 && b != 0.0))
            {
                if (double.TryParse(expected, out _))
                {
                    string actual = c.Solve().ToString();
                    // Báo lỗi nếu kết quả là số
                    Assert.Fail("Expected result is a number, but an exception was not thrown.");
                }
                else {
                    // Kiểm tra nếu ngoại lệ ArgumentException được ném ra
                    Assert.ThrowsException<ArgumentException>(() => c.Solve());
                }
                
            }
            else
            {
                
                string actual = c.Solve().ToString();
                Assert.AreEqual(expected, actual);
              
            }
        }

    }
}
