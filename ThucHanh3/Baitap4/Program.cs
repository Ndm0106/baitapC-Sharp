using System;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int i=1;i<=9;i++)
            {
                Console.WriteLine("cuu chuong:" + i);
                for(int j=1;j<=9;j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }    
            }    
        }
    }
}
