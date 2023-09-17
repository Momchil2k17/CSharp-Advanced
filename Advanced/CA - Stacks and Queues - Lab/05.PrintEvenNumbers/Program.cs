namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int count=queue.Count;
            for (int i = 0; i <count; i++)
            {
                if (queue.Peek()%2==0)
                {
                    queue.Enqueue(queue.Peek());
                }
                queue.Dequeue();
            }
            Console.WriteLine(string.Join(", ",queue));
        }
    }
}