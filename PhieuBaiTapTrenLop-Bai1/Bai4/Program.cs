namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BacLuong, NCTL, NgayCong;
            double PhuCap;
            double TienLinh;
            Console.Write("nhap bac luong:");
            BacLuong = int.Parse(Console.ReadLine());
            Console.Write("nhap phu cap:");
            PhuCap = double.Parse(Console.ReadLine());
            Console.Write("nhap ngay cong:");
            NgayCong = int.Parse(Console.ReadLine());
            if (NgayCong < 25)
            {
                NCTL = NgayCong;
                TienLinh = BacLuong * 1490000 * NCTL * PhuCap;
                Console.WriteLine("TienLinh: " + TienLinh);
            }
            else if (NgayCong >= 25)
            {
                NCTL = 25 - (NgayCong - 25) * 2;
                TienLinh = BacLuong * 1490000 * NCTL * PhuCap;
                Console.WriteLine("TienLinh: " + TienLinh);
            }
        }
    }
}
