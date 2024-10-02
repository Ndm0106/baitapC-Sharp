namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số a và epsilon từ bàn phím
            Console.Write("Nhập số a (a >= 0): ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a) || a < 0)
            {
                Console.Write("Vui lòng nhập một số dương hoặc bằng 0: ");
            }

            Console.Write("Nhập epsilon (epsilon > 0): ");
            double epsilon;
            while (!double.TryParse(Console.ReadLine(), out epsilon) || epsilon <= 0)
            {
                Console.Write("Vui lòng nhập một giá trị epsilon lớn hơn 0: ");
            }

            // Cân bậc hai của số a theo công thức
            double x0 = 1; // Khởi tạo x(0)
            double x = x0;
            double xNext;

            // Lặp cho đến khi độ chính xác đạt yêu cầu
            do
            {
                xNext = (a / x + x) / 2;
                if (Math.Abs(xNext - x) < epsilon)
                {
                    break;
                }
                x = xNext;
            } while (true);

            // Hiển thị kết quả
            Console.WriteLine($"Căn bậc hai của {a} là: {x}");

            // Đợi người dùng nhấn phím để thoát ứng dụng
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
