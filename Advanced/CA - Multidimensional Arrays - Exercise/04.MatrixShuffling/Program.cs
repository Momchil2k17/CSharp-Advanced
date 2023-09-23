namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(new[] { ' ' }
                     , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                string[] rowE = Console.ReadLine().Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = rowE[j];
                }
            }
            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                string[] info = command.Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (info.Count() !=5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string task = info[0];
                int row1 = int.Parse(info[1]);
                int row2 = int.Parse(info[3]);
                int col1 = int.Parse(info[2]);
                int col2 = int.Parse(info[4]);
                if (task != "swap" || (row1 < 0 || row1 > size[0] - 1) || (row2 < 0 || row2 > size[0] - 1) || col1 < 0 || col1 > size[1] - 1 || col2 < 0 || col2 > size[1] - 1)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string change = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = change;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write("{0} ", matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                }

            }
        }
    }
}