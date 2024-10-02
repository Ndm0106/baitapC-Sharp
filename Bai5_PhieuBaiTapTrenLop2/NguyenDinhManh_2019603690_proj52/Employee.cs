using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj52
{
    internal class Employee
    {
        private string id;
        private string name;
        private int age;
        private int workingdays;
        private double salary;
        private const double PRICE = 50;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        // Thuộc tính name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Thuộc tính age
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Thuộc tính workingdays
        public int WorkingDays
        {
            get { return workingdays; }
            set { workingdays = value; }
        }

        // Phương thức tính lương (salary)
        public double GetSalary()
        {
            salary = workingdays * PRICE;
            return salary;
        }
        public void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            Id = Console.ReadLine();
            Console.Write("Nhap ho ten nhan vien: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi nhan vien: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay cong: ");
            WorkingDays = int.Parse(Console.ReadLine());
        }

        // Phương thức hiển thị thông tin
        public void Output()
        {
            Console.WriteLine($"Ma Nhan Vien: {Id}");
            Console.WriteLine($"Ho Ten: {Name}");
            Console.WriteLine($"Tuoi: {Age}");
            Console.WriteLine($"So Ngay Cong: {WorkingDays}");
            Console.WriteLine($"Luong: {GetSalary()}");
        }
    }
}
