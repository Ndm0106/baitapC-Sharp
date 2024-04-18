using System;

namespace Baitap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap canh a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap canh b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("nhap canh c:");
            int c = int.Parse(Console.ReadLine());
            while (((a + b <= c) || (a + c <= b) || (b + c <= a)) && (a < 0 || b < 0 || c < 0))
            {
                Console.WriteLine("yeu cau nhap lai:");
                Console.Write("nhap canh a:");
                a = int.Parse(Console.ReadLine());
                Console.Write("nhap canh b:");
                b = int.Parse(Console.ReadLine());
                Console.Write("nhap canh c:");
                c = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("chu vi:" + (a + b) * 2);
            Console.WriteLine("dien tich:" + a * b);
        }
    }
}
