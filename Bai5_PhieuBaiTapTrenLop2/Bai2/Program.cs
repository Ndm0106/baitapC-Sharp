namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());
            GiaiPhuongTrinhBac2 giaiPhuongTrinhBac2 = new GiaiPhuongTrinhBac2(a,b,c);
            giaiPhuongTrinhBac2.Solve();
        }
    }
}
