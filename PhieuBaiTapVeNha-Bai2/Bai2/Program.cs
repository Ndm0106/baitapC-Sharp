using System.Text;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("nhập chuỗi: ");
            string chuoi = Console.ReadLine();
            for (int i = 0; i < chuoi.Length; i++)
            {
                Console.WriteLine(chuoi[i]);
            }




            Console.WriteLine("câu b");
            Console.Write("nhập chuỗi: ");
            string chuoiKhongKhoangTrang = Console.ReadLine();
            string[] words = chuoiKhongKhoangTrang.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {

                Console.WriteLine(words[i]);
            }



            Console.WriteLine("\nNhập vào một chuỗi để đếm số lần xuất hiện của mỗi ký tự:");
            string inputStringForCounting = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in inputStringForCounting)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            Console.WriteLine("Số lần xuất hiện của mỗi ký tự:");
            foreach (var pair in charCount)
            {
                Console.WriteLine($"Ký tự '{pair.Key}': {pair.Value} lần");
            }
        }
    }
}
