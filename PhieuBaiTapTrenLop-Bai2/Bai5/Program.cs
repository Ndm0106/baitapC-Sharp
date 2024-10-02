using System.Text;

namespace Bai5
{
    internal class Program
    {
        static string DecimalToBase(int number, int baseValue)
        {
            string result = "";
            string digits = "0123456789ABCDEF";

            while (number > 0)
            {
                int remainder = number % baseValue;
                result = digits[remainder] + result;
                number /= baseValue;
            }

            return result == "" ? "0" : result;
        }

        // Chuyển đổi số N từ hệ cơ số B sang hệ cơ số 10
        static int BaseToDecimal(string number, int baseValue)
        {
            int result = 0;
            int power = 1; // base^0

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char digit = number[i];
                int digitValue;

                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = char.ToUpper(digit) - 'A' + 10;
                }

                if (digitValue >= baseValue)
                {
                    throw new ArgumentException($"Số không hợp lệ trong hệ cơ số {baseValue}.");
                }

                result += digitValue * power;
                power *= baseValue;
            }

            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8; 
                Console.Write("Nhập số nguyên dương N: ");
                int N = int.Parse(Console.ReadLine());

                // Nhập hệ cơ số B để chuyển đổi
                Console.Write("Nhập hệ cơ số B (từ 2 đến 16): ");
                int B = int.Parse(Console.ReadLine());

                if (B < 2 || B > 16)
                {
                    Console.WriteLine("Hệ cơ số B phải nằm trong khoảng từ 2 đến 16.");
                    return;
                }

                // Chuyển đổi số nguyên từ hệ cơ số 10 sang hệ cơ số B
                string numberInBaseB = DecimalToBase(N, B);
                Console.WriteLine($"Số {N} trong hệ cơ số {B} là: {numberInBaseB}");

                // Nhập số N dưới dạng chuỗi trong hệ cơ số B
                Console.Write($"Nhập số cần chuyển đổi từ hệ cơ số {B} sang hệ cơ số 10: ");
                string numberInBaseBInput = Console.ReadLine();

                // Chuyển đổi từ hệ cơ số B sang hệ cơ số 10
                int numberInDecimal = BaseToDecimal(numberInBaseBInput, B);
                Console.WriteLine($"Số {numberInBaseBInput} trong hệ cơ số {B} là {numberInDecimal} trong hệ cơ số 10.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
