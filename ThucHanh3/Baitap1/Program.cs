using System;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hay nhap 2 so");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a +" + "+b+" = "+(a+b));
        }
    }
}
