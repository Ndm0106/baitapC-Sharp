using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMinhHoa
{
    internal class Person
    {
        private string _hoten;
        private string _diachi;

        public string HoTen { get => _hoten; set => _hoten = value; }
        public string DiaChi { get => _diachi; set => _diachi = value; }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
        }
        public virtual void HienThiThongTin()
        {
            Console.Write($"{HoTen}\t{DiaChi}\t");
        }
    }
}
