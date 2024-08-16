using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _54_Trinh_Unit; //import namespace để sử dụng lại các method

namespace _54_Trinh_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        private CheckTG_54_Trinh c;

        // thiết lập dữ liệu dùng chung cho test case
        [TestInitialize]
        public void SetUp_54_Trinh()
        {
            //khởi tạo đối tượng với tham số là độ dài 3 cạnh tam giác
            c = new CheckTG_54_Trinh(5, 5, 7);
        }
        //Test Case kiểm tra tam giác cân
        [TestMethod]
        public void TestTGC_54_Trinh()
        {
            string expected_54_Trinh, actual_54_Trinh;
            //kết quả mong đợi : True
            expected_54_Trinh = "True";
            //gọi phương thức CheckTypeTG_54_Trinh kiểm tra tam giác cân với tham số c
            actual_54_Trinh = c.CheckTypeTG_54_Trinh("c");
            //so sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_54_Trinh, actual_54_Trinh);
        }
        //Test Case kiểm tra tam giác đều
        [TestMethod]
        public void TestTGD_54_Trinh()
        {
            string expected_54_Trinh, actual_54_Trinh;
            //kết quả mong đợi: False
            expected_54_Trinh = "False";
            //gọi phương thức CheckTypeTG_54_Trinh kiểm tra tam giác cân với tham số d
            actual_54_Trinh = c.CheckTypeTG_54_Trinh("d");
            //so sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_54_Trinh, actual_54_Trinh);
        }
        //Test Case kiểm tra tam giác tam giác vuông
        [TestMethod]
        public void TestTGV_54_Trinh()
        {
            string expected_54_Trinh, actual_54_Trinh;
            //kết quả mong đợi: False
            expected_54_Trinh = "False";
            //gọi phương thức CheckTypeTG_54_Trinh kiểm tra tam giác cân với tham số v
            actual_54_Trinh = c.CheckTypeTG_54_Trinh("v");
            //so sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_54_Trinh, actual_54_Trinh);
        }
        // Test Case kiểm tra tam giác tù
        [TestMethod]
        public void TestTGT_54_Trinh()
        {
            string expected_54_Trinh, actual_54_Trinh;
            //kết quả mong đợi : False
            expected_54_Trinh = "False";
            //gọi phương thức CheckTypeTG_54_Trinh kiểm tra tam giác cân với tham số t
            actual_54_Trinh = c.CheckTypeTG_54_Trinh("t");
            //so sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected_54_Trinh, actual_54_Trinh);
        }
        //chỉ định nguồn dữ liệu cho test case dưới dạng file csv
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @".\Data\TextData_54_Trinh.csv", "TextData_54_Trinh#csv", DataAccessMethod.Sequential)]
       //Test Case với file data csv 
        [TestMethod]
        public void TestWithData_54_Trinh()
        {
            int a_54_Trinh, b_54_Trinh, c_54_Trinh;
            string expected_54_Trinh, actual_54_Trinh;
            //a_54_Trinh, b_54_Trinh, c_54_Trinh được gán giá trị từ cột 0, 1, 2 của dữ liệu.
            a_54_Trinh = int.Parse(TestContext.DataRow[0].ToString());
            b_54_Trinh = int.Parse(TestContext.DataRow[1].ToString());
            c_54_Trinh = int.Parse(TestContext.DataRow[2].ToString());
            //expected_54_Trinh được gán giá trị từ cột 4 của dữ liệu.
            expected_54_Trinh = TestContext.DataRow[4].ToString();
            //choice_54_Trinh được gán giá trị từ cột 3 của dữ liệu.
            string choice_54_Trinh = TestContext.DataRow[3].ToString();
            //tạo một đối tượng CheckTG_54_Trinh với các cạnh của tam giác là a_54_Trinh, b_54_Trinh, c_54_Trinh
            CheckTG_54_Trinh pt = new CheckTG_54_Trinh(a_54_Trinh, b_54_Trinh, c_54_Trinh);
            //Gọi phương thức CheckTypeTG_54_Trinh với tham số choice_54_Trinh.
            //Kết quả trả về từ phương thức này được gán cho biến actual_54_Trinh.
            actual_54_Trinh = pt.CheckTypeTG_54_Trinh(choice_54_Trinh);
            Assert.AreEqual(expected_54_Trinh, actual_54_Trinh);
        }
    }
}
