namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Nhập vào một số nguyên: ");
                number = int.Parse(Console.ReadLine());
            } while (number <= 0);

            Console.WriteLine($"Số nguyên dương bạn đã nhập là: {number}");
        }
    }
}
