namespace DeMinhHoa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice;
            do
            {
                Console.WriteLine("--------Menu-------- ");
                Console.WriteLine("1. Them nhan vien");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Sap xep");
                Console.WriteLine("4. Them");
                Console.WriteLine("5. Sua");
                Console.WriteLine("6. Xoa");
                Console.WriteLine("7. Thoat"); 
                Console.Write("Nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ThemNhanVien();
                        break;
                    case 2:
                        HienThiDanhSach();
                        break;
                    case 3:
                        Console.WriteLine("3. Sap xep");
                        break;
                    case 4:
                        return;  
                }
            } while (choice != 7);
        }
        static List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        static void ThemNhanVien()
        {
            NhanVien nv = new NhanVien();
            nv.NhapThongTin();

            // Kiểm tra trùng mã nhân viên
            foreach (NhanVien nhanVien in danhSachNhanVien)
            {
                if (nv.Equals(nhanVien))
                {
                    Console.WriteLine("Mã nhân viên đã tồn tại. Không thể thêm nhân viên.");
                    return;
                }
            }

            danhSachNhanVien.Add(nv);
            Console.WriteLine("Đã thêm nhân viên.");
        }
        static void HienThiDanhSach()
        {
            Console.WriteLine("Họ Tên\tĐịa Chỉ\tMã NV\tChức Vụ\tLương Cơ Bản");
            foreach (NhanVien nhanVien in danhSachNhanVien)
            {
                nhanVien.HienThiThongTin();
            }
        }
    }
}
