using System.Net.Sockets;

namespace _08.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] rowE = Console.ReadLine().Split(new[] { ' ' }
                     , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowE[j];
                }
            }
            string[] coords= Console.ReadLine().Split(new[] { ' ' }
                     , StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string i in coords)
            {
                int[] info = i.Split(",").Select(int.Parse).ToArray();
                int row = info[0];
                int col = info[1];
                int bomb = matrix[row, col];
                if (bomb>0)
                {
                    BombExplotion(matrix, row, col, bomb);
                    matrix[row, col] = 0;
                }
            }
            int aliveCells = 0;
            int sum = 0;
            foreach (var cell in matrix)
            {
                if (cell > 0)
                {
                    aliveCells++;
                    sum += cell;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}\nSum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void BombExplotion(int[,] matrix, int row, int col, int bomb)
        {
            for (int r = row - 1; r <= row + 1; r++)
            {
                if (r < 0 || r >= matrix.GetLength(0))
                    continue;

                for (int c = col - 1; c <= col + 1; c++)
                {
                    if (c < 0 || c >= matrix.GetLength(1))
                        continue;

                    if (matrix[r, c] > 0)
                        matrix[r, c] -= bomb;
                }
            }
        }
    }
}