namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(" "));
            int n=int.Parse(Console.ReadLine());
            int tosses = 0;
            while (queue.Count>1)
            {
                tosses++;
                if (tosses==n) 
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                    tosses = 0;
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}