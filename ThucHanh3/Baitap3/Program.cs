using System;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhap b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhap pt:");
            string c = Console.ReadLine();
            switch(c)
            {
                case "+":
                    Console.WriteLine("a + b=" + a + b);
                    break;
                case "-":
                    Console.WriteLine("a - b=" + (a - b));
                    break;
                case "*":
                    Console.WriteLine("a * b=" + (a * b));
                    break;
                case "/":
                    Console.WriteLine("a / b=" + (a / b));
                    break;
                default:
                    Console.WriteLine("khong co phep tinh nao");
                    break;
            }  
        }
    }
}
