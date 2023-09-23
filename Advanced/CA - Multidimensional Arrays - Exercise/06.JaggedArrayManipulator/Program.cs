namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];
            for (int row = 0; row < n; row++)
            {
                double[] rowE = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                jagged[row] = rowE;
            }
            for (int row = 0; row < n - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] info = command.Split(' ').ToArray();
                int row = int.Parse(info[1]);
                int col = int.Parse(info[2]);
                int value = int.Parse(info[3]);
                if (info[0] == "Add")
                {
                    try
                    {
                        jagged[row][col] += value;
                    }
                    catch (Exception)
                    {


                    }
                }
                if (info[0] == "Subtract")
                {
                    try
                    {
                        jagged[row][col] -= value;
                    }
                    catch (Exception)
                    {


                    }
                }
                command = Console.ReadLine();
            }
            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}