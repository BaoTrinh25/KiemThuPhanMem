using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54_Trinh_Calculator
{
    public partial class Form_54_Trinh : Form
    {
        public Form_54_Trinh()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a_54_Trinh, b_54_Trinh, ketqua_54_Trinh;
            a_54_Trinh = int.Parse(txtSo1_54_Trinh.Text);
            b_54_Trinh = int.Parse(txtSo2_54_Trinh.Text);
            _54_Trinh c = new _54_Trinh(a_54_Trinh, b_54_Trinh);
            ketqua_54_Trinh = c.PhepTinh_54_Trinh("+");
            this.txtKq_54_Trinh.Text = ketqua_54_Trinh.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a_54_Trinh, b_54_Trinh, ketqua_54_Trinh;
            a_54_Trinh = int.Parse(txtSo1_54_Trinh.Text);
            b_54_Trinh = int.Parse(txtSo2_54_Trinh.Text);
            _54_Trinh c = new _54_Trinh(a_54_Trinh, b_54_Trinh);
            ketqua_54_Trinh = c.PhepTinh_54_Trinh("-");
            this.txtKq_54_Trinh.Text = ketqua_54_Trinh.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a_54_Trinh, b_54_Trinh, ketqua_54_Trinh;
            a_54_Trinh = int.Parse(txtSo1_54_Trinh.Text);
            b_54_Trinh = int.Parse(txtSo2_54_Trinh.Text);
            _54_Trinh c = new _54_Trinh(a_54_Trinh, b_54_Trinh);
            ketqua_54_Trinh = c.PhepTinh_54_Trinh("*");
            this.txtKq_54_Trinh.Text = ketqua_54_Trinh.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a_54_Trinh, b_54_Trinh, ketqua_54_Trinh;
            a_54_Trinh = int.Parse(txtSo1_54_Trinh.Text);
            b_54_Trinh = int.Parse(txtSo2_54_Trinh.Text);
            _54_Trinh c = new _54_Trinh(a_54_Trinh, b_54_Trinh);
            ketqua_54_Trinh = c.PhepTinh_54_Trinh("/");
            this.txtKq_54_Trinh.Text = ketqua_54_Trinh.ToString();
        }
    }
}
