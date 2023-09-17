namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string command = Console.ReadLine();
            int count = 0;
            while(command!="end")
            {
                if (command!="green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    int toPass=Math.Min(n, queue.Count);
                    for (int i = 0; i < toPass; i++)
                    {
                        Console.WriteLine(queue.Dequeue()+" passed!");
                        count++;
                    }
                }
                command= Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");

        }
    }
}