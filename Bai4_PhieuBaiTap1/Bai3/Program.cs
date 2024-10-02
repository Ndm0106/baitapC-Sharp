namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.DisplayInfo();

            Console.WriteLine();

            // Tạo đối tượng Student với một tham số (id)
            Student student2 = new Student("S12345");
            student2.DisplayInfo();

            Console.WriteLine();

            // Tạo đối tượng Student với tất cả các tham số
            Student student3 = new Student("S67890", "Nguyen Van A", 9);
            student3.DisplayInfo();

            Console.WriteLine();

            // Cập nhật thông tin sinh viên và kiểm tra học bổng
            student2.Name = "Tran Thi B";
            student2.Mark = 7;
            student2.DisplayInfo();
        }
    }
}
