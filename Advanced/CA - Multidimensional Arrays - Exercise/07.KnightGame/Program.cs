namespace _07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix=new char[n,n];
            for (int i = 0; i < n; i++)
            {
                string rowE= Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowE[j];
                }
            }
            int removed= 0;
            while (true)
            {
                int maxKnightsRemove = 0;
                int toRemoveRow = 0,toRemoveCol=0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currElement = matrix[row, col];
                        if (currElement=='K')
                        {
                            int knightsRemove = 0;
                            if (IsCellValid(row - 2, col - 1, n, n))
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                    knightsRemove++;
                            }

                            if (IsCellValid(row - 2, col + 1, n, n))
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                    knightsRemove++;
                            }

                            if (IsCellValid(row + 2, col - 1, n, n))
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                    knightsRemove++;
                            }

                            if (IsCellValid(row + 2, col + 1, n, n))
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                    knightsRemove++;
                            }

                            if (IsCellValid(row - 1, col - 2, n, n))
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                    knightsRemove++;
                            }

                            if (IsCellValid(row + 1, col - 2, n, n))
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                    knightsRemove++;
                            }

                            if (IsCellValid(row - 1, col + 2, n, n))
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                    knightsRemove++;
                            }

                            if (IsCellValid(row + 1, col + 2, n, n))
                            {
                                if (matrix[row + 1, col + 2] == 'K')
                                    knightsRemove++;
                            }

                            if (knightsRemove > maxKnightsRemove)
                            {
                                maxKnightsRemove = knightsRemove;
                                toRemoveRow = row;
                                toRemoveCol = col;
                            }
                        }
                    }
                }
                if (maxKnightsRemove == 0)
                    break;

                else
                {
                    matrix[toRemoveRow,toRemoveCol]= '0';
                    removed++;
                }
            }
          
            Console.WriteLine(removed);
        }
        static bool IsCellValid(int row, int col, int rows, int cols)
        {
            return row >= 0 && col >= 0 && row < rows && col < cols;
        }
    }
    
}
