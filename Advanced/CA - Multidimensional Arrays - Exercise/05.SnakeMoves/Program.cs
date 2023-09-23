namespace _05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(new[] { ' ' }
                     , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            char[,] matrix = new char[size[0], size[1]];
            string left = "";
            for (int i = 0; i < size[0]; i++)
            {
                left += input;
                int k = 0, used = 1;
                for (int j = 0; j < size[1]; j++)
                {
                    if (i % 2 == 0)
                    {
                        matrix[i, j] = left[k];
                    }
                    else
                    {
                        matrix[i, size[1] - 1 - j] = left[k];
                    }
                    k++;
                    if (k >= left.Length)
                    {
                        k = 0;
                        used++;
                    }
                }
                if (used != 1)
                {
                    left = left.Substring(used * left.Length - size[1]);
                }
                else
                {
                    left = left.Substring(size[1]);
                }

            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}