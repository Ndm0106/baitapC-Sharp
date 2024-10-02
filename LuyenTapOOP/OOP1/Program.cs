using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Person
    {
        private string _id;
        private string _name;
        private int _age;

        public string Id
            { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = "P01";
            p.Name = "Test";
            p.Age = 10; 
            Console.WriteLine("Person ID: "+p.Id);
            Console.WriteLine("Person Nam: " + p.Name);
            Console.WriteLine("Person Age: " + p.Age);
        }
    }
}
