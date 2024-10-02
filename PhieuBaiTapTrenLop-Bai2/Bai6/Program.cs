using System.Text;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.Write("Vui lòng nhập số nguyên n: ");
                n = int.Parse(Console.ReadLine());
            }
            int[] a = new int[n];
            nhapmang(n, a);
            SoChan(n, a);
            SoLe(n, a);
            SoNguyenTo(n, a);
        }
        static void nhapmang(int n, int[] a)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]:");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void SoChan(int n, int[] a)
        {
            Console.Write("Các số chẵn trong danh sách:");
            for (int i = 0; i < n; i++)
            {
                if (a[i]%2==0)
                    Console.Write(a[i]+" "); 
            }
            Console.Write("\n");
        }
        static void SoLe(int n, int[] a)
        {
            Console.Write("Các số lẻ trong danh sách:");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    Console.Write(a[i]+" ");
            }
            Console.Write("\n");
        }
        static void SoNguyenTo(int n, int[] a)
        {
            Console.Write("Các số nguyên tố trong danh sách:");
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(a[i]))
                    Console.Write(a[i] + " ");
            }
            Console.Write("\n");
        }
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
