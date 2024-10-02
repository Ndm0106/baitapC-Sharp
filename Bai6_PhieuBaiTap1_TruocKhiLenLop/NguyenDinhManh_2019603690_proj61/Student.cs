using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj61
{
    internal class Student : Person
    {
        public byte Maths { get; set; }
        public byte Physics { get; set; }

        // Phương thức khởi tạo không tham số
        public Student() : base()
        {
            Maths = 0;
            Physics = 0;
        }

        // Phương thức khởi tạo có tham số
        public Student(int id, string name, string address, byte maths, byte physics) : base(id, name, address)
        {
            Maths = maths;
            Physics = physics;
        }

        // Phương thức nhập thông tin sinh viên
        public new void Input()
        {
            base.Input();
            Console.Write("Nhap diem toan: ");
            Maths = byte.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            Physics = byte.Parse(Console.ReadLine());
        }

        // Phương thức hiển thị thông tin sinh viên
        public new void Output()
        {
            base.Output();
            Console.WriteLine($"Diem Toan: {Maths}");
            Console.WriteLine($"Diem Ly: {Physics}");
        }

        // Phương thức tính tổng điểm
        public int Total()
        {
            return Maths + Physics;
        }
    }
}
