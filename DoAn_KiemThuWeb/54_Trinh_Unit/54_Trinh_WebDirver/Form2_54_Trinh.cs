using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _54_Trinh_WebDirver
{
    public partial class Form2_54_Trinh : Form
    {   
        //Khai báo driver và định nghĩa đường dẫn url website Freepik
        public IWebDriver driver_54_Trinh;
        public const string URL_Freepik_54_Trinh = "https://www.freepik.com/";
        public Form2_54_Trinh()
        {
            InitializeComponent();
            SetupChromeDriver_54_Trinh();
        }
        //METHOD khởi tạo và cấu hình trình duyệt
        private void SetupChromeDriver_54_Trinh()
        {
            var options_54_Trinh = new ChromeOptions();
            options_54_Trinh.AddArgument("user-data-dir=C:\\Users\\baotr\\AppData\\Local\\Google\\Chrome\\User Data\\Profile 3");
            options_54_Trinh.AddArgument("profile-directory=Profile 3");
            options_54_Trinh.AddArgument("--start-maximized");
            var service_54_Trinh = ChromeDriverService.CreateDefaultService();
            service_54_Trinh.HideCommandPromptWindow = true;
            driver_54_Trinh = new ChromeDriver(service_54_Trinh, options_54_Trinh);
        }
         //METHOD điều hướng trang web
        public void Navigate_URL_54_Trinh()
        {
            driver_54_Trinh.Navigate().GoToUrl(URL_Freepik_54_Trinh);
        }

        //=========CHỨC NĂNG TÌM KIẾM ẢNH=======

        //METHOD click Image
        private void ClickIconSearch_54_Trinh()
        {
            IWebElement fileInput_54_Trinh = driver_54_Trinh.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[2]/div[1]/div/form/div/button[1]"));
            fileInput_54_Trinh.Click();
        }

        //____TC1: Tìm kiếm ảnh thành công
        private void btn1_SearchSuccess_54_Trinh_Click(object sender, EventArgs e)
        {
            Navigate_URL_54_Trinh();
            ClickIconSearch_54_Trinh();
            Thread.Sleep(1000);
            driver_54_Trinh.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\baotr\OneDrive\Pictures\Freepik\AnhHopLe.jpg");
        }

    
        //_____TC2: Tìm kiếm ảnh thất bại do dung lượng ảnh lớn
        private void btn2_ErrorSizeImg_54_Trinh_Click(object sender, EventArgs e)
        {
            Navigate_URL_54_Trinh();
            ClickIconSearch_54_Trinh();
            Thread.Sleep(2000);
            driver_54_Trinh.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\baotr\OneDrive\Pictures\Freepik\dungluongvuotmuc.png");
        }

        //_____TC3: Tìm kiếm ảnh thất bại do sai định dạng
        private void btn3_ErrorTypeImg_54_Trinh_Click(object sender, EventArgs e)
        {
            Navigate_URL_54_Trinh();
            ClickIconSearch_54_Trinh();
            Thread.Sleep(3000);
            driver_54_Trinh.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\baotr\OneDrive\Pictures\Freepik\AnhSaiType.tif");
        }

        //===============CHỨC NĂNG THÊM ẢNH VÀO BỘ SƯU TẬP================

        //METHOD dùng chung cho 3 test case: điều hướng tới trang web, chọn ảnh thêm vào colection, điều hướng đăng nhập
        private void LogAddCollection()
        {
            //điều hướng tới trang web
            Navigate_URL_54_Trinh();
            //method click nút search
            ClickIconSearch_54_Trinh();
            //method upload image
            driver_54_Trinh.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\baotr\OneDrive\Pictures\Freepik\AnhHopLe.jpg");
            Thread.Sleep(8000);
            // click vào image muốn thêm vào collection
            IWebElement ClickImg_54_Trinh = driver_54_Trinh.FindElement(By.XPath("/html/body/div[1]/div[4]/div[3]/div/div[4]/div[1]/figure[1]/a/figcaption"));
            ClickImg_54_Trinh.Click();
            Thread.Sleep(5000);
            // click nút collection
            IWebElement ClickAdd_54_Trinh = driver_54_Trinh.FindElement(By.XPath("/html/body/div[1]/div[4]/div[3]/div[2]/div/div/div/div[1]/div[2]/div/button[2]"));
            ClickAdd_54_Trinh.Click();
            Thread.Sleep(3000);
            // click đăng nhập với email trước khi thêm vào collection
            IWebElement ClickEmail_54_Trinh = driver_54_Trinh.FindElement(By.CssSelector("#log-in > div.continue-with > button:nth-child(3)"));
            ClickEmail_54_Trinh.Click();
            Thread.Sleep(1000);
        }
        //METHOD Login nhập email và password tự động
        public void InputUser_54_Trinh(string DefaultEmail_54_Trinh, string DefaultPass_54_Trinh)
        {
            //input email
           driver_54_Trinh.FindElement(By.Name("email")).SendKeys(DefaultEmail_54_Trinh);
            //input password
           driver_54_Trinh.FindElement(By.Name("password")).SendKeys(DefaultPass_54_Trinh);
            // click button Login
           IWebElement Submit_54_Trinh = driver_54_Trinh.FindElement(By.Id("submit"));
           Submit_54_Trinh.Click();
        }

       /* // METHOD submit login
        public void SubmitUser_54_Trinh()
        {
            IWebElement Submit_54_Trinh = driver_54_Trinh.FindElement(By.Id("submit"));
            Submit_54_Trinh.Click();
        }*/

        // ============TC1: Thêm ảnh thất bại do đăng nhập thất bại===========
        private void btn1_FailAdd_54_Trinh_Click(object sender, EventArgs e)
        {
            //Method chọn ảnh thêm vào colection, điều hướng đăng nhập 
            LogAddCollection();
            Thread.Sleep(3000);
            //input email và password không hợp lệ
            string DefaultEmail_54_Trinh = "trinh@ou.edu.vn";
            string DefaultPass_54_Trinh = "54Trinh";
            //phương thức Login với email
            InputUser_54_Trinh(DefaultEmail_54_Trinh, DefaultPass_54_Trinh);
            Thread.Sleep(3000);
        }

        //=====TC2: Thêm ảnh thất bại do không chọn tên bộ sưu tập để lưu======
        private void btn2_FailAdd2_54_Trinh_Click(object sender, EventArgs e)
        {
            //Method chọn ảnh thêm vào colection, điều hướng đăng nhập 
            LogAddCollection();
            //input email và password hợp lệ
            string DefaultEmail_54_Trinh = "2151050477trinh@ou.edu.vn";
            string DefaultPass_54_Trinh = "Baotrinh2505@95";
            //phương thức Login với email
            InputUser_54_Trinh(DefaultEmail_54_Trinh, DefaultPass_54_Trinh);
            Thread.Sleep(5000);
            // click nút add collection
            IWebElement ClickAddC_54_Trinh = driver_54_Trinh.FindElement(By.CssSelector("#main > div > div.detail__subactions " +
                "> button.collection-add.button.button--sm.button--gray.button--state"));
            ClickAddC_54_Trinh.Click();
            Thread.Sleep(5000);
           
        }

        //===========TC3: Thêm ảnh vào bộ sưu tập thành công==============
        private void btn3_SuccessAdd_54_Trinh_Click(object sender, EventArgs e)
        {
            //click chọn tên collection để thêm ảnh
            IWebElement ClickCollection_54_Trinh = driver_54_Trinh.FindElement(By.XPath("/html/body/div[8]/div/div/div/div[2]/div/div/div[2]/ul/li[2]/label"));
            ClickCollection_54_Trinh.Click();
            Thread.Sleep(5000);
            //click nút lưu Save Changes
            driver_54_Trinh.FindElement(By.XPath("/html/body/div[8]/div/div/div/div[2]/div/button")).Click();
           
        }   

    }
}
