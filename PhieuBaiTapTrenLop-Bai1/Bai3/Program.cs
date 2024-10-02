using System.Text;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Giải PT bậc nhất");
            Console.WriteLine("2. Giải PT bậc hai");
            Console.Write("nhập lựa chọn:");
            string n;
            n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Console.Write("Nhập hệ số a: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nhập hệ số b: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    // Giải phương trình bậc nhất ax + b = 0
                    GiaiPTBacNhat(a, b);
                    break;
                case "2":
                    Console.Write("Nhập hệ số a: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nhập hệ số b: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nhập hệ số c: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    // Giải phương trình bậc hai ax^2 + bx + c = 0
                    GiaiPTBacHai(a, b, c);
                    break;
            }


        }
        static void GiaiPTBacNhat(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phương trình có nghiệm x = {0}", x);
            }
        }
        static void GiaiPTBacHai(double a, double b, double c)
        {
            if (a == 0)
            {
                // Nếu a = 0, đây là phương trình bậc nhất bx + c = 0
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình bậc nhất có nghiệm x = {0}", x);
                }
            }
            else
            {
                // Tính delta
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có hai nghiệm phân biệt:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép x = {0}", x);
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm thực.");
                }
            }
        }
    }
}
