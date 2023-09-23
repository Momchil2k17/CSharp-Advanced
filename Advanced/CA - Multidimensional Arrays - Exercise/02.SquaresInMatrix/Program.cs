﻿namespace _2.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            for (int row = 0; row < size[0]; row++)
            {
                string[] rowE = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = rowE[col];
                }
            }
            int count = 0;
           
            for (int row = 0; row < size[0] - 1; row++)
            {
                for (int col = 0; col < size[1] - 1; col++)
                {
                    if (matrix[row, col]==matrix[row + 1, col] && matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}