namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] querries= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (querries[0]==1)
                {
                    stack.Push(querries[1]);
                }
                else if (querries[0]==2)
                {
                    stack.Pop();
                }
                else if (stack.Count()>0 && querries[0]==3)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (stack.Count>0 && querries[0]==4)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ",stack));
        }
    }
}