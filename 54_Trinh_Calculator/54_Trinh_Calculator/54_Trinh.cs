using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Trinh_Calculator
{
    public class _54_Trinh
    {
        private int a, b;
        public _54_Trinh(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        public int PhepTinh_54_Trinh(string CalSymbol_54_Trinh)
        {
            int result_54_Trinh = 0;
            switch (CalSymbol_54_Trinh)
            {
                case "+":
                    result_54_Trinh = this.a + this.b;
                    break;
                case "-":
                    result_54_Trinh = this.a - this.b;
                    break;
                case "*":
                    result_54_Trinh = this.a * this.b;
                    break;
                case "/":
                    result_54_Trinh = this.a / this.b;
                    break;
            }
            return result_54_Trinh;
        }


    }
}

