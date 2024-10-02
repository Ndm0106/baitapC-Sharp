using System.Text;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                // Nhập 3 cạnh a, b, c
                Console.Write("Nhập cạnh a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Nhập cạnh b: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Nhập cạnh c: ");
                int c = int.Parse(Console.ReadLine());

                // Kiểm tra xem a, b, c có phải là 3 cạnh của 1 tam giác không
                if (KiemTraTamGiac(a, b, c))
                {
                    // Tính chu vi
                    int chuVi = a + b + c;
                    Console.WriteLine("Chu vi tam giác: " + chuVi);
                    double p = chuVi / 2.0;
                    double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine("Diện tích tam giác: " + dienTich);

                    break;
                }
                else
                {
                    Console.WriteLine("Không phải 3 cạnh của một tam giác. Vui lòng nhập lại.");
                }
            }
        }
        static bool KiemTraTamGiac(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
