namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chieudai, chieurong;
            Console.Write("chieu dai:");
            chieudai = Convert.ToDouble(Console.ReadLine());
            Console.Write("chieu rong:");
            chieurong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Chu vi:" + ((chieudai + chieurong) * 2) + " Dien tich:" + chieurong * chieudai);
        }
    }
}
