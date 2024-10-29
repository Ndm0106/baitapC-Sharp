using System.Text;

namespace NguyenDinhManh_2019603690_proj63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            int choice;

            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Chọn một tùy chọn:");
                Console.WriteLine("1. Thêm một khóa học");
                Console.WriteLine("2. Hiện thị các khóa học");
                Console.WriteLine("3. Tìm kiếm khóa học");
                Console.WriteLine("4. Tìm kiếm sinh viên");
                Console.WriteLine("5. Xóa một khóa học");
                Console.WriteLine("6. Kết thúc");
                Console.Write("Nhập tùy chọn của bạn: ");

                // Kiểm soát lỗi khi nhập lựa chọn
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    continue;
                }

                switch (choice)
                {
                    case 1: // Thêm một khóa học
                        Course course = new Course();
                        course.InputCourse();
                        courses.Add(course);
                        Console.WriteLine("Đã thêm khóa học.");
                        break;

                    case 2: // Hiện thị các khóa học
                        Console.WriteLine("Danh sách các khóa học:");
                        foreach (var c in courses)
                        {
                            c.DisplayCourseAndStudents();
                            Console.WriteLine();
                        }
                        break;

                    case 3: // Tìm kiếm khóa học
                        Console.Write("Nhập mã khóa học cần tìm: ");
                        string searchCourseId = Console.ReadLine();
                        var foundCourse = courses.FirstOrDefault(c => c.CourseId.Equals(searchCourseId, StringComparison.OrdinalIgnoreCase));

                        if (foundCourse != null)
                        {
                            Console.WriteLine("Thông tin khóa học:");
                            foundCourse.DisplayCourseAndStudents();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy khóa học với mã đó.");
                        }
                        break;

                    case 4: // Tìm kiếm sinh viên
                        Console.Write("Nhập mã sinh viên cần tìm: ");
                        string searchStudentId = Console.ReadLine();
                        var foundStudent = courses.SelectMany(c => c.Students)
                                                  .FirstOrDefault(s => s.studentID.ToString() == searchStudentId);

                        if (foundStudent != null)
                        {
                            Console.WriteLine("Thông tin sinh viên:");
                            Console.WriteLine(foundStudent);
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên với mã đó.");
                        }
                        break;

                    case 5: // Xóa một khóa học
                        Console.Write("Nhập mã khóa học cần xóa: ");
                        string courseIdToDelete = Console.ReadLine();
                        var courseToDelete = courses.FirstOrDefault(c => c.CourseId.Equals(courseIdToDelete, StringComparison.OrdinalIgnoreCase));

                        if (courseToDelete != null)
                        {
                            courses.Remove(courseToDelete);
                            Console.WriteLine("Đã xóa khóa học.");
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy khóa học với mã đó.");
                        }
                        break;

                    case 6: // Kết thúc
                        Console.WriteLine("Kết thúc chương trình.");
                        break;

                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                Console.WriteLine(); // Xuống dòng
            } while (choice != 6);
        }
    }
}
