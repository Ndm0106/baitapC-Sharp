using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMinhHoa
{
    internal class NhanVien:Person
    {
        private string _manhanvien;
        private string _chucvu;
        private double _luongcoban;

        public string MaNhanVien { get => _manhanvien; set => _manhanvien = value; }
        public string ChucVu { get => _chucvu; set => _chucvu = value; }

        public double LuongCoBan
        {
            get { return _luongcoban; }
            set {
                if (value < 0)
                    throw new ArgumentException("Luong co ban khong phep am");
                _luongcoban = value;
            }
        }


        public override void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin");
            Console.Write("Nhap ma nhan vien:");
            MaNhanVien = Console.ReadLine();
            base.NhapThongTin();
            Console.Write("Nhap chuc vu:");
            ChucVu = Console.ReadLine();
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.Write("Nhap luong co ban: ");
                    LuongCoBan = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lương cơ bản phải là số. Vui lòng nhập lại.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"{MaNhanVien}\t{ChucVu}\t{LuongCoBan}");
        }
    }
}
