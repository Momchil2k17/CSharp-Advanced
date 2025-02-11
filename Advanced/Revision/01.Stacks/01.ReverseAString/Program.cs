using System.Text;

namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            StringBuilder sb = new StringBuilder(input.Length);
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
