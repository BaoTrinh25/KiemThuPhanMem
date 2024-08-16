using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54_Trinh_Unit
{
    public partial class Form1_54_Trinh : Form
    {
        public Form1_54_Trinh()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra xem người dùng đã nhập đủ 3 cạnh chưa
        private bool ValidateInput_54_Trinh(string a_54_Trinh, string b_54_Trinh, string c_54_Trinh)
        {
            if (string.IsNullOrWhiteSpace(a_54_Trinh) || string.IsNullOrWhiteSpace(b_54_Trinh) || string.IsNullOrWhiteSpace(c_54_Trinh))
            {
                lb_KQ_54_Trinh.Text = "Vui lòng nhập đủ 3 cạnh của tam giác.";
                return false;
            }

            int ParseA_54_Trinh, ParseB_54_Trinh, ParseC_54_Trinh;

            // Parse giá trị từ textbox sang kiểu int
            if (!int.TryParse(a_54_Trinh, out ParseA_54_Trinh) || !int.TryParse(b_54_Trinh, out ParseB_54_Trinh) || !int.TryParse(c_54_Trinh, out ParseC_54_Trinh))
            {
                lb_KQ_54_Trinh.Text = "Vui lòng nhập đúng định dạng số.";
                return false;
            }
            return true; // Trả về true nếu dữ liệu hợp lệ
        }


        // Kiểm tra tam giác Cân
        private void btnCan_54_Trinh_Click(object sender, EventArgs e)
        {
            //kiểm tra có nhập đủ 3 cạnh không
            if (!ValidateInput_54_Trinh(txtA_54.Text, txtB_54.Text, txtC_54.Text))
            {
                return; 
            }
            int a_54_Trinh, b_54_Trinh, c_54_Trinh;
            string kq_54_Trinh;
            a_54_Trinh = int.Parse(txtA_54.Text);
            b_54_Trinh = int.Parse(txtB_54.Text);
            c_54_Trinh = int.Parse(txtC_54.Text);
            //Tạo một đối tượng CheckTG_54_Trinh với 3 tham số là 3 cạnh của tam giác vừa lấy được.
            CheckTG_54_Trinh check_54_Trinh = new CheckTG_54_Trinh(a_54_Trinh, b_54_Trinh, c_54_Trinh);
            //gọi phương thức CheckTypeTG_54_Trinh từ class CheckTG_54_Trinh với tham số c để kiểm tra tam giác cân
            kq_54_Trinh = check_54_Trinh.CheckTypeTG_54_Trinh("c");
            //kết quả kiểm tra trả về label lb_KQ_54_Trinh
            this.lb_KQ_54_Trinh.Text = kq_54_Trinh.ToString();
        }

        //Kiểm tra tam giác Đều
        private void btnDeu_54_Trinh_Click(object sender, EventArgs e)
        {
            //kiểm tra có nhập đủ 3 cạnh không
            if (!ValidateInput_54_Trinh(txtA_54.Text, txtB_54.Text, txtC_54.Text))
            {
                return;
            }
            int a_54_Trinh, b_54_Trinh, c_54_Trinh;
            string kq_54_Trinh;
            a_54_Trinh = int.Parse(txtA_54.Text);
            b_54_Trinh = int.Parse(txtB_54.Text);
            c_54_Trinh = int.Parse(txtC_54.Text);
            //Tạo một đối tượng CheckTG_54_Trinh với 3 tham số là 3 cạnh của tam giác vừa lấy được.
            CheckTG_54_Trinh check_54_Trinh = new CheckTG_54_Trinh(a_54_Trinh, b_54_Trinh, c_54_Trinh);
            //gọi phương thức CheckTypeTG_54_Trinh từ class CheckTG_54_Trinh với tham số d để kiểm tra tam giác đều
            kq_54_Trinh = check_54_Trinh.CheckTypeTG_54_Trinh("d");
            //kết quả kiểm tra trả về label lb_KQ_54_Trinh
            this.lb_KQ_54_Trinh.Text = kq_54_Trinh.ToString();
        }

        //Kiểm tra tam giác Vuông
        private void btnVuong_54_Trinh_Click_1(object sender, EventArgs e)
        {
            //kiểm tra có nhập đủ 3 cạnh không
            if (!ValidateInput_54_Trinh(txtA_54.Text, txtB_54.Text, txtC_54.Text))
            {
                return;
            }
            int a_54_Trinh, b_54_Trinh, c_54_Trinh;
            string kq_54_Trinh;
            a_54_Trinh = int.Parse(txtA_54.Text);
            b_54_Trinh = int.Parse(txtB_54.Text);
            c_54_Trinh = int.Parse(txtC_54.Text);
            //Tạo một đối tượng CheckTG_54_Trinh với 3 tham số là 3 cạnh của tam giác vừa lấy được.
            CheckTG_54_Trinh check_54_Trinh = new CheckTG_54_Trinh(a_54_Trinh, b_54_Trinh, c_54_Trinh);
            //gọi phương thức CheckTypeTG_54_Trinh từ class CheckTG_54_Trinh với tham số v để kiểm tra tam giác vuông
            kq_54_Trinh = check_54_Trinh.CheckTypeTG_54_Trinh("v");
            //kết quả kiểm tra trả về label lb_KQ_54_Trinh
            this.lb_KQ_54_Trinh.Text = kq_54_Trinh.ToString();
        }

        //Kiểm tra tam giác Tù
        private void btnTu_54_Trinh_Click(object sender, EventArgs e)
        {
            //kiểm tra có nhập đủ 3 cạnh không
            if (!ValidateInput_54_Trinh(txtA_54.Text, txtB_54.Text, txtC_54.Text))
            {
                return;
            }
            int a_54_Trinh, b_54_Trinh, c_54_Trinh;
            string kq_54_Trinh;
            a_54_Trinh = int.Parse(txtA_54.Text);
            b_54_Trinh = int.Parse(txtB_54.Text);
            c_54_Trinh = int.Parse(txtC_54.Text);
            //Tạo một đối tượng CheckTG_54_Trinh với 3 tham số là 3 cạnh của tam giác vừa lấy được.
            CheckTG_54_Trinh check_54_Trinh = new CheckTG_54_Trinh(a_54_Trinh, b_54_Trinh, c_54_Trinh);
            //gọi phương thức CheckTypeTG_54_Trinh từ class CheckTG_54_Trinh với tham số t để kiểm tra tam giác tù
            kq_54_Trinh = check_54_Trinh.CheckTypeTG_54_Trinh("t");
            //kết quả kiểm tra trả về label lb_KQ_54_Trinh
            this.lb_KQ_54_Trinh.Text = kq_54_Trinh.ToString();
        }
    }
}
