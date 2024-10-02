using System.Text;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên học sinh: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập điểm thi cuối kỳ: ");
            double diem;
            while (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {
                Console.Write("Điểm không hợp lệ. Vui lòng nhập điểm từ 0 đến 10: ");
            }
            string hoTenInHoa = hoTen.ToUpper();
            string xepLoai;
            if (diem >= 8)
            {
                xepLoai = "Giỏi";
            }
            else if (diem >= 6.5)
            {
                xepLoai = "Khá";
            }
            else if (diem >= 5)
            {
                xepLoai = "Trung bình";
            }
            else
            {
                xepLoai = "Yếu";
            }
            Console.WriteLine($"Họ tên học sinh: {hoTenInHoa}");
            Console.WriteLine($"Xếp loại: {xepLoai}");
        }
    }
}
