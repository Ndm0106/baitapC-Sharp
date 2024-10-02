using System.Text;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số từ 1 đến 100: ");
            int n = int.Parse(Console.ReadLine());

            do
            {

                Console.WriteLine("vui lòng nhập lại");
                Console.Write("Nhập số từ 1 đến 100: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n>100);




            //while (n < 1 || n>100)
            //{
            //    Console.WriteLine("vui lòng nhập lại");
            //    Console.Write("Nhập số từ 1 đến 100: ");
            //    n = int.Parse(Console.ReadLine());
            //}
            Console.WriteLine(n);
        }
    }
}
