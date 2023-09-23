namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int sum1 = 0,sum2=0;
            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[i, i];
                sum2 += matrix[n - 1 - i, i];
            }
            Console.WriteLine(Math.Abs(sum1-sum2));
        }
    }
}