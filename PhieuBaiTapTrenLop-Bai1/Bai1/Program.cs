namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap so n:");
            n = Convert.ToInt32(Console.ReadLine());
            CheckSoChanLe(n);
        }
        static void CheckSoChanLe(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("n la so chan");
            }
            else
            {
                Console.WriteLine("n la so le");
            }
        }
        static void CheckSoAm(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("n la so duong");
            }
            else if (n < 0)
            {
                Console.WriteLine("n la so am");
            }
        }
    }
}
