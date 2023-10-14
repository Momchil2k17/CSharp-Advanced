using System.ComponentModel;

namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            Func<string, List<int>, List<int>> add = (command, numbers) =>
            {
                List<int> result = new();

                foreach (var number in numbers)
                {
                    switch (command)
                    {
                        case "add":
                            result.Add(number + 1);
                            break;
                        case "multiply":
                            result.Add(number * 2);
                            break;
                        case "subtract":
                            result.Add(number - 1);
                            break;
                    }
                }
                return result;
            };
            Action<List<int>> print = numbers =>
            Console.WriteLine(string.Join(" ", numbers));
            while (command!="end")
            {
                if (command=="print")
                {
                    print(numbers);
                }
                else
                {
                    numbers=add(command,numbers);
                }
                command= Console.ReadLine();
            }
            
        }
    }
}