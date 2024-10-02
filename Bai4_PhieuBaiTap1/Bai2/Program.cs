namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Console.WriteLine("Circle 1 - Bán kính: " + circle1.Radius);
            Console.WriteLine("Diện tích: " + circle1.Area());
            Console.WriteLine("Chu vi: " + circle1.Perimeter());

            // Tạo đối tượng Circle với bán kính tùy chỉnh
            Console.WriteLine("\nNhập bán kính cho hình tròn thứ 2:");
            double radius = double.Parse(Console.ReadLine());
            Circle circle2 = new Circle(radius);
            Console.WriteLine("Circle 2 - Bán kính: " + circle2.Radius);
            Console.WriteLine("Diện tích: " + circle2.Area());
            Console.WriteLine("Chu vi: " + circle2.Perimeter());
        }
    }
}
