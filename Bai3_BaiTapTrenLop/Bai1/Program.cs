using System.Text;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Hãy nhập vào 2 số");
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a+" + "+b+" = "+(a+b));
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Hãy nhập vào 2 số");
                Console.Write("a= ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b= ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(a + " + " + b + " = " + (a + b));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
