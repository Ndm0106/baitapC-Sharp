using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class GiaiPhuongTrinhBac2
    {
        private int a;
        private int b;
        private int c;
        public GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // Phương thức giải phương trình bậc 2
        public void Solve()
        {
            if (a == 0)
            {
                Console.WriteLine("Day khong phai la phuong trinh bac 2.");
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2.0 * a);
                    Console.WriteLine($"Phuong trinh co nghiem kep: x = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phuong trinh co 2 nghiem: x1 = {x1}, x2 = {x2}");
                }
            }
        }
    }
}
