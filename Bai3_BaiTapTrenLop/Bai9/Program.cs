using System.Text;

namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            List<double> danhsach = new List<double>();
            Console.WriteLine("Nhập vào 5 số thực:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Số thực thứ " + (i + 1) + ": ");
                double num = double.Parse(Console.ReadLine());
                danhsach.Add(num);
            }
            danhsach.Sort();
            Console.WriteLine("danh sách");
            foreach (double num in danhsach)
            {
                
                Console.Write(num);
            }
            Console.WriteLine("danh sách sau khi xoá");
            danhsach.RemoveAll(n => n < 0);
            foreach (double num in danhsach)
            {
                
                Console.Write(num);
            }

            Console.Write("Nhập số thực x để chèn vào danh sách: ");
            double x = double.Parse(Console.ReadLine());

            // Tìm vị trí chèn x
            int index = danhsach.BinarySearch(x);
            if (index < 0)
            {
                index = ~index; // Tìm vị trí chèn nếu không tìm thấy số x
            }
            danhsach.Insert(index, x);

            // In ra danh sách đã bổ sung
            Console.WriteLine("Danh sách sau khi chèn số x:");
            foreach (var number in danhsach)
            {
                Console.WriteLine(number);
            }
        }
    }
}
