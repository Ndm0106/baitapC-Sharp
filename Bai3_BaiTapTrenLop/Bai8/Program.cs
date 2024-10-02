namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập chuỗi từ bàn phím
            Console.Write("Nhập chuỗi ký tự: ");
            string s = Console.ReadLine();

            // Kiểm tra tính đối xứng
            if (IsPalindrome(s))
            {
                Console.WriteLine("Chuỗi vừa nhập là đối xứng.");
            }
            else
            {
                Console.WriteLine("Chuỗi vừa nhập không phải là đối xứng.");
            }
        }
        static bool IsPalindrome(string s)
        {
            // Loại bỏ các khoảng trắng và chuyển tất cả ký tự về chữ thường
            string cleanedString = s.Replace(" ", "").ToLower();

            // So sánh chuỗi với đảo ngược của nó
            string reversedString = ReverseString(cleanedString);
            return cleanedString == reversedString;
        }

        // Phương thức đảo ngược chuỗi
        static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
