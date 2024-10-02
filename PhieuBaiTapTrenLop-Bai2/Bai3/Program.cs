using System.Text;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập số nguyên dương n:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("Vui lòng nhập một số nguyên dương hoặc bằng 0: ");
            }
            long giaiThua = TinhGiaiThua(n);

            // Hiển thị kết quả
            Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
        }
        static long TinhGiaiThua(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
