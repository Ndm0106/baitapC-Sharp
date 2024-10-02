using System.Text;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập phép toán: ");
            string pt = Console.ReadLine();
            double kq=0;
            if (pt == "+")
            {
                kq = cong(a, b);    
            }  else if (pt == "-")
            {
                kq = tru(a, b);   
            }    else if (pt == "*")
            {
                kq = nhan(a, b);
            }   else if (pt == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Lỗi: Không thể chia cho 0.");
                    return;
                }
                kq = chia(a, b);
            }
            else
            {
                Console.WriteLine("Phép toán không hợp lệ.");
                return;
            }
            Console.WriteLine("Kết quả của phép tính "+pt+" là:"+kq);
        }
        static double cong(double a, double b)
        {
            return a + b;
        }
        static double tru(double a, double b)
        {
            return a - b;
        }
        static double nhan(double a, double b)
        {
            return a * b;
        }
        static double chia(double a, double b)
        {
            return a / b;
        }
    }
}
