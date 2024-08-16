using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Trinh_Unit
{
    public class CheckTG_54_Trinh
    {
        private int a_54_Trinh, b_54_Trinh, c_54_Trinh;

        // Constructor nhận 3 tham số (độ dài của ba cạnh tam giác) 
        public CheckTG_54_Trinh(int a_54_Trinh, int b_54_Trinh, int c_54_Trinh)
        {
            this.a_54_Trinh = a_54_Trinh;
            this.b_54_Trinh = b_54_Trinh;
            this.c_54_Trinh = c_54_Trinh;
        }

        // Phương thức kiểm tra tam giác vuông
        private bool IsTamGiacVuong_54_Trinh(int a_54_Trinh, int b_54_Trinh, int c_54_Trinh)
        {
            //tạo mảng gồm 3 phần tử là 3 cạnh tam giác
            int[] sides_54_Trinh = { a_54_Trinh, b_54_Trinh, c_54_Trinh };
            //sắp xếp 3 cạnh theo thứ tự tăng dần
            Array.Sort(sides_54_Trinh);
            //trả về true nếu cạnh dài nhất bình phương = tổng bình phương của 2 cạnh còn lại
            return Math.Pow(sides_54_Trinh[0], 2) + Math.Pow(sides_54_Trinh[1], 2) == Math.Pow(sides_54_Trinh[2], 2);
        }

        // Phương thức kiểm tra tam giác tù
        private bool IsTamGiacTu_54_Trinh(int a_54_Trinh, int b_54_Trinh, int c_54_Trinh)
        {
            //tạo mảng gồm 3 phần tử là 3 cạnh tam giác
            int[] sides_54_Trinh = { a_54_Trinh, b_54_Trinh, c_54_Trinh };
            //sắp xếp 3 cạnh theo thứ tự tăng dần
            Array.Sort(sides_54_Trinh);
            //trả về true nếu cạnh dài nhất bình phương > tổng bình phương của 2 cạnh còn lại
            return Math.Pow(sides_54_Trinh[0], 2) + Math.Pow(sides_54_Trinh[1], 2) < Math.Pow(sides_54_Trinh[2], 2);
        }
        //phương thức kiểm tra loại tam giác
        public string CheckTypeTG_54_Trinh(string choice_54_Trinh)
        {
            string result_54_Trinh = "True";
            switch (choice_54_Trinh)
            {
                case "c":// Kiểm tra tam giác cân
                    if ((a_54_Trinh == b_54_Trinh && a_54_Trinh != c_54_Trinh) 
                        || (a_54_Trinh == c_54_Trinh && a_54_Trinh != b_54_Trinh) 
                        || (b_54_Trinh == c_54_Trinh && b_54_Trinh != a_54_Trinh))
                        result_54_Trinh = "True";
                    else
                        result_54_Trinh = "False";
                    break;
                case "d":// Kiểm tra tam giác đều
                    if (a_54_Trinh == b_54_Trinh && b_54_Trinh == c_54_Trinh)
                        result_54_Trinh = "True";
                    else
                        result_54_Trinh = "False";
                    break;
                case "v":// Kiểm tra tam giác vuông, gọi hàm IsTamGiacVuong_54_Trinh để check
                    if (IsTamGiacVuong_54_Trinh(a_54_Trinh, b_54_Trinh, c_54_Trinh))
                        result_54_Trinh = "True";
                    else
                        result_54_Trinh = "False";
                    break;
                case "t": // Kiểm tra tam giác tù, gọi hàm IsTamGiacTu_54_Trinh để check
                    if (IsTamGiacTu_54_Trinh(a_54_Trinh, b_54_Trinh, c_54_Trinh))
                        result_54_Trinh = "True";
                    else
                        result_54_Trinh = "False";
                    break;

            }
            return result_54_Trinh; //trả về kết quả tương ứng với lựa chọn
        }
    }
}
