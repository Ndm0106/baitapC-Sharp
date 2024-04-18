using System;

namespace Baitap7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("a[" + i + "]:");
                a[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if(a[i]%2!=0)
                {
                    sum += a[i];
                }
            }
            Console.WriteLine("tong cac phan tu le:"+sum);
        }
    }
}
