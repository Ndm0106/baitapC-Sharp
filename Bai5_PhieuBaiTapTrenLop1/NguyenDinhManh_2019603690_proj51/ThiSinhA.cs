using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj51
{
    public class ThiSinhA
    {
        private string sbd;
        private string hoten;
        private string diachi;
        private double diemtoan;
        private double diemly;
        private double diemhoa;
        private double diemuutien;
        private double tongdiem;

        public string SoBaoDanh
        {
            get { return sbd; }
            set { sbd = value; }
        }
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public double DiemToan
        {
            get { return diemtoan; }
            set { diemtoan = value; }
        }
        public double DiemLy
        {
            get { return diemly; }
            set { diemly = value; }
        }
        public double DiemHoa
        {
            get { return diemhoa; }
            set { diemhoa = value; }
        }
        public double DiemUuTien
        {
            get { return diemuutien; }
            set { diemuutien = value; }
        }
        public double TongDiem
        {
            get { return tongdiem; } 
            set { tongdiem = value; }
        }
        public void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap thong tin cho thi sinh");
            Console.Write("Nhap sbd: ");
            SoBaoDanh = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa hoc: ");
            DiemHoa = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem uu tien: ");
            DiemUuTien = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            TongDiem = DiemToan + DiemHoa + DiemLy + DiemUuTien;
            Console.WriteLine("SBD:"+SoBaoDanh);
            Console.WriteLine("Ho Ten:" + HoTen);
            Console.WriteLine("Dia Chi:" + DiaChi);
            Console.WriteLine("Diem Toan:" + DiemToan);
            Console.WriteLine("Diem Ly:" + DiemLy);
            Console.WriteLine("Diem Hoa:" + DiemHoa);
            Console.WriteLine("Diem Uu Tien:" + DiemUuTien);
            Console.WriteLine("Tong Diem:" + TongDiem);
        }
    }
}
