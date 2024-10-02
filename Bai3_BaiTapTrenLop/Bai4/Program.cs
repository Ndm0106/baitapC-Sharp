namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Vòng lặp để in bảng cửu chương từ 2 đến 9
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"Bảng cửu chương {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine(); // In dòng trống để ngăn cách giữa các bảng
            }
        }
    }
}
