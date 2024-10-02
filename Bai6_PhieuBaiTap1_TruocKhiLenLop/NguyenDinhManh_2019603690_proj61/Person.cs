using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj61
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // Phương thức khởi tạo không tham số
        public Person()
        {
            Id = 0;
            Name = "Unknown";
            Address = "Unknown";
        }

        // Phương thức khởi tạo có tham số
        public Person(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        // Phương thức nhập thông tin
        public void Input()
        {
            Console.Write("Nhap id: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            Address = Console.ReadLine();
        }

        // Phương thức hiển thị thông tin
        public void Output()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Ten: {Name}");
            Console.WriteLine($"Dia chi: {Address}");
        }
    }
}
