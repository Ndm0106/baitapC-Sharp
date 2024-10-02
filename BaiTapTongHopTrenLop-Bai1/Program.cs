using System.Text;

namespace BaiTapTongHopTrenLop_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào tử số (m): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào mẫu số (n): ");
            int n = int.Parse(Console.ReadLine()); 
            if (n == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0.");
                return;
            }
            int gcd = GCD(m, n);
            m /= gcd;
            n /= gcd;
            Console.WriteLine($"Phân số rút gọn: {m}/{n}");
        }
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }
    }
}
