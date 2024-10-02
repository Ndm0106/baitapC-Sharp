namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Đọc tên file đầu vào và đầu ra từ người dùng
            Console.Write("Nhập tên file đầu vào: ");
            string inputFile = Console.ReadLine();

            Console.Write("Nhập tên file đầu ra: ");
            string outputFile = Console.ReadLine();

            try
            {
                // Đọc nội dung của file văn bản có sẵn
                string content;
                using (StreamReader reader = new StreamReader(inputFile))
                {
                    content = reader.ReadToEnd();
                }

                // Chuyển toàn bộ văn bản thành chữ hoa
                string upperContent = content.ToUpper();

                // Lưu nội dung chữ hoa vào file mới
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.Write(upperContent);
                }

                // Đếm số từ trong file văn bản gốc
                int wordCount = CountWords(content);

                // Thêm số lượng từ vào cuối file văn bản chữ hoa
                using (StreamWriter writer = new StreamWriter(outputFile, append: true))
                {
                    writer.WriteLine(); // Thêm dòng trống trước khi thêm số từ
                    writer.WriteLine($"Số lượng từ: {wordCount}");
                }

                Console.WriteLine("Xử lý thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        static int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            // Tách chuỗi thành các từ dựa trên khoảng trắng và ký tự xuống dòng
            string[] words = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
