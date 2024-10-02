using System.Text;

namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
