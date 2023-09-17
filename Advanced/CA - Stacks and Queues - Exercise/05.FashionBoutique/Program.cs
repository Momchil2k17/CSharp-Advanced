namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int count = stack.Count;
            int racks = 1, sum = 0;
            while (stack.Count > 0)
            {
                if (sum + stack.Peek() <= capacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }
            Console.WriteLine(racks);
        }
    }
}