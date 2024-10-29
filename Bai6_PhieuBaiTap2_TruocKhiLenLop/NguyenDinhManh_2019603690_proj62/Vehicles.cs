using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj62
{
    public class Vehicles: IVehicle
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        // Phương thức khởi tạo không tham số
        public Vehicles() { }

        // Phương thức khởi tạo một tham số
        public Vehicles(string id)
        {
            Id = id;
        }

        // Phương thức khởi tạo năm tham số
        public Vehicles(string id, string maker, string model, int year, double price)
        {
            Id = id;
            Maker = maker;
            Model = model;
            Year = year;
            Price = price;
        }

        // Phương thức virtual Input()
        public virtual void Input()
        {
            Console.Write("Nhập mã định danh: ");
            Id = Console.ReadLine();
            Console.Write("Nhập hãng sản xuất: ");
            Maker = Console.ReadLine();
            Console.Write("Nhập model: ");
            Model = Console.ReadLine();
            Console.Write("Nhập năm sản xuất: ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá tiền: ");
            Price = double.Parse(Console.ReadLine());
        }

        // Phương thức virtual Output()
        public virtual void Output()
        {
            Console.WriteLine($"Mã định danh: {Id}");
            Console.WriteLine($"Hãng sản xuất: {Maker}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Năm sản xuất: {Year}");
            Console.WriteLine($"Giá tiền: {Price}");
        }

        // Phương thức Equals()
        public override bool Equals(object obj)
        {
            if (obj is Vehicles other)
            {
                return this.Id == other.Id;
            }
            return false;
        }

        // Phương thức ToString()
        public override string ToString()
        {
            return $"Id: {Id}, Maker: {Maker}, Model: {Model}, Year: {Year}, Price: {Price}";
        }
    }
}
