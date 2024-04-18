using System;

namespace Baitap5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so:");
            int n = int.Parse(Console.ReadLine());
            while (n>100 || n<1)
            {
                Console.WriteLine("yeu cau nhap lai");
                Console.Write("nhap so:");
                n = int.Parse(Console.ReadLine());
                // cau a
            }
            Console.WriteLine("hop le");
            
        }
    }
}
