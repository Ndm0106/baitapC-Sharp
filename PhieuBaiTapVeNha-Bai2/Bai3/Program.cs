using System.Text;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> ThanhPho = new List<string> { "Hà Nội", "Hải Phòng", "TP Hồ Chí Minh" ,"Đà Nẵng", "Cần Thơ" };
            ThanhPho.Sort();
            foreach (string s in ThanhPho)
            {
                
                Console.WriteLine(s);
            }
            ThanhPho.Remove("Hà Nội");
            ThanhPho.Add("Quảng Ninh");
            ThanhPho.Add("Bắc Ninh");
            ThanhPho.Add("Tây Ninh");
            ThanhPho.Add("Bắc Giang");
            ThanhPho.Add("Đồng Nai");
            Console.WriteLine("--Sau khi thêm--");
            foreach (string s in ThanhPho)
            {
                
                Console.WriteLine(s);
            }
        }
    }
}
