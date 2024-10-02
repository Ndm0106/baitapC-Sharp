using System.Globalization;
using System.Text;

namespace BaiBoSungCa1
{
    internal class Program
    {
        public struct NhanVien
        {
            public int MaNhanVien;
            public string HoTen;
            public DateTime NgaySinh;

            public NhanVien(int maNhanVien, string hoTen, DateTime ngaySinh)
            {
                MaNhanVien = maNhanVien;
                HoTen = hoTen;
                NgaySinh = ngaySinh;
            }

            public override string ToString()
            {
                return $"Mã nhân viên: {MaNhanVien}, Họ tên: {HoTen}, Ngày sinh: {NgaySinh:dd-MM-yyyy}, Tuổi: {TinhTuoi()}";
            }

            public int TinhTuoi()
            {
                int tuoi = DateTime.Now.Year - NgaySinh.Year;
                if (DateTime.Now.DayOfYear < NgaySinh.DayOfYear)
                    tuoi--;
                return tuoi;
            }
        }
        static List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Nhập thông tin nhân viên");
                Console.WriteLine("2. Hiển thị danh sách nhân viên");
                Console.WriteLine("3. Tìm nhân viên theo tên");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        NhapThongTinNhanVien();
                        break;
                    case "2":
                        HienThiDanhSachNhanVien();
                        break;
                    case "3":
                        TimNhanVienTheoTen();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
        static void NhapThongTinNhanVien()
        {
            Console.WriteLine("\nNhập thông tin nhân viên:");

            int maNhanVien;
            while (true)
            {
                Console.Write("Nhập mã nhân viên: ");
                if (int.TryParse(Console.ReadLine(), out maNhanVien))
                {
                    if (danhSachNhanVien.Exists(nv => nv.MaNhanVien == maNhanVien))
                    {
                        Console.WriteLine("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Mã nhân viên không hợp lệ. Vui lòng nhập lại.");
                }
            }

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();

            DateTime ngaySinh;
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd-MM-yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, DateTimeStyles.None, out ngaySinh))
                    break;
                else
                    Console.WriteLine("Ngày sinh không hợp lệ. Vui lòng nhập lại.");
            }

            NhanVien nhanVien = new NhanVien(maNhanVien, hoTen, ngaySinh);
            danhSachNhanVien.Add(nhanVien);

            Console.WriteLine("Nhân viên đã được thêm vào danh sách.");
        }

        // Câu 4: Hiển thị danh sách nhân viên
        static void HienThiDanhSachNhanVien()
        {
            if (danhSachNhanVien.Count == 0)
            {
                Console.WriteLine("Danh sách nhân viên trống.");
                return;
            }

            Console.WriteLine("\nDanh sách nhân viên:");
            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine(nhanVien);
            }
        }

        // Câu 5: Tìm nhân viên theo tên
        static void TimNhanVienTheoTen()
        {
            Console.Write("\nNhập tên nhân viên cần tìm: ");
            string tenCanTim = Console.ReadLine().ToLower();

            List<NhanVien> ketQuaTimKiem = danhSachNhanVien.FindAll(nv => nv.HoTen.ToLower().Contains(tenCanTim));

            if (ketQuaTimKiem.Count == 0)
            {
                Console.WriteLine("Không tìm thấy nhân viên nào với tên đã nhập.");
            }
            else
            {
                Console.WriteLine($"\nTìm thấy {ketQuaTimKiem.Count} nhân viên:");
                foreach (var nhanVien in ketQuaTimKiem)
                {
                    Console.WriteLine(nhanVien);
                }
            }
        }
    }
}
