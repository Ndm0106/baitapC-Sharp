namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Vui lòng nhập một số nguyên dương: ");
            }
            int tong1 = 0;
            for (int i = 1; i <= n; i++)
            {
                tong1 += i;
            }
            double tong2 = 0.0;
            for (int i = 1; i <= n; i++)
            {
                tong2 += 1.0 / i;
            }
            Console.WriteLine($"Tổng S = 1 + 2 + 3 + ... + {n} là: {tong1}");
            Console.WriteLine($"Tổng S = 1 + 1/2 + 1/3 + ... + 1/{n} là: {tong2:F4}");
        }
    }
}
