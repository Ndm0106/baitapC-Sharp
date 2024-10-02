namespace NguyenDinhManh_2019603690_proj61
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Them mot sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Tim kiem sinh vien theo id");
                Console.WriteLine("4. Tim kiem sinh vien theo dia chi");
                Console.WriteLine("5. Xoa mot sinh vien theo id");
                Console.WriteLine("6. Ket thuc chuong trinh");
                Console.Write("Lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        HienThiDanhSach();
                        break;
                    case 3:
                        TimKiemTheoId();
                        break;
                    case 4:
                        TimKiemTheoDiaChi();
                        break;
                    case 5:
                        XoaSinhVienTheoId();
                        break;
                    case 6:
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
            } while (choice != 6);
        }
        static void ThemSinhVien()
        {
            Student student = new Student();
            student.Input();
            students.Add(student);
            Console.WriteLine("Da them sinh vien thanh cong.");
        }

        static void HienThiDanhSach()
        {
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var student in students)
            {
                student.Output();
                Console.WriteLine($"Tong diem: {student.Total()}");
                Console.WriteLine("-------------------");
            }
        }

        static void TimKiemTheoId()
        {
            Console.Write("Nhap id sinh vien can tim: ");
            int id = int.Parse(Console.ReadLine());
            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                student.Output();
                Console.WriteLine($"Tong diem: {student.Total()}");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co id nay.");
            }
        }

        static void TimKiemTheoDiaChi()
        {
            Console.Write("Nhap dia chi sinh vien can tim: ");
            string address = Console.ReadLine();
            var result = students.FindAll(s => s.Address == address);
            if (result.Count > 0)
            {
                foreach (var student in result)
                {
                    student.Output();
                    Console.WriteLine($"Tong diem: {student.Total()}");
                    Console.WriteLine("-------------------");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co dia chi nay.");
            }
        }

        static void XoaSinhVienTheoId()
        {
            Console.Write("Nhap id sinh vien can xoa: ");
            int id = int.Parse(Console.ReadLine());
            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Da xoa sinh vien thanh cong.");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co id nay.");
            }
        }
    }
}
