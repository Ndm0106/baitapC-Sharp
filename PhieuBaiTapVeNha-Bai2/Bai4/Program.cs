using System.Text;

namespace Bai4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            HocSinh[] dsHocSinh = new HocSinh[5];
            for (int i = 0; i < dsHocSinh.Length; i++)
            {
                dsHocSinh[i] = NhapThongTinHocSinh(i + 1);
            }
            int tongTuoi = 0;
            foreach (HocSinh hs in dsHocSinh)
            {
                tongTuoi += hs.tuoi;
            }
            Console.WriteLine($"Tổng số tuổi của 5 học sinh: {tongTuoi}");
        }
        struct HocSinh
        {
            public string hoTen;
            public int tuoi;
            public bool gioiTinh; 
        }
        static HocSinh NhapThongTinHocSinh(int soThuTu)
        {
            HocSinh hs = new HocSinh();

            Console.WriteLine($"Nhập thông tin cho học sinh thứ {soThuTu}:");

            Console.Write("Họ tên: ");
            hs.hoTen = Console.ReadLine();

            Console.Write("Tuổi: ");
            hs.tuoi = int.Parse(Console.ReadLine());

            Console.Write("Giới tính (nam = true, nữ = false): ");
            hs.gioiTinh = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            return hs;
        }
    }
}
