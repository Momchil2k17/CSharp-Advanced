using System.Data;

namespace _01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            for (int i = 0; i < sizes[0]; i++) 
            {
                int[] row=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i,j] = row[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < sizes[0]; i++)
            {
                for (int j = 0; j < sizes[1]; j++)
                {
                sum+= matrix[i,j];
                }
            }
            Console.WriteLine(sizes[0]);
            Console.WriteLine(sizes[1]);
            Console.WriteLine(sum);
        }
    }
}