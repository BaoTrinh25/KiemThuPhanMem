using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _54_Trinh_Calculator;

namespace _54_Trinh
{
    [TestClass]
    public class UnitTest1
    {
        private _54_Trinh_Calculator._54_Trinh c;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void TestMethod1()
        {
            c = new _54_Trinh_Calculator._54_Trinh(10, 5);
        }
        [TestMethod]
        public void TestCong_54_Trinh()
        {
            int expected, actual;
            expected = 15;
            actual = c.PhepTinh_54_Trinh("+");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestTru_54_Trinh()
        {
            int expected, actual;
            expected = 5;
            actual = c.PhepTinh_54_Trinh("-");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestNhan_54_Trinh()
        {
            int expected, actual;
            expected = 50;
            actual = c.PhepTinh_54_Trinh("*");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestChia_54_Trinh()
        {
            int expected, actual;
            expected = 2;
            actual = c.PhepTinh_54_Trinh("/");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestChiaZero_54_Trinh()
        {
            c = new _54_Trinh_Calculator._54_Trinh(10, 0);
            c.PhepTinh_54_Trinh("/");
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData_54.csv", "TestData_54#csv", DataAccessMethod.Sequential)]
        public void TestWithData_54_Trinh()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            _54_Trinh_Calculator._54_Trinh c = new _54_Trinh_Calculator._54_Trinh(a, b);
            int actual = c.PhepTinh_54_Trinh("+");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
           @".\Data\DataTest_cotToantu_54.csv", "DataTest_cotToantu_54#csv", DataAccessMethod.Sequential)]
        public void TestCongDataSource_54_Trinh()
        {
            int a, b, expected, actual;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new _54_Trinh_Calculator._54_Trinh(a, b);
            actual = c.PhepTinh_54_Trinh(operation);
            Assert.AreEqual(expected, actual);
        }
    }
}
