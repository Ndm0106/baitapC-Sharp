using System.Text;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = InputArr(n);
            OutputArr(n, a);
        }
        static int[] InputArr(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void OutputArr(int n, int[] a)
        {
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    S += a[i];
                }
            }
            Console.WriteLine("Tổng các phần tử lẻ trong mảng là " + S);
        }

    }
}
