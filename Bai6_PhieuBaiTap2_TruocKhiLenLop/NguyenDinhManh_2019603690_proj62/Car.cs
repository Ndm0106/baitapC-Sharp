using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj62
{
    public class Car:Vehicles
    {
        public string Color { get; set; }

        // Phương thức khởi tạo không tham số
        public Car() { }

        // Phương thức khởi tạo sáu tham số
        public Car(string id, string maker, string model, int year, double price, string color)
            : base(id, maker, model, year, price)
        {
            Color = color;
        }

        // Phương thức Input()
        public override void Input()
        {
            base.Input(); // Gọi phương thức Input() ở lớp cơ sở
            Console.Write("Nhập màu sắc: ");
            Color = Console.ReadLine();
        }

        // Phương thức Output()
        public override void Output()
        {
            base.Output(); // Gọi phương thức Output() ở lớp cơ sở
            Console.WriteLine($"Màu sắc: {Color}");
        }
    }
}
