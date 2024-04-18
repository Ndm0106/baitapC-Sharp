using System;

namespace Baitap8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap chuoi:");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length / 2; i++)
            {
                if(s[i]!=s[s.Length - i -1])
                {
                    Console.WriteLine("xau doi xung");
                    break;
                } else
                {
                    Console.WriteLine("xau ko doi xung");
                    break;
                }    
            }   
            
        }
    }
}
