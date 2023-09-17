namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack<int> ints = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            string command=Console.ReadLine().ToLower();
            while (command != "end") 
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0]=="add")
                {
                    int first = int.Parse(info[1]);
                    int second = int.Parse(info[2]);
                    ints.Push(first); ints.Push(second);
                }
                else if (info[0]=="remove")
                {
                    int n = int.Parse(info[1]);
                    if (n<=ints.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            ints.Pop();
                        }
                    }
                }
                command=Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {ints.Sum()}");

        }
    }
}