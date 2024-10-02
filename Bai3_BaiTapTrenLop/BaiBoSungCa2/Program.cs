using System.Globalization;

namespace BaiBoSungCa2
{
    internal class Program
    {
        public struct BenhNhan
        {
            public int MaBenhNhan;
            public string HoTen;
            public DateTime NgayVaoVien;

            public BenhNhan(int maBenhNhan, string hoTen, DateTime ngayVaoVien)
            {
                MaBenhNhan = maBenhNhan;
                HoTen = hoTen;
                NgayVaoVien = ngayVaoVien;
            }

            public override string ToString()
            {
                return $"Mã bệnh nhân: {MaBenhNhan}, Họ tên: {HoTen}, Ngày vào viện: {NgayVaoVien:dd-MM-yyyy}, Số ngày nằm viện: {TinhSoNgayNamVien()}";
            }

            public int TinhSoNgayNamVien()
            {
                return (DateTime.Now - NgayVaoVien).Days;
            }
        }
        static List<BenhNhan> danhSachBenhNhan = new List<BenhNhan>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Nhập thông tin bệnh nhân");
                Console.WriteLine("2. Hiển thị danh sách bệnh nhân");
                Console.WriteLine("3. Xóa thông tin bệnh nhân");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        NhapThongTinBenhNhan();
                        break;
                    case "2":
                        HienThiDanhSachBenhNhan();
                        break;
                    case "3":
                        XoaThongTinBenhNhan();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
        static void NhapThongTinBenhNhan()
        {
            Console.WriteLine("\nNhập thông tin bệnh nhân:");

            int maBenhNhan;
            while (true)
            {
                Console.Write("Nhập mã bệnh nhân: ");
                if (int.TryParse(Console.ReadLine(), out maBenhNhan))
                {
                    if (danhSachBenhNhan.Exists(bn => bn.MaBenhNhan == maBenhNhan))
                    {
                        Console.WriteLine("Mã bệnh nhân đã tồn tại. Vui lòng nhập mã khác.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Mã bệnh nhân không hợp lệ. Vui lòng nhập lại.");
                }
            }

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();

            DateTime ngayVaoVien;
            while (true)
            {
                Console.Write("Nhập ngày vào viện (dd-MM-yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, DateTimeStyles.None, out ngayVaoVien))
                    break;
                else
                    Console.WriteLine("Ngày vào viện không hợp lệ. Vui lòng nhập lại.");
            }

            BenhNhan benhNhan = new BenhNhan(maBenhNhan, hoTen, ngayVaoVien);
            danhSachBenhNhan.Add(benhNhan);

            Console.WriteLine("Bệnh nhân đã được thêm vào danh sách.");
        }

        // Câu 4: Hiển thị danh sách bệnh nhân
        static void HienThiDanhSachBenhNhan()
        {
            if (danhSachBenhNhan.Count == 0)
            {
                Console.WriteLine("Danh sách bệnh nhân trống.");
                return;
            }

            Console.WriteLine("\nDanh sách bệnh nhân:");
            foreach (var benhNhan in danhSachBenhNhan)
            {
                Console.WriteLine(benhNhan);
            }
        }

        // Câu 5: Xóa thông tin bệnh nhân
        static void XoaThongTinBenhNhan()
        {
            if (danhSachBenhNhan.Count == 0)
            {
                Console.WriteLine("Danh sách bệnh nhân trống.");
                return;
            }

            Console.Write("\nNhập mã bệnh nhân cần xóa: ");
            if (int.TryParse(Console.ReadLine(), out int maBenhNhan))
            {
                var benhNhan = danhSachBenhNhan.Find(bn => bn.MaBenhNhan == maBenhNhan);

                if (benhNhan.MaBenhNhan != 0)
                {
                    danhSachBenhNhan.Remove(benhNhan);
                    Console.WriteLine("Bệnh nhân đã được xóa thành công.");
                    HienThiDanhSachBenhNhan();
                }
                else
                {
                    Console.WriteLine("Không tìm thấy bệnh nhân có mã đã nhập.");
                }
            }
            else
            {
                Console.WriteLine("Mã bệnh nhân không hợp lệ.");
            }
        }
    }
}
