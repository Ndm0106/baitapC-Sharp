using System.Drawing;
using System;
using System.Text;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = InputArr();
            int max = FindMax(array);
            int min = FindMin(array);
            int sum = CalculateSum(array);

            Console.WriteLine($"Số lớn nhất: {max}");
            Console.WriteLine($"Số nhỏ nhất: {min}");
            Console.WriteLine($"Tổng các phần tử: {sum}");
        }
        static int[] InputArr()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số kích thước mảng: ");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.Write("Vui lòng nhập lại kích thước mảng: ");
                n = int.Parse(Console.ReadLine());
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a["+i+"]:");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int FindMin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int CalculateSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

    }
}
