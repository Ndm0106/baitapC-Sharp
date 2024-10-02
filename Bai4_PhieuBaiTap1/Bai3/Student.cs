using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Student
    {
        private string id;
        private string name;
        private int mark;
        private int scholarship;

        // Phương thức thiết lập (Setters) và lấy ra (Getters) cho các thuộc tính id, name, mark
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Mark
        {
            get { return mark; }
            set
            {
                mark = value;
                SetScholarship(); // Thiết lập học bổng dựa trên điểm
            }
        }

        public int Scholarship
        {
            get { return scholarship; }
        }

        // Phương thức thiết lập học bổng dựa trên điểm
        private void SetScholarship()
        {
            if (mark > 8)
            {
                scholarship = 500;
            }
            else if (mark >= 7 && mark <= 8)
            {
                scholarship = 300;
            }
            else
            {
                scholarship = 0;
            }
        }

        // Phương thức khởi tạo không tham số
        public Student()
        {
            id = "unknown";
            name = "unknown";
            mark = 0;
            SetScholarship(); // Đảm bảo học bổng được tính
        }

        // Phương thức khởi tạo với một tham số id
        public Student(string id)
        {
            this.id = id;
            name = "unknown";
            mark = 0;
            SetScholarship();
        }

        // Phương thức khởi tạo với tất cả các tham số
        public Student(string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
            SetScholarship();
        }

        // Phương thức hiển thị thông tin của sinh viên
        public void DisplayInfo()
        {
            Console.WriteLine($"Mã sinh viên: {id}");
            Console.WriteLine($"Họ tên: {name}");
            Console.WriteLine($"Điểm: {mark}");
            Console.WriteLine($"Học bổng: {scholarship}");
        }
    }
}
