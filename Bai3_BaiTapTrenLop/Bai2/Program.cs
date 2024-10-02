namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào dãy số nguyên, cách nhau bởi dấu cách:");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                numbers[i] = int.Parse(inputArray[i]);
            }
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }
            Console.WriteLine("Dãy số chẵn:");
            foreach (int even in evenNumbers)
            {
                Console.Write(even + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Dãy số lẻ:");
            foreach (int odd in oddNumbers)
            {
                Console.Write(odd + " ");
            }
            Console.WriteLine();
        }
    }
}
