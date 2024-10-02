using System.Text;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập cạnh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("Các cạnh nhập vào không phải là tam giác hợp lệ.");
                return;
            }
            double chuVi = a + b + c;
            double p = chuVi / 2;
            double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
            Console.WriteLine($"Chu vi tam giác: {chuVi}");
            Console.WriteLine($"Diện tích tam giác: {dienTich}");
        }
    }
}
