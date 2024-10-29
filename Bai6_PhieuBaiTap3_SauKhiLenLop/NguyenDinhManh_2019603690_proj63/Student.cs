using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhManh_2019603690_proj63
{
    public class Student
    {
		private int studentid;

		public int studentID
        {
			get { return studentid; }
			set { studentid = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
        private string mark;

       

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public Student()
        {
        }

        public Student(int studentid, string name, string mark)
        {
            this.studentid = studentid;
            this.name = name;
            this.mark = mark;
        }

        public void InputStudent()
		{
            Console.Write("Nhap id:");
            studentID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten:");
            name = Console.ReadLine();
            Console.Write("Nhap mark:");
            mark = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"{studentID,-10} {Name,-15} {Mark,-5}";
        }
    }
}
