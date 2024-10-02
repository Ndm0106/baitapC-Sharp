namespace BtTongHop
{
    internal class Program
    {
        public struct SinhVien
        {
            public int Id;
            public string HoTen;
            public string GioiTinh;
            public int Tuoi;
            public double DiemToan;
            public double DiemLy;
            public double DiemHoa;
            public double DiemTrungBinh;
            public string HocLuc;

            public SinhVien(int id, string hoTen, string gioiTinh, int tuoi, double diemToan, double diemLy, double diemHoa)
            {
                Id = id;
                HoTen = hoTen;
                GioiTinh = gioiTinh;
                Tuoi = tuoi;
                DiemToan = diemToan;
                DiemLy = diemLy;
                DiemHoa = diemHoa;
                DiemTrungBinh = (diemToan + diemLy + diemHoa) / 3;
                HocLuc = XepLoaiHocLuc(DiemTrungBinh);
            }

            public static string XepLoaiHocLuc(double diemTrungBinh)
            {
                if (diemTrungBinh >= 8) return "Giỏi";
                if (diemTrungBinh >= 6.5) return "Khá";
                if (diemTrungBinh >= 5) return "Trung Bình";
                return "Yếu";
            }

            public override string ToString()
            {
                return $"ID: {Id}, Họ Tên: {HoTen}, Giới Tính: {GioiTinh}, Tuổi: {Tuoi}, Toán: {DiemToan}, Lý: {DiemLy}, Hóa: {DiemHoa}, TB: {DiemTrungBinh}, Học Lực: {HocLuc}";
            }
        }
        static List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        static int idTuDong = 1; // ID tự động tăng

        static void Main(string[] args)
        {
            DocFile();
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Cập nhật thông tin sinh viên bởi ID");
                Console.WriteLine("3. Xóa sinh viên bởi ID");
                Console.WriteLine("4. Tìm kiếm sinh viên theo tên");
                Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung bình");
                Console.WriteLine("6. Sắp xếp sinh viên theo tên");
                Console.WriteLine("7. Hiển thị danh sách sinh viên");
                Console.WriteLine("8. Ghi danh sách sinh viên vào file 'student.txt'");
                Console.WriteLine("9. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            ThemSinhVien();
                            break;
                        case "2":
                            CapNhatSinhVien();
                            break;
                        case "3":
                            XoaSinhVien();
                            break;
                        case "4":
                            TimKiemSinhVien();
                            break;
                        case "5":
                            SapXepTheoDiemTB();
                            break;
                        case "6":
                            SapXepTheoTen();
                            break;
                        case "7":
                            HienThiDanhSach();
                            break;
                        case "8":
                            GhiFile();
                            break;
                        case "9":
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
        }
        static void ThemSinhVien()
        {
            Console.WriteLine("\nNhập thông tin sinh viên:");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Giới tính: ");
            string gioiTinh = Console.ReadLine();

            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Điểm Toán: ");
            double diemToan = double.Parse(Console.ReadLine());

            Console.Write("Điểm Lý: ");
            double diemLy = double.Parse(Console.ReadLine());

            Console.Write("Điểm Hóa: ");
            double diemHoa = double.Parse(Console.ReadLine());

            SinhVien sv = new SinhVien(idTuDong++, hoTen, gioiTinh, tuoi, diemToan, diemLy, diemHoa);
            danhSachSinhVien.Add(sv);

            Console.WriteLine("Sinh viên đã được thêm thành công.");
        }

        static void CapNhatSinhVien()
        {
            Console.Write("\nNhập ID sinh viên cần cập nhật: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < danhSachSinhVien.Count; i++)
            {
                if (danhSachSinhVien[i].Id == id)
                {
                    Console.WriteLine($"Cập nhật thông tin sinh viên với ID {id}:");
                    Console.Write("Họ tên: ");
                    string hoTen = Console.ReadLine();

                    Console.Write("Giới tính: ");
                    string gioiTinh = Console.ReadLine();

                    Console.Write("Tuổi: ");
                    int tuoi = int.Parse(Console.ReadLine());

                    Console.Write("Điểm Toán: ");
                    double diemToan = double.Parse(Console.ReadLine());

                    Console.Write("Điểm Lý: ");
                    double diemLy = double.Parse(Console.ReadLine());

                    Console.Write("Điểm Hóa: ");
                    double diemHoa = double.Parse(Console.ReadLine());

                    danhSachSinhVien[i] = new SinhVien(id, hoTen, gioiTinh, tuoi, diemToan, diemLy, diemHoa);
                    Console.WriteLine("Cập nhật thông tin thành công.");
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy sinh viên với ID đã nhập.");
        }

        static void XoaSinhVien()
        {
            Console.Write("\nNhập ID sinh viên cần xóa: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < danhSachSinhVien.Count; i++)
            {
                if (danhSachSinhVien[i].Id == id)
                {
                    danhSachSinhVien.RemoveAt(i);
                    Console.WriteLine("Xóa sinh viên thành công.");
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy sinh viên với ID đã nhập.");
        }

        static void TimKiemSinhVien()
        {
            Console.Write("\nNhập tên sinh viên cần tìm: ");
            string ten = Console.ReadLine();

            bool timThay = false;
            foreach (var sv in danhSachSinhVien)
            {
                if (sv.HoTen.Contains(ten, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(sv);
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy sinh viên nào có tên đã nhập.");
            }
        }

        static void SapXepTheoDiemTB()
        {
            danhSachSinhVien.Sort((sv1, sv2) => sv2.DiemTrungBinh.CompareTo(sv1.DiemTrungBinh));
            Console.WriteLine("Danh sách đã được sắp xếp theo điểm trung bình giảm dần.");
        }

        static void SapXepTheoTen()
        {
            danhSachSinhVien.Sort((sv1, sv2) => string.Compare(sv1.HoTen, sv2.HoTen, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Danh sách đã được sắp xếp theo tên.");
        }

        static void HienThiDanhSach()
        {
            if (danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên trống.");
            }
            else
            {
                Console.WriteLine("\nDanh sách sinh viên:");
                foreach (var sv in danhSachSinhVien)
                {
                    Console.WriteLine(sv);
                }
            }
        }

        static void DocFile()
        {
            if (File.Exists("student.txt"))
            {
                using (StreamReader reader = new StreamReader("student.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        int id = int.Parse(parts[0]);
                        string hoTen = parts[1];
                        string gioiTinh = parts[2];
                        int tuoi = int.Parse(parts[3]);
                        double diemToan = double.Parse(parts[4]);
                        double diemLy = double.Parse(parts[5]);
                        double diemHoa = double.Parse(parts[6]);

                        SinhVien sv = new SinhVien(id, hoTen, gioiTinh, tuoi, diemToan, diemLy, diemHoa);
                        danhSachSinhVien.Add(sv);
                    }

                    idTuDong = danhSachSinhVien.Count > 0 ? danhSachSinhVien[^1].Id + 1 : 1;
                }
            }
        }
        static void GhiFile()
        {
            using (StreamWriter writer = new StreamWriter("student.txt"))
            {
                foreach (var sv in danhSachSinhVien)
                {
                    writer.WriteLine($"{sv.Id},{sv.HoTen},{sv.GioiTinh},{sv.Tuoi},{sv.DiemToan},{sv.DiemLy},{sv.DiemHoa},{sv.DiemTrungBinh},{sv.HocLuc}");
                }
            }
            Console.WriteLine("Ghi danh sách sinh viên vào file 'student.txt' thành công.");
        }
    }
}
