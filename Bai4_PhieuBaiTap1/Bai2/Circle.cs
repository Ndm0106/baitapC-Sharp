using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle()
        {
            radius = 1.0; // Giá trị mặc định
        }

        // Phương thức khởi tạo có một tham số
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }

        // Phương thức tính chu vi
        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
