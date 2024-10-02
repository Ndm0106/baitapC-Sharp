namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Các số nguyên tố trong mảng là:");
            foreach (int num in arr)
            {
                if (KiemTraSoNguyenTo(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
        static bool KiemTraSoNguyenTo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
