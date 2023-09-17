namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (command != "End")
            {
                if (command == "Paid" && queue.Count != 0)
                { 
                    for (int i = 0; i < queue.Count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                        i--;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}