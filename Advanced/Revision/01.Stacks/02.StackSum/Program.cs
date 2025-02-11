namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ints = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)));
            string com = Console.ReadLine().ToLower();
            while (com != "end")
            {
                string[] tokens = com.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "add")
                {
                    ints.Push(int.Parse(tokens[1]));
                    ints.Push(int.Parse(tokens[2]));
                }
                else if (tokens[0] == "remove")
                {
                    if (int.Parse(tokens[1]) <= ints.Count)
                    {
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {
                            ints.Pop();
                        }
                    }
                }
                com = Console.ReadLine().ToLower();
            }
            
            Console.WriteLine($"Sum: {ints.Sum()}");
        }
    }
}
