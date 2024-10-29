using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj63
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int Fee { get; set; }
        public List<Student> Students { get; set; }

        // Phương thức khởi tạo không tham số
        public Course()
        {
            Students = new List<Student>();
        }

        // Phương thức nhập dữ liệu cho khóa học
        public void InputCourse()
        {
            Console.Write("Nhập mã khóa học: ");
            CourseId = Console.ReadLine();

            Console.Write("Nhập tên khóa học: ");
            CourseName = Console.ReadLine();

            Console.Write("Nhập học phí: ");
            Fee = int.Parse(Console.ReadLine());

            Console.Write("Nhập số lượng sinh viên: ");
            int studentCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
                Student student = new Student();
                student.InputStudent();
                Students.Add(student);
            }
        }

        // Phương thức hiển thị thông tin khóa học và danh sách sinh viên
        public void DisplayCourseAndStudents()
        {
            Console.WriteLine($"=== Course Information ===");
            Console.WriteLine($"Course ID: {CourseId}");
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Course Fee: {Fee}");
            Console.WriteLine($"{"sid",-10} {"name",-15} {"mark",-5}"); // Định dạng tiêu đề

            if (Students.Count == 0)
            {
                Console.WriteLine("No students enrolled in this course.");
                return;
            }

            foreach (var student in Students)
            {
                Console.WriteLine(student.ToString()); // Gọi phương thức ToString của sinh viên
            }
        }
    }
}
