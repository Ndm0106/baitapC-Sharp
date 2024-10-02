using System.Text;
using System.Transactions;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            double chieudai, chieurong;
            Console.Write("nhập chiều dài:");
            chieudai = double.Parse(Console.ReadLine());
            Console.Write("nhập chiều dài:");
            chieurong = double.Parse(Console.ReadLine());
            while(chieudai <=0 || chieurong <=0)
            {
                Console.WriteLine("nhập lại");
                Console.Write("nhập chiều dài:");
                chieudai = double.Parse(Console.ReadLine());
                Console.Write("nhập chiều dài:");
                chieurong = double.Parse(Console.ReadLine());
            }   
            Console.WriteLine("Chu vi:"+ChuViHinhChuNhat(chieudai, chieurong)+" Diện tích: "+DienTichHinhChuNhat(chieudai,chieurong));
        }
        static double ChuViHinhChuNhat(double a, double b)
        {
            return (a + b) * 2;
        }
        static double DienTichHinhChuNhat(double a, double b)
        {
            return a * b;
        }
    }
}
