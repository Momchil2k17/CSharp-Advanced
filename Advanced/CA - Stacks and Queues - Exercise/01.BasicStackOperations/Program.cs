namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int toPush = nums[0];
            int toPop = nums[1];
            int cont = nums[2];
            Stack<int> stack = new Stack<int>();
            int[] nums2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < toPush; i++) 
            {
                stack.Push(nums2[i]);
            }
            for (int i = 0;i < toPop; i++) 
            {
                stack.Pop();
            }
            if (stack.Contains(cont))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count>0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}