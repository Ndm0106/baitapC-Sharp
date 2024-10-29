using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj62
{
    internal class Truck:Vehicles
    {
        public int Truckload { get; set; }

        // Phương thức khởi tạo không tham số
        public Truck() { }

        // Phương thức khởi tạo sáu tham số
        public Truck(string id, string maker, string model, int year, double price, int truckload)
            : base(id, maker, model, year, price)
        {
            Truckload = truckload;
        }

        // Phương thức Input()
        public override void Input()
        {
            base.Input(); // Gọi phương thức Input() ở lớp cơ sở
            Console.Write("Nhập tải trọng: ");
            Truckload = int.Parse(Console.ReadLine());
        }

        // Phương thức Output()
        public override void Output()
        {
            base.Output(); // Gọi phương thức Output() ở lớp cơ sở
            Console.WriteLine($"Tải trọng: {Truckload}");
        }
    }
}
