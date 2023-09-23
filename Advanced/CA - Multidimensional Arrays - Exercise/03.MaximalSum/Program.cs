namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                int[] rowE = Console.ReadLine().Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = rowE[j];
                }
            }
            int maxSum = int.MinValue;
            int rowStart = 0, colStart = 0;
            for (int i = 0; i < size[0] - 2; i++)
            {
                for (int j = 0; j < size[1] - 2; j++)
                {
                    int currSum = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            currSum += matrix[i + k, j + l];
                        }
                    }
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        rowStart = i;
                        colStart = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Console.Write(matrix[rowStart + k, colStart + l] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}