namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split(" ").ToList();
            strings.Reverse();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < strings.Count; i++)
            {
                stack.Push(strings[i]);
            }
            int sum = int.Parse(stack.Pop());
            while (stack.Count>0)
            {
                if (stack.Pop()=="+")
                {
                    sum += int.Parse(stack.Pop());
                }
                else
                {
                    sum -= int.Parse(stack.Pop());
                }
            }
            Console.WriteLine(sum);
        }
    }
}