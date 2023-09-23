namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int row = 0; row < size[0]; row++)
            {
                int[] rowE = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = rowE[col];
                }
            }
            int sum = 0;
            int max = int.MinValue;
            int leftR = 0, leftC = 0;
            for (int row = 0; row < size[0] - 1; row++)
            {
                for (int col = 0; col < size[1] - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row, col + 1];
                    if (sum > max)
                    {
                        leftR = row;
                        leftC = col;
                        max = sum;
                    }
                }
            }
            Console.WriteLine($"{matrix[leftR, leftC]} {matrix[leftR, leftC + 1]}");
            Console.WriteLine($"{matrix[leftR + 1, leftC]} {matrix[leftR + 1, leftC + 1]}");
            Console.WriteLine(max);
        }
    }
}
