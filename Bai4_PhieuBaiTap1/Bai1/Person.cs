using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai1
{
    internal class Person
    {
        
        private string id {  get; set; }    
        private string name { get; set; }
        private int age { get; set; }
        private string email { get; set; }
        private string address { get; set; }
        public void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập ID: ");
            id = Console.ReadLine();

            Console.Write("Nhập tên: ");
            name = Console.ReadLine();

            Console.Write("Nhập tuổi: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Nhập email: ");
            email = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            address = Console.ReadLine();
        }
        public void Output()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Tên: " + name);
            Console.WriteLine("Tuổi: " + age);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Địa chỉ: " + address);
        }

        // Phương thức CheckAge để kiểm tra tuổi
        public void CheckAge()
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (age >= 18)
            {
                Console.WriteLine("Bạn đủ tuổi bầu cử");
            }
            else
            {
                Console.WriteLine("Bạn còn nhỏ");
            }
        }
    }
}
