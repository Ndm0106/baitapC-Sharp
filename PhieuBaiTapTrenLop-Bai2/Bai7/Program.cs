namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"c:\source\file.txt"; // Đường dẫn tới file nguồn cần sao chép
            string destinationFile = @"d:\target\file.txt"; // Đường dẫn tới file đích

            // Cách 1: Sử dụng lớp File
            Console.WriteLine("Sao chép file bằng lớp File:");
            try
            {
                // Sử dụng phương thức File.Copy để sao chép file
                File.Copy(sourceFile, destinationFile, true);
                Console.WriteLine("Sao chép thành công bằng lớp File.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sao chép file bằng lớp File: " + ex.Message);
            }

            // Cách 2: Sử dụng StreamReader và StreamWriter
            //Console.WriteLine("\nSao chép file bằng StreamReader và StreamWriter:");
            //try
            //{
            //    using (StreamReader reader = new StreamReader(sourceFile))
            //    using (StreamWriter writer = new StreamWriter(destinationFile))
            //    {
            //        string line;
            //        Đọc từng dòng từ file nguồn và ghi vào file đích
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            writer.WriteLine(line);
            //        }
            //    }
            //    Console.WriteLine("Sao chép thành công bằng StreamReader và StreamWriter.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Lỗi khi sao chép file bằng StreamReader và StreamWriter: " + ex.Message);
            //}

        }
    }
}
