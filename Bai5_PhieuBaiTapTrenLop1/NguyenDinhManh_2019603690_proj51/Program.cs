using System.Text;

namespace NguyenDinhManh_2019603690_proj51
{
    internal class Program
    {
        static List<ThiSinhA> danhSachThiSinh = new List<ThiSinhA>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int luachon;
            do
            {
                Console.WriteLine("1. Nhập thông tin 1 thí sinh");
                Console.WriteLine("2. Hiển thị danh sách các thí sinh");
                Console.WriteLine("3. Hiển thị các sinh viên theo tổng điểm");
                Console.WriteLine("4. Hiển thị các sinh viên theo địa chỉ");
                Console.WriteLine("5. Tìm kiếm theo số báo danh");
                Console.WriteLine("6. Kết thúc chương trình.");
                Console.Write("Vui lòng nhập lựa chọn:");
                luachon = int.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        NhapThiSinh();
                        break;
                    case 2:
                        HienThiDanhSach();
                        break;
                    case 3:
                        HienThiTheoTongDiem();
                        break;
                    case 4:
                        HienThiTheoDiaChi();
                        break;
                    case 5:
                        TimKiemTheoSBD();
                        break;
                    case 6:
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            } while (luachon!=6);
        }
        static void NhapThiSinh()
        {
            ThiSinhA thiSinhA = new ThiSinhA();
            thiSinhA.Input();
            danhSachThiSinh.Add(thiSinhA);
        }
        static void HienThiDanhSach()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Danh sách các thí sinh");
            foreach (ThiSinhA ts in danhSachThiSinh)
            {
                ts.Output();
            }
        }
        static void HienThiTheoTongDiem()
        {
            var danhSachSapXep = danhSachThiSinh.OrderByDescending(ts => ts.TongDiem).ToList();
            Console.WriteLine("Danh sach thi sinh theo tong diem giam dan:");
            foreach (ThiSinhA ts in danhSachSapXep)
            {
                ts.Output();
            }
        }

        // Hiển thị thí sinh theo địa chỉ
        static void HienThiTheoDiaChi()
        {
            Console.Write("Nhap dia chi can tim: ");
            string diaChiTimKiem = Console.ReadLine();
            var danhSachDiaChi = danhSachThiSinh.Where(ts => ts.DiaChi.Contains(diaChiTimKiem)).ToList();
            Console.WriteLine($"Danh sach thi sinh o dia chi: {diaChiTimKiem}");
            foreach (ThiSinhA ts in danhSachDiaChi)
            {
                ts.Output();
            }
        }

        // Tìm kiếm theo số báo danh
        static void TimKiemTheoSBD()
        {
            Console.Write("Nhap so bao danh can tim: ");
            string sbd = Console.ReadLine();
            var thiSinhTimDuoc = danhSachThiSinh.FirstOrDefault(ts => ts.SoBaoDanh == sbd);
            if (thiSinhTimDuoc != null)
            {
                Console.WriteLine("Thong tin thi sinh can tim:");
                thiSinhTimDuoc.Output();
            }
            else
            {
                Console.WriteLine("Khong tim thay thi sinh voi so bao danh: " + sbd);
            }
        }
    }
}
