using System.Text;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            Stack<string> lastCommand = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                
                if (command[0] == "1")
                {
                    sb.Append(command[1]);
                    stack.Push(command[1]);
                    lastCommand.Push("2");
                }
                else if (command[0] == "2")
                {
                    int toRemove = int.Parse(command[1]);
                    string removed = sb.ToString();
                    removed = removed.Substring(sb.Length - toRemove);
                    sb.Remove(sb.Length - toRemove, toRemove).ToString();
                    stack.Push(removed);
                    lastCommand.Push("1");
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(sb[int.Parse(command[1])-1]);
                }
                else if (command[0]=="4")
                {
                    if (lastCommand.Peek()=="2" && stack.Count>0)
                    {
                        lastCommand.Pop();
                        string toRemove = stack.Pop();
                        sb.Remove(sb.ToString().IndexOf(toRemove),toRemove.Length);
                    }
                    else if (lastCommand.Peek()=="1" && stack.Count>0)
                    {
                        lastCommand.Pop();
                        sb.Append(stack.Pop());
                    }
                }

            }
        }
    }
}