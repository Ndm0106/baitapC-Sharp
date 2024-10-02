namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "matrix.txt";
            int[,] matrix = DocMaTranTuFile(filePath);
            int tong = TinhTongMaTran(matrix);
            Console.WriteLine($"Tổng các phần tử của ma trận: {tong}");
            GhiTongVaoFile(filePath, tong);
        }

        
        static int[,] DocMaTranTuFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int rows = int.Parse(lines[0]);
            int cols = int.Parse(lines[1]);
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i + 2].Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }  
        static int TinhTongMaTran(int[,] matrix)
        {
            int tong = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tong += matrix[i, j];
                }
            }
            return tong;
        }
        static void GhiTongVaoFile(string filePath, int tong)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Tổng: {tong}");
            }
        }
    }
}
