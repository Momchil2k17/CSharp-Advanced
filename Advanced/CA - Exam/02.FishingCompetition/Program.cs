namespace _02FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] sea = new char[n, n];
            int startRow=0, startCol = 0;
            int tons = 0;
            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    sea[i, j] = row[j];
                    if (sea[i, j]=='S')
                    {
                        startRow=i; startCol=j;
                        sea[startRow, startCol] = '-';
                    }
                }
            }
            string command;
            while ((command=Console.ReadLine())!= "collect the nets") 
            {
                if (command=="left")
                {
                    if (startCol==0)
                    {
                        startCol = n - 1;
                    }
                    else 
                    {
                        startCol--;
                    }
                }
                else if (command=="right")
                {
                    if (startCol == n-1)
                    {
                        startCol = 0;
                    }
                    else
                    {
                        startCol++;
                    }
                }
                else if (command=="up")
                {
                    if (startRow==0)
                    {
                        startRow = n - 1;
                    }
                    else
                    {
                        startRow--;
                    }
                }
                else if (command == "down")
                {
                    if (startRow == n-1)
                    {
                        startRow = 0;
                    }
                    else
                    {
                        startRow++;
                    }
                }

                if (char.IsDigit(sea[startRow,startCol]))
                {
                    int currentTon = sea[startRow,startCol]-'0';
                    tons += currentTon;
                    sea[startRow, startCol] = '-';
                }
                if (sea[startRow, startCol]=='W')
                {
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{startRow},{startCol}]");
                    return;
                }
            }
            sea[startRow, startCol] = 'S';
            if (tons>=20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
                Console.WriteLine($"Amount of fish caught: {tons} tons.");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20-tons} tons of fish more.");
                if (tons>0)
                {
                    Console.WriteLine($"Amount of fish caught: {tons} tons.");
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sea[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}