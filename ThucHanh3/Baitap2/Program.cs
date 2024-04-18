using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap day:");
            string c = Console.ReadLine();
            //string chan;
            //string le;
            for(int i=0;i<c.Length;i++)
            {
                if(c[i]%2==0)
                {
                    Console.Write(c[i]);
                } 
            }
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] % 2 != 0)
                {
                    Console.Write(c[i]);
                }
            }
        }
    }
}
