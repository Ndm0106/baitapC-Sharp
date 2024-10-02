using System.Text;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập từ 1 đến 7: ");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0 || n > 7)
            {
                Console.Write("Nhập lại: ");
                n = int.Parse(Console.ReadLine());
            }
            switch (n)
            {
                case 1:
                    Console.WriteLine("Chủ nhật");
                    break;
                case 2:
                    Console.WriteLine("Thứ hai");
                    break;
                case 3:
                    Console.WriteLine("Thứ ba");
                    break;
                case 4:
                    Console.WriteLine("Thứ tư");
                    break;
                case 5:
                    Console.WriteLine("Thứ năm");
                    break;
                case 6:
                    Console.WriteLine("Thứ sáu");
                    break;
                case 7:
                    Console.WriteLine("Thứ bảy");
                    break;
            }
        }
    }
}
