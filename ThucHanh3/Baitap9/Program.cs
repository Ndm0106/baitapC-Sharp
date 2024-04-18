using System;
using System.Collections.Generic;
using System.Collections;
namespace Baitap9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhsach = new List<int>(5);
            for(int i=0;i<5;i++)
            {
                Console.Write("so thu " +(i+1)+":");
                danhsach.Add(int.Parse(Console.ReadLine()));
            }
            danhsach.Sort();
            foreach(var c in danhsach)
            {
                
                for(int i=0;i<5;i++)
                {
                    if(danhsach[i]<0)
                    {
                        danhsach.Remove(danhsach[i]);
                    }    
                }
                Console.WriteLine(c);
            }    
            
        }
    }
}
