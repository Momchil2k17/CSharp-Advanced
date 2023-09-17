namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int toPush = nums[0];
            int toPop = nums[1];
            int cont = nums[2];
            Queue<int> queue = new Queue<int>();
            int[] nums2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < toPush; i++)
            {
                queue.Enqueue(nums2[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(cont))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}