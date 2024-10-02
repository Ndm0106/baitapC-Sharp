using System.Text;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập n: ");
            int n = int.Parse(Console.ReadLine());
            while(n<=0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương");
            }
            Console.WriteLine($"Dãy Fibonacci với {n} số đầu tiên là:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        static int Fibonacci(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
